using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Sistema_Comercial___Marine_Center
{
    public partial class frmOrdemServico : Form
    {
        public frmOrdemServico()
        {
            InitializeComponent();
        }



        private List<Produto> produtos = new List<Produto>();
        private List<Produto> produtosSelecionados = new List<Produto>();
        private double subTotal = 0;
        private double frete = 0, desconto = 0, mao_obra = 0;

        private double valorOS = 0;

        public double ValorOS
        {
            get
            {
                return valorOS;
            }
            set
            {
                txtValorOSServicos.Text = value.ToString();
                valorOS = value;
            }
        }


        private void txtValorFreteServicos_TextChanged(object sender, EventArgs e)
        {

        }

        public void atualizarCb(int Index) //0 para todos, 1 soh para o primeiro, 2 soh para o segundo e 3 soh para o terceiro
        {
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            string query = "SELECT ID, NOME FROM CLIENTE WHERE ID != 0 ORDER BY NOME ";
            FbCommand fbCmd = new FbCommand(query, fbConn);



            string queryPecas = "SELECT ID, TITULO, PRECO_VENDA FROM ESTOQUE ORDER BY TITULO";
            FbCommand fbCmdPecas = new FbCommand(queryPecas, fbConn);

            string queryID = "SELECT gen_id(gen_servicos,0) from rdb$database;";
            FbCommand fbCmdId = new FbCommand(queryID, fbConn);



            try
            {
                Cursor.Current = Cursors.WaitCursor;
                fbConn.Open();
                FbDataReader rID = fbCmdId.ExecuteReader();
                if (rID.Read())
                {
                    int id;
                    Int32.TryParse(rID[0].ToString(),out id);
                    id++;
                    txtNumeroOSServicos.Text = id.ToString();
                }
                //Clientes
                if ((Index == 0) || (Index == 1))
                {
                    FbDataReader r = fbCmd.ExecuteReader();
                    while (r.Read())
                    {
                        if (r[0].ToString().Trim() != "")
                        retorno.Add(Convert.ToInt32(r[0].ToString()), r[1].ToString());
                    }
                    if (retorno.Count != 0)
                    {
                        cbClientesServico.DataSource = new BindingSource(retorno, null);
                        cbClientesServico.DisplayMember = "Value";
                        cbClientesServico.ValueMember = "Key";
                        cbClientesServico.Refresh();
                    }
                }


                //Pecas
                if ((Index == 0) || (Index == 3))
                {
                    FbDataReader rPecas = fbCmdPecas.ExecuteReader();

                    retorno.Clear();
                    Produto p;
                    while (rPecas.Read())
                    {
                        p = new Produto();
                        p.ID = Convert.ToInt32(rPecas[0].ToString());
                        p.Titulo = rPecas[1].ToString();
                        try
                        {
                            p.Preco_venda = Convert.ToDouble(rPecas[2].ToString());
                        }
                        catch (Exception)
                        {

                            p.Preco_venda = 0;
                        }
                        
                        produtos.Add(p);

                        if (rPecas[1].ToString() != "")
                            retorno.Add(Convert.ToInt32(rPecas[0].ToString()), rPecas[1].ToString());
                    }
                    if (retorno.Count != 0)
                    {
                        cbPecasServicos.DataSource = new BindingSource(retorno, null);
                        cbPecasServicos.DisplayMember = "Value";
                        cbPecasServicos.ValueMember = "Key";
                        cbPecasServicos.Refresh();
                    }
                }


            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados: " + fbex.Message, "Erro");

            }
            finally
            {
                fbConn.Close();
                Cursor.Current = Cursors.Default;
            }
        }

        private void btAdicionarClienteServico_Click(object sender, EventArgs e)
        {
            CadCliente frm = new CadCliente();
            frm.sNome = cbClientesServico.Text;
            frm.veioDeOS = true;
            frm.ShowDialog();
            atualizarCb(1);
            cbClientesServico.SelectedIndex = cbClientesServico.FindString(frm.sNome);

        }

        private void frmOrdemServico_Shown(object sender, EventArgs e)
        {
            txtDataEntradaServicos.Text = DateTime.Today.ToString("dd/MM/yyyy");
            atualizarCb(0);
        
        }


        private void btAdicionarPecasServicos_Click(object sender, EventArgs e)
        {
            if (cbPecasServicos.SelectedItem != null)
            {
                var q = from p in produtos where p.ID == Convert.ToInt32(cbPecasServicos.SelectedValue.ToString()) select p;

                foreach (Produto item in q)
                {
                    int quantidade;
                    Int32.TryParse(txtQuantidadePeca.Text, out quantidade);
                    item.Quantidade = quantidade;
                    produtosSelecionados.Add(item);
                    double total = item.Preco_venda * item.Quantidade;
                    lbPecasServicos.Items.Add(string.Format("{0} | {1} | R${2} | Total R${3}", item.Titulo, item.Quantidade, item.Preco_venda, total));
                    subTotal += total;
                    ValorOS = subTotal;
                }

                txtQuantidadePeca.Clear();
            }
            else
            {
                if (Funcoes.Usuario == Funcoes.TUsuarios.Administrador)
                {
                    CadProduto frm = new CadProduto();
                    frm.sTitulo = cbPecasServicos.Text;
                    frm.veioDeOS = true;
                    frm.ShowDialog();
                    atualizarCb(3);
                    cbPecasServicos.SelectedIndex = cbPecasServicos.FindString(frm.sTitulo);
                }
            }
        }

        private bool VerificarPreenchimento()
        {
            bool retorno = true;
            foreach (var txt in groupBox2.Controls)
            {
                if (txt is TextBox)
                {

                    if ((txt as TextBox).Text == "")
                    {
                        if (MessageBox.Show("Nem todos os campos foram preenchidos, deseja continuar, isso pode ocasionar erros?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            return true;

                        else
                        {

                            (txt as TextBox).Focus();
                            return false;
                        }
                    }
                }
            }

            foreach (var txt in groupBox5.Controls)
            {
                if (txt is TextBox)
                {

                    if ((txt as TextBox).Text == "")
                    {
                        if (MessageBox.Show("Nem todos os campos foram preenchidos, deseja continuar, isso pode ocasionar erros?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            return true;

                        }
                        else
                        {

                            (txt as TextBox).Focus();
                            return false;
                        }
                    }
                }
            }
            return retorno;
        }

        private void btSalvarServicos_Click(object sender, EventArgs e)
        {
            if (VerificarPreenchimento())
            {

                FbConnection fbConn = new FbConnection(Funcoes.strConn);

                string queryInsert = string.Format("INSERT INTO SERVICO (ID_CLIENTE,NUMERO_OS,COR,DATA_ENTRADA,ANO,MODELO,CHASSI,MEC_RESPONSAVEL,DATA_ENTREGA,DESCONTO,VALOR_FRETE,VALOR_OS,GARANTIA,MAO_OBRA,HR_KM,DESCRICAO, PARECER_TECNICO, CATEGORIA ) VALUES ({0}, @NUMERO_OS, @COR, @DATA_ENTRADA, @ANO, @MODELO, @CHASSI, @MEC_RESPONSAVEL, @DATA_ENTREGA, @DESCONTO, @VALOR_FRETE, @VALOR_OS, @GARANTIA, @MAO_OBRA, @HR_KM, @DESCRICAO, @PARECER_TECNICO, @CATEGORIA);",
                    cbClientesServico.SelectedValue);
                FbCommand fbCmdInsert = new FbCommand();


                //PARAMETROS
                FbParameter[] prmParametro = new FbParameter[17];


                prmParametro[0] = new FbParameter("@HR_KM", txtHrKm.Text);
                prmParametro[1] = new FbParameter("@NUMERO_OS", txtNumeroOSServicos.Text);
                prmParametro[2] = new FbParameter("@COR", txtCorServicos.Text);
                prmParametro[3] = new FbParameter("@DATA_ENTRADA", Convert.ToDateTime(txtDataEntradaServicos.Text));
                prmParametro[4] = new FbParameter("@ANO", txtAnoServico);
                prmParametro[5] = new FbParameter("@MODELO", txtModeloServicos.Text);
                prmParametro[6] = new FbParameter("@CHASSI", txtChassiServicos.Text);
                prmParametro[7] = new FbParameter("@MAO_OBRA", Convert.ToDouble(txtMaoDeObra.Text));
                prmParametro[8] = new FbParameter("@MEC_RESPONSAVEL", txtResposavelTecnico.Text);
                prmParametro[9] = new FbParameter("@DATA_ENTREGA", DateTime.Today);
                prmParametro[10] = new FbParameter("@DESCONTO", Convert.ToDouble(txtDescontoServicos.Text));
                prmParametro[11] = new FbParameter("@VALOR_FRETE", Convert.ToDouble(txtDeslocamento.Text));
                prmParametro[12] = new FbParameter("@VALOR_OS", ValorOS);

                if (cxGarantia.Checked)
                    prmParametro[13] = new FbParameter("@GARANTIA", "SIM");
                else
                    prmParametro[13] = new FbParameter("@GARANTIA", "NÃO");


                prmParametro[14] = new FbParameter("@DESCRICAO", rtDescricaoServico.Text);
                
                prmParametro[15] = new FbParameter("@PARECER_TECNICO",rtParecerTecnico.Text);
                
                prmParametro[16] = new FbParameter("@CATEGORIA", cbCategoriaOS.Text);
               


                foreach (FbParameter p in prmParametro)
                {

                    fbCmdInsert.Parameters.Add(p);

                }

                try
                {

                    fbConn.Open();

                    fbCmdInsert.Connection = fbConn;
                    fbCmdInsert.CommandType = CommandType.Text;
                    fbCmdInsert.CommandText = queryInsert;
                    fbCmdInsert.ExecuteNonQuery();


                    FbCommand fbCmdID = new FbCommand("Select ID, NUMERO_OS from SERVICO where NUMERO_OS = '" + txtNumeroOSServicos.Text + "'", fbConn);
                    FbDataAdapter fbDa = new FbDataAdapter(fbCmdID);
                    DataTable dtUsuarios = new DataTable();
                    fbDa.Fill(dtUsuarios);
                    int ID_SERVICO = 2;
                    foreach (DataRow item in dtUsuarios.Rows)
                    {
                        ID_SERVICO = Convert.ToInt32(item[0].ToString());
                    }


                    //Cadastro ProdutoServico
                    foreach (Produto item in produtosSelecionados)
                    {
                        queryInsert = string.Format("INSERT INTO SERVICO_PRODUTOS (ID_SERVICO, ID_PRODUTO, QUANTIDADE) VALUES ({0},{1},{2})",
                                                           ID_SERVICO, item.ID, item.Quantidade);
                        FbCommand fbCmdInsertProduto = new FbCommand(queryInsert, fbConn);
                        fbCmdInsertProduto.ExecuteNonQuery();
                    }







                    MessageBox.Show("Item cadastrado com sucesso!");
                    btLimparServicos_Click(sender, e);




                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados: " + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }
            }

        }

        private void txtValorFreteServicos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != (char)Keys.Delete) && (e.KeyChar != (char)Keys.Back) && ((e.KeyChar < '0') || (e.KeyChar > '9')))
                e.Handled = true;
        }


        private void txtDeslocamento_Leave(object sender, EventArgs e)
        {
            if (txtDeslocamento.Text != "")
                frete = Convert.ToDouble(txtDeslocamento.Text);
            else
                frete = 0;

            if (txtMaoDeObra.Text != "")
                mao_obra = Convert.ToDouble(txtMaoDeObra.Text);
            else
                mao_obra = 0;

            if (txtDescontoServicos.Text != "")
                desconto = Convert.ToDouble(txtDescontoServicos.Text);
            else
                desconto = 0;

            ValorOS = subTotal + frete + mao_obra - desconto;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (lbPecasServicos.SelectedItem != null)
            {
                if (MessageBox.Show("Você tem certeza que deseja eliminar essa peça da lista", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string s = lbPecasServicos.SelectedItem.ToString().Split('|')[0].Trim();
                    Produto q = (from p in produtosSelecionados where p.Titulo.Trim() == s  select p).First();

                    
                        produtosSelecionados.Remove(q);
                        double total = q.Preco_venda * q.Quantidade;
                        subTotal -= total;
                        ValorOS = subTotal;
                        

                    
                    lbPecasServicos.Items.Remove(lbPecasServicos.SelectedItem);
                }
            }
            /*
        if (cbPecasServicos.SelectedItem != null)
        {
            var q = from p in produtos where p.ID == Convert.ToInt32(cbPecasServicos.SelectedValue.ToString()) select p;

            foreach (Produto item in q)
            {
                item.Quantidade = Convert.ToInt32(txtQuantidadePeca.Text);
                produtosSelecionados.Add(item);
                double total = item.Preco_venda * item.Quantidade;
                lbPecasServicos.Items.Add(string.Format("{0}  {1}  R${2}  Total R${3}", item.Titulo, item.Quantidade, item.Preco_venda, total));
                ValorOS += total;
                subTotal = ValorOS;
            }

            txtQuantidadePeca.Clear();
        }*/
        }



        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Produto i in produtosSelecionados)
            {
                MessageBox.Show(i.Titulo);
            }
        }

        private void btLimparServicos_Click(object sender, EventArgs e)
        {
            foreach (var txt in groupBox2.Controls)
            {
                if (txt is TextBox)
                {

                    if ((txt as TextBox).Text == "")
                        (txt as TextBox).Clear();
                }
            }
                rtDescricaoServico.Clear();

            foreach (var txt in groupBox5.Controls)
            {
                if (txt is TextBox)
                    (txt as TextBox).Clear();  
            }
            
             
			 lbPecasServicos.Items.Clear();
             txtResposavelTecnico.Clear();
             rtParecerTecnico.Clear();
             ValorOS = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Sistema_Comercial___Marine_Center
{
    public partial class frmBaixa : Form
    {
        public frmBaixa()
        {
            InitializeComponent();
        }
        private List<Produto> produtos = new List<Produto>();
        private Produto prod;

        public void atualizarCb()
        {
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            string query = "SELECT ID, NOME FROM CLIENTE ORDER BY NOME";
            FbCommand fbCmd = new FbCommand(query, fbConn);

            string queryPecas = "SELECT ID, TITULO, PRECO_VENDA, QUANTIDADE, PARTNUMBER FROM ESTOQUE ORDER BY TITULO";
            FbCommand fbCmdPecas = new FbCommand(queryPecas, fbConn);

            try
            {
                fbConn.Open();

                //Clientes
              
                    FbDataReader r = fbCmd.ExecuteReader();
                    while (r.Read())
                    {
                        if (r[0].ToString().Trim() != "")
                        retorno.Add(Convert.ToInt32(r[0].ToString()), r[1].ToString());
                    }
                    if (retorno.Count != 0)
                    {
                        cbCliente.DataSource = new BindingSource(retorno, null);
                        cbCliente.DisplayMember = "Value";
                        cbCliente.ValueMember = "Key";
                        cbCliente.Refresh();
                    }
                


                //Pecas
             
                    FbDataReader rPecas = fbCmdPecas.ExecuteReader();
                    double prcVenda;
                    int quant;
                    Produto p;
                    while (rPecas.Read())
                    {
                        p = new Produto();
                        p.ID = Convert.ToInt32(rPecas[0].ToString());
                        p.Titulo = rPecas[1].ToString();

                        Double.TryParse(rPecas[2].ToString(), out prcVenda);
                        p.Preco_venda = prcVenda;

                        Int32.TryParse(rPecas[3].ToString(), out quant);
                        p.Quantidade = quant;
                        p.PartNumber = rPecas[4].ToString();
                        
                        produtos.Add(p);
                    }
           

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

        private void btDarBaixa_Click(object sender, EventArgs e)
        {
            if ((txtQuantidadePeca.Text != ""))
            {
                
                int qnt = Convert.ToInt32(txtQuantidadePeca.Text);
                if (prod.Quantidade < qnt)
                {
                    MessageBox.Show("A quantidade para dar baixa é maior do que a disponível no estoque!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Você tem certeza que deseja dar baixa deste produto","Confirmação",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                    FbConnection fbConn = new FbConnection(Funcoes.strConn);
                    string queryInsert;


                    if (cbCliente.Text != "")
                    {
                        if (cbCliente.SelectedItem != null)
                         queryInsert = string.Format("INSERT INTO SAIDA_ESTOQUE (ID_PRODUTO, MOTIVO, QUANTIDADE, QUANTIDADE_ESTOQUE, ID_CLIENTE, DATA_SAIDA) VALUES ({0}, @MOTIVO, @QUANTIDADE, @QUANTIDADE_ESTOQUE, {1}, @DATA_SAIDA)",
                            prod.ID, cbCliente.SelectedValue);
                        else
                         queryInsert = string.Format("INSERT INTO SAIDA_ESTOQUE (ID_PRODUTO, MOTIVO, QUANTIDADE, QUANTIDADE_ESTOQUE, ID_CLIENTE, DATA_SAIDA) VALUES ({0}, @MOTIVO, @QUANTIDADE, @QUANTIDADE_ESTOQUE, 0 , @DATA_SAIDA)",
                            prod.ID);
                    }
                    else
                    {
                        queryInsert = string.Format("INSERT INTO SAIDA_ESTOQUE (ID_PRODUTO, MOTIVO, QUANTIDADE, QUANTIDADE_ESTOQUE, DATA_SAIDA) VALUES ({0}, @MOTIVO, @QUANTIDADE, @QUANTIDADE_ESTOQUE, @DATA_SAIDA)",
                            prod.ID);
                    }

                    FbCommand fbCmdInsert = new FbCommand();


                    //PARAMETROS
                    FbParameter[] prmParametro = new FbParameter[4];

                    if (rbVendido.Checked)
                    {
                        string sauxiliar = "Venda";
                        if (cbCliente.SelectedItem == null)
                            sauxiliar = "Venda - " + cbCliente.Text;
                        
                        prmParametro[0] = new FbParameter("@MOTIVO", sauxiliar);
                    }
                    else
                        prmParametro[0] = new FbParameter("@MOTIVO", txtMotivo.Text);

                    prmParametro[1] = new FbParameter("@QUANTIDADE", qnt);
                    prmParametro[2] = new FbParameter("@QUANTIDADE_ESTOQUE", (prod.Quantidade - qnt));
                    prmParametro[3] = new FbParameter("@DATA_SAIDA", DateTime.Today);

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


                        MessageBox.Show("Baixa realizada com sucesso");

                    }
                    catch (FbException fbex)
                    {
                        MessageBox.Show("Erro ao acessar o Banco de Dados: " + fbex.Message, "Erro");

                    }
                    finally
                    {
                        fbConn.Close();
                        prod.Quantidade -= qnt;
                        
                    }
                    }
                }
                

            }
            else
                MessageBox.Show("Preencha todos os campos");
        }

        private void btVerEstoque_Click(object sender, EventArgs e)
        {
            frmPesquisaEstoque frm = new frmPesquisaEstoque();
            frm.Show();
        }

        private void frmBaixa_Shown(object sender, EventArgs e)
        {
            atualizarCb();
        }

        private void rbOutros_CheckedChanged(object sender, EventArgs e)
        {
            lblMotivo.Visible = rbOutros.Checked;
            txtMotivo.Visible = rbOutros.Checked;

            lbCliente.Visible = rbVendido.Checked;
            cbCliente.Visible = rbVendido.Checked;
        }

        private void txtPartNumber_Leave(object sender, EventArgs e)
        {
            var queryprod = (from q in produtos where q.PartNumber == txtPartNumber.Text select q);
            if (queryprod.Count() > 0)
            {
                Produto p = queryprod.First();

                if (p != null)
                {
                    txtTitulo.Text = p.Titulo;
                    prod = p;
                }
            }
            else
            {
                prod = null;
                txtTitulo.Clear();
                if (MessageBox.Show("PartNumber não encontrado, deseja cadastrar esse produto", "Informação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CadProduto frm = new CadProduto();
                    frm.veioDeOS = true;
                    frm.txtPartNumber.Text = txtPartNumber.Text;
                    frm.txtPartNumber.Enabled = false;
                    frm.ShowDialog();
                    frm.txtPartNumber.Enabled = true;
                    atualizarCb();
                    txtPartNumber_Leave(sender, e);

                }
            }
        }


  
    }
}

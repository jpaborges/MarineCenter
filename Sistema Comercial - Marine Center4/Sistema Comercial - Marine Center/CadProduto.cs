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
    public partial class CadProduto : Form
    {
        public string strFornecedor;

        public bool ehUpdate = false;


        public string sTitulo
        {
            get
            {
                return txtTitulo.Text;
            }
            set
            {
                txtTitulo.Text = value;
            }
        }

        public bool veioDeOS = false;

        public CadProduto()
        {
            InitializeComponent();
        }

        private void CadProduto_Shown(object sender, EventArgs e)
        {
            Funcoes.Centralizar(panel1, this.Width, Height);

            atualizarCb();

            txtPartNumber.Enabled = !ehUpdate;
            if (ehUpdate)
                PreencherTextBoxs();
            
        }

        private void PreencherTextBoxs()
        {
            FbConnection fbConn = new FbConnection(Funcoes.strConn);
            string query = string.Format("Select * from ESTOQUE where UPPER(PARTNUMBER) = '{0}'", txtPartNumber.Text.ToUpper());
            
             try
            {

                fbConn.Open();
                FbCommand fbCmd = new FbCommand(query, fbConn);
                FbDataReader r = fbCmd.ExecuteReader();

                if (r.Read())
                {
                    txtTitulo.Text = r["TITULO"].ToString();
                    cbLocal.Text = r["LOCAL"].ToString();
                    cbFornecedor.SelectedValue = Convert.ToInt32(r["ID_FORNECEDOR"].ToString());
                    txtPrecoVenda.Text = r["PRECO_VENDA"].ToString();
                    txtPrecoCusto.Text = r["PRECO_CUSTO"].ToString();
                    txtDesconto.Text = r["DESCONTO"].ToString();
                    txtQuantidade.Text = r["QUANTIDADE"].ToString();
                    txtMinimo.Text = r["MINIMO"].ToString();
                    txtObservacoes.Text = r["OBS"].ToString();
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

        private void btAddFornecedor_Click(object sender, EventArgs e)
        {
            frmCadFornecedor frm = new frmCadFornecedor(this);
            frm.sEmpresa = cbFornecedor.Text;
            frm.ShowDialog();
            atualizarCb();
            cbFornecedor.SelectedIndex = cbFornecedor.FindString(strFornecedor);




        }

        public void atualizarCb()
        {
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(Funcoes.strConn);
            string query = "SELECT ID, NOME FROM FORNECEDOR ORDER BY NOME";
            FbCommand fbCmd = new FbCommand(query, fbConn);

            string queryLocal = "SELECT LOCAL FROM ESTOQUE ORDER BY LOCAL";
            FbCommand fbCmdLocal = new FbCommand(queryLocal, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                while (r.Read())
                {
                    retorno.Add(Convert.ToInt32(r[0].ToString()), r[1].ToString());
                }
                if (retorno.Count != 0)
                {
                    cbFornecedor.DataSource = new BindingSource(retorno, null);
                    cbFornecedor.DisplayMember = "Value";
                    cbFornecedor.ValueMember = "Key";
                    cbFornecedor.Refresh();
                }
                FbDataReader rLocal = fbCmdLocal.ExecuteReader();
                cbLocal.Items.Clear();
                while (rLocal.Read())
                {
                    if (rLocal[0].ToString() != "") 
                    cbLocal.Items.Add(rLocal[0].ToString());
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

        private void SalvarAlterar(object sender, EventArgs e)
        {
            double pVenda, pCusto, pDesconto;
            int minimo, quantidade;
            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            string query = string.Format("Select PARTNUMBER from ESTOQUE where UPPER(PARTNUMBER) = '{0}'", txtPartNumber.Text.ToUpper());
            FbCommand fbCmd = new FbCommand(query, fbConn);
            string queryInsert;
            if (ehUpdate)
            {
                queryInsert = string.Format("UPDATE ESTOQUE SET ID_FORNECEDOR = {0}, TITULO = '{1}', LOCAL = '{2}',  PRECO_VENDA = @PREC_VENDA, PRECO_CUSTO = @PREC_CUSTO, DESCONTO = @DESCONTO, QUANTIDADE = @QUANTIDADE, MINIMO = @MINIMO, OBS = '{3}' WHERE (PARTNUMBER = {4})",
                cbFornecedor.SelectedValue, txtTitulo.Text, cbLocal.Text, txtObservacoes.Text, txtPartNumber.Text);
            }
            else
            {
                queryInsert = string.Format("INSERT INTO ESTOQUE (ID_FORNECEDOR, TITULO, PARTNUMBER, LOCAL,  PRECO_VENDA, PRECO_CUSTO, DESCONTO, QUANTIDADE, MINIMO, OBS) VALUES ({0},'{1}', '{2}','{3}' , @PREC_VENDA, @PREC_CUSTO, @DESCONTO,@QUANTIDADE, @MINIMO, '{4}');",
                    cbFornecedor.SelectedValue, txtTitulo.Text, txtPartNumber.Text, cbLocal.Text, txtObservacoes.Text);
            }
            FbCommand fbCmdInsert = new FbCommand();


            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[5];
            Double.TryParse(txtPrecoVenda.Text, out pVenda);
            Double.TryParse(txtPrecoCusto.Text, out pCusto);
            Double.TryParse(txtDesconto.Text, out pDesconto);
            Int32.TryParse(txtMinimo.Text, out minimo);
            Int32.TryParse(txtQuantidade.Text, out quantidade);

            prmParametro[0] = new FbParameter("@PREC_VENDA", pVenda);
            prmParametro[1] = new FbParameter("@PREC_CUSTO", pCusto);
            prmParametro[2] = new FbParameter("@DESCONTO", pDesconto);
            prmParametro[3] = new FbParameter("@MINIMO", minimo);
            prmParametro[4] = new FbParameter("@QUANTIDADE", quantidade);

            foreach (FbParameter p in prmParametro)
            {

                fbCmdInsert.Parameters.Add(p);

            }

            try
            {

                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                if (!r.Read() || ehUpdate)
                {
                    fbCmdInsert.Connection = fbConn;
                    fbCmdInsert.CommandType = CommandType.Text;
                    fbCmdInsert.CommandText = queryInsert;
                    fbCmdInsert.ExecuteNonQuery();
                    if (ehUpdate)
                        MessageBox.Show("Item alterado com sucesso!");
                    else
                        MessageBox.Show("Item cadastrado com sucesso!");

                    if (veioDeOS)
                        Close();
                    else
                        btnLimpar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Item ja existente!\nPara ver os itens ja cadastrados acesse:\nEstoque->Pesquisar");
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehUpdate)
            {
                if (MessageBox.Show("Você tem certeza que deseja alterar o produto?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    SalvarAlterar(sender, e);
            }
            else
                SalvarAlterar(sender,e);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Funcoes.Limpar(panel1);
            cbLocal.Text = "";
        }

        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != (char)Keys.Delete) && (e.KeyChar != (char)Keys.Back) && ((e.KeyChar < '0') || (e.KeyChar > '9')))
                e.Handled = true;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Delete) && (e.KeyChar != (char)Keys.Back) && ((e.KeyChar < '0') || (e.KeyChar > '9')))
                e.Handled = true;
        }

        private void btnPequisar_Click(object sender, EventArgs e)
        {
            frmPesquisaEstoque frm = new frmPesquisaEstoque();
            frm.ShowDialog();
        }

        private void CadProduto_Resize(object sender, EventArgs e)
        {
            Funcoes.Centralizar(panel1, this.Width, Height);
        }

        private void txtPartNumber_Leave(object sender, EventArgs e)
        {
            FbConnection fbConn = new FbConnection(Funcoes.strConn);
            try
            {
                string query = string.Format("Select PARTNUMBER from ESTOQUE where UPPER(PARTNUMBER) = '{0}'", txtPartNumber.Text.ToUpper());
                FbCommand fbCmd = new FbCommand(query, fbConn);
                fbConn.Open();
                FbDataReader r = fbCmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Item ja existente!\nPara ver os itens ja cadastrados acesse:\nEstoque->Pesquisar");
                }

            }
            catch (Exception ee)
            {

                MessageBox.Show("Ocorreu um erro com a seguinte mensagem:\n" + ee.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                fbConn.Close();
            }
        }
    }

    }


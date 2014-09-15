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
    public partial class CadCliente : Form
    {
        public string sNome
        {
            get
            {
                return txtNome.Text;
            }
            set
            {
                txtNome.Text = value;
            }
        }

        public bool veioDeOS = false;
        public bool ehUpdate = false;

        public CadCliente()
        {
            InitializeComponent();
        }

        private void CadCliente_Shown(object sender, EventArgs e)
        {
            Funcoes.Centralizar(panel1, this.Width, Height);
            txtCPF.Enabled = !ehUpdate;
            if (ehUpdate)
                PreencherTextBoxs();
        }

        private void PreencherTextBoxs() 
        {
            FbConnection fbConn = new FbConnection(Funcoes.strConn);
            string query = string.Format("Select * from CLIENTE where UPPER(CPF) = '{0}'", txtCPF.Text.ToUpper());

            try
            {

                fbConn.Open();
                FbCommand fbCmd = new FbCommand(query, fbConn);
                FbDataReader r = fbCmd.ExecuteReader();

                if (r.Read())
                {
                    txtNome.Text = r["NOME"].ToString();
                    txtEmail.Text = r["EMAIL"].ToString();
                    txtIdentidade.Text = r["IDENTIDADE"].ToString();
                    txtEndereco.Text = r["ENDERECO"].ToString();
                    txtBairro.Text = r["BAIRRO"].ToString();
                    txtCidade.Text = r["CIDADE"].ToString();
                    txtUF.Text = r["UF"].ToString();
                    txtTelefone1.Text = r["FONE"].ToString();
                    txtTelefone2.Text = r["FONE2"].ToString();
                    txtObs.Text = r["OBS"].ToString();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Funcoes.Limpar(panel1);
        }

        private void SalvarAlterar(object sender, EventArgs e)//FAZER AS MODIFICACOES
        {
            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            string query = string.Format("Select CPF from CLIENTE where UPPER(CPF) = '{0}'", txtCPF.Text.ToUpper());
            FbCommand fbCmd = new FbCommand(query, fbConn);
            string queryInsert;
            if (ehUpdate)
            {
                queryInsert = string.Format("UPDATE CLIENTE  SET NOME = '{0}', ENDERECO = '{1}', CIDADE = '{2}', UF = '{3}', FONE = '{4}', FONE2 = '{5}', OBS = '{6}', EMAIL  = '{7}', IDENTIDADE  = '{8}', BAIRRO = '{9}' WHERE (CPF = '{10}')",
                    txtNome.Text,  txtEndereco.Text, txtCidade.Text, txtUF.Text, txtTelefone1.Text, txtTelefone2.Text, txtObs.Text, txtEmail.Text, txtIdentidade.Text, txtBairro.Text, txtCPF.Text);


                //queryInsert = string.Format("UPDATE ESTOQUE SET ID_FORNECEDOR = {0}, TITULO = '{1}', LOCAL = '{2}',  PRECO_VENDA = @PREC_VENDA, PRECO_CUSTO = @PREC_CUSTO, DESCONTO = @DESCONTO, QUANTIDADE = @QUANTIDADE, MINIMO = @MINIMO, OBS = '{3}' WHERE (PARTNUMBER = {4})",
                //cbFornecedor.SelectedValue, txtTitulo.Text, cbLocal.Text, txtObservacoes.Text, txtPartNumber.Text);
            }
            else
            {
                queryInsert = string.Format("INSERT INTO CLIENTE (NOME, CPF, ENDERECO, CIDADE, UF, FONE, FONE2, OBS, EMAIL, IDENTIDADE, BAIRRO ) VALUES ('{0}','{1}', '{2}','{3}','{4}','{5}','{6}', '{7}', '{8}', '{9}', '{10}' );",
                    txtNome.Text, txtCPF.Text, txtEndereco.Text, txtCidade.Text, txtUF.Text, txtTelefone1.Text, txtTelefone2.Text, txtObs.Text, txtEmail.Text, txtIdentidade.Text, txtBairro.Text);

            }
            FbCommand fbCmdInsert = new FbCommand();

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
                        MessageBox.Show("Cliente alterado com sucesso!");
                    else
                        MessageBox.Show("Cliente cadastrado com sucesso!");

                    if (veioDeOS)
                        Close();
                    else
                        btnLimpar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Cliente já existente!\nPara ver os clientes já cadastrados acesse:\nCliente->Pesquisar");
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
                if (MessageBox.Show("Você tem certeza que deseja alterar os dados deste cliente?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SalvarAlterar(sender, e);
                    Close();
                }
            }
            else
                SalvarAlterar(sender, e);
            
        }
    }
}

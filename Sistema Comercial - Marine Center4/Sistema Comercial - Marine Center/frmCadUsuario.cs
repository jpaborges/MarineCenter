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
    public partial class frmCadUsuario : Form
    {
        public bool ehUpdate = false;
        public int ID_Usuario;

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Funcoes.Limpar(panel1);
        }

        private void frmCadUsuario_Resize(object sender, EventArgs e)
        {
            Funcoes.Centralizar(panel1, frmCadUsuario.ActiveForm.Width, frmCadUsuario.ActiveForm.Height);
        }

        private void preencherTextBox()
        {
            FbConnection fbConn = new FbConnection(Funcoes.strConn);
            string query = string.Format("Select * from USUARIOS where UPPER(USUARIO) = '{0}'", txtUsuario.Text);

            try
            {

                fbConn.Open();
                FbCommand fbCmd = new FbCommand(query, fbConn);
                FbDataReader r = fbCmd.ExecuteReader();

                if (r.Read())
                {
                    txtUsuario.Text = r["USUARIO"].ToString();
                    txtEndereco.Text = r["ENDERECO"].ToString();
                    txtNome.Text = r["NOME"].ToString();
                    txtSenha.Text = r["SENHA"].ToString();
                    txtTelefone1.Text = r["FONE1"].ToString();
                    txtTelefone2.Text = r["FONE2"].ToString();

                    if (Convert.ToInt32(r["PERMISAO"].ToString()) == 1)
                        rbAdmin.Checked = true;
                    else
                        rbVendedor.Checked = true;

      
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


        private void frmCadUsuario_Shown(object sender, EventArgs e)
        {
            Funcoes.Centralizar(panel1, frmCadUsuario.ActiveForm.Width, frmCadUsuario.ActiveForm.Height);
            txtUsuario.Enabled = !ehUpdate;
            if (ehUpdate)
                preencherTextBox();
        }

      
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Funcoes.camposObrigatorios(panel1))
            {
                int permisao;
                if (rbAdmin.Checked)
                    permisao = 1;
                else
                    permisao = 0;

                FbConnection fbConn = new FbConnection(Funcoes.strConn);
                string queryInsert;

                if (ehUpdate)
                {
                    queryInsert = string.Format("UPDATE USUARIOS SET NOME = '{0}', SENHA  = '{2}', PERMISAO  = '{3}', ENDERECO  = '{4}', FONE1  = '{5}', FONE2 = '{6}' WHERE UPPER(USUARIO) = '{1}'",
                                       txtNome.Text, txtUsuario.Text.ToUpper(), txtSenha.Text, permisao, txtEndereco.Text, txtTelefone1.Text, txtTelefone2.Text);

                }
                else
                {
                     queryInsert = string.Format("INSERT INTO USUARIOS (NOME, USUARIO, SENHA, PERMISAO, ENDERECO, FONE1, FONE2) VALUES ('{0}','{1}', '{2}',{3},'{4}','{5}','{6}');",
                        txtNome.Text, txtUsuario.Text.ToUpper(), txtSenha.Text, permisao, txtEndereco.Text, txtTelefone1.Text, txtTelefone2.Text);
                }

                string query = string.Format("Select USUARIO from USUARIOS where USUARIO = '{0}'", txtUsuario.Text.ToUpper());
                FbCommand fbCmd = new FbCommand(query, fbConn);
                FbCommand fbCmdInsert = new FbCommand(queryInsert,fbConn);

                try
                {
                    fbConn.Open();

                    if (!ehUpdate)
                    {
                        FbDataReader r = fbCmd.ExecuteReader();

                        if (!r.Read())
                        {
                            fbCmdInsert.ExecuteNonQuery();
                            MessageBox.Show("Usuario cadastrado com sucesso!");
                            btnLimpar_Click(sender, e);

                        }
                        else
                        {
                            MessageBox.Show("Usuario ja existente!\nPara ver os usuarios ja cadastrados acesse:\nUsuarios->Busca->Por Nome");
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Você tem certeza que deseja alterar o usuario?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            fbCmdInsert.ExecuteNonQuery();
                            MessageBox.Show("Usuario alterado com sucesso!");
                            Close();
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
                }
            }
        }
    }
}

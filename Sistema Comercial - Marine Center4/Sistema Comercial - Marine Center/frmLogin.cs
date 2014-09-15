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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Return)
                btnConectar_Click(sender, e);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "" || txtUsuario.Text == "")
                MessageBox.Show("As informacoes devem ser preenchidas");
            else

            {

                if (!Funcoes.Logar(txtUsuario.Text, txtSenha.Text))
                    MessageBox.Show("Usuario e ou senha Invalida");
                else
                 Close();
            }
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            Funcoes.Centralizar(pnlLogin, Size.Width, FrmLogin.ActiveForm.Size.Height);
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            
            Funcoes.Centralizar(pnlLogin, Size.Width, Size.Height);
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Funcoes.Usuario == Funcoes.TUsuarios.Nao_Logado)
                Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            

        }

        private void FrmLogin_Activated(object sender, EventArgs e)
        {
          //  MessageBox.Show(Funcoes.strConn);
            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            try
            {
                fbConn.Open();
                lblStatus.Text = "Conectado!";
            }
            catch (FbException fb)
            {

                lblStatus.Text = "Não foi possivel conectar ao banco de dados! Ligue para o suporte - " + fb.Message; 
            }
            finally
            {
                fbConn.Close();

            }
        }

        
    }
}

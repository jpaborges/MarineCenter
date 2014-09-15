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
    public partial class frmUsuarioNome : Form
    {
        public frmUsuarioNome()
        {
            InitializeComponent();
        }

        private void frmUsuarioNome_Shown(object sender, EventArgs e)
        {
            Funcoes.Centralizar(panel1, frmUsuarioNome.ActiveForm.Width, frmUsuarioNome.ActiveForm.Height);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                btnPesquisar_Click(sender, e);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar(txtNome.Text);
            
        }

        private void frmUsuarioNome_Activated(object sender, EventArgs e)
        {
            Pesquisar("");
            btRemover.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
            btAlterar.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
        }

        private void Pesquisar(string texto)
        {
            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            FbCommand fbCmd = new FbCommand("Select NOME, USUARIO, FONE1, FONE2, ENDERECO from USUARIOS where UPPER(NOME) like '%" + texto.Trim().ToUpper() + "%'", fbConn);

            try
            {
                fbConn.Open();

                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);

                dgvUsuarios.DataSource = dtUsuarios;
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o FireBird " + fbex.Message, "Erro");
            }
            finally
            {
                fbConn.Close();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            frmCadUsuario frm = new frmCadUsuario();
            frm.ehUpdate = true;

            frm.txtUsuario.Text = dgvUsuarios.SelectedRows[0].Cells["USUARIO"].Value.ToString();
            frm.ShowDialog();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            string usuario = dgvUsuarios.SelectedRows[0].Cells["USUARIO"].Value.ToString().ToUpper();
            string squery = string.Format("DELETE FROM USUARIOS WHERE UPPER(USUARIO) = '{0}'",
                  usuario);
            if (usuario != Funcoes.Login_usuario)
            {
                if (MessageBox.Show("Você tem certeza que deseja remover este item da lista?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    FbConnection fbConn = new FbConnection(Funcoes.strConn);

                    FbCommand fbCmd = new FbCommand(squery, fbConn);

                    try
                    {
                        fbConn.Open();
                        fbCmd.ExecuteNonQuery();
                    }
                    catch (FbException fbex)
                    {
                        MessageBox.Show("Erro ao acessar o FireBird " + fbex.Message, "Erro");
                    }
                    finally
                    {
                        fbConn.Close();
                    }
                    Pesquisar("");
                }
            }
            else
                MessageBox.Show("Não é possível apagar o usuário que está logado atualmente");
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            btRemover.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
            btAlterar.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
        }
    }
}

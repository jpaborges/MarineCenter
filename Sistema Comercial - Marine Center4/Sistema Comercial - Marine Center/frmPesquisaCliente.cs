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
    public partial class frmPesquisaCliente : Form
    {
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar(txtNome.Text);
        }

        private void Pesquisar(string texto)
        {
            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            FbCommand fbCmd = new FbCommand("Select * from CLIENTE where ID != 0 AND UPPER(NOME) like '%" + texto.Trim().ToUpper() + "%'", fbConn);

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

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                btnPesquisar_Click(sender, e);
        }

        private void frmPesquisaCliente_Shown(object sender, EventArgs e)
        {
            Funcoes.Centralizar(panel1, Width, Height);
        }

        private void frmPesquisaCliente_Activated(object sender, EventArgs e)
        {
            Pesquisar("");
            btRemover.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
            btAlterar.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            btRemover.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
            btAlterar.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            CadCliente frm = new CadCliente();
            frm.ehUpdate = true;

            frm.txtCPF.Text = dgvUsuarios.SelectedRows[0].Cells["CPF"].Value.ToString();
            frm.txtCPF.Enabled = false;
            frm.ShowDialog();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            string squery = string.Format("DELETE FROM CLIENTE WHERE CPF = '{0}'",
                    dgvUsuarios.SelectedRows[0].Cells["CPF"].Value.ToString());
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
    }
}

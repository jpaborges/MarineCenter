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
    public partial class frmPesquisarOS : Form
    {
        public frmPesquisarOS()
        {
            InitializeComponent();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex == 0)
                lblPesquisa.Text = "Nome do Cliente:";
            else if (cbCategoria.SelectedIndex == 1)
                lblPesquisa.Text = "Mecánico Responsável:";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar(txtNome.Text, cbCategoria.SelectedIndex);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                btnPesquisar_Click(sender, e);
        }
        //Alterar
        private void pesquisar(string texto, int categoria)
        {
            string squery;

            squery = "SELECT * FROM OS WHERE ";

            if (categoria == 0)
                squery += "UPPER(NOME) like '%" + texto.Trim().ToUpper() + "%'";
            else
                squery += "UPPER(MEC_RESPONSAVEL) like '%" + texto.Trim().ToUpper() + "%'";
          

            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                fbConn.Open();


                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);

                dgvUsuarios.DataSource = dtUsuarios;
                dgvUsuarios.Columns["VALOR_OS"].DefaultCellStyle.Format = "c";
                dgvUsuarios.Columns["DESCONTO"].DefaultCellStyle.Format = "c";
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

        private void frmPesquisarOS_Shown(object sender, EventArgs e)
        {
            Funcoes.Centralizar(panel1, frmUsuarioNome.ActiveForm.Width, frmUsuarioNome.ActiveForm.Height);
            cbCategoria.SelectedIndex = 0;
           
        }

        private void frmPesquisarOS_Activated(object sender, EventArgs e)
        {
            pesquisar("", 0);
            btImprimir.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
     
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            btImprimir.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            frmRelatorioOS frm = new frmRelatorioOS();
            frm.CarregarDados(dgvUsuarios.SelectedRows[0].Cells["NUMERO_OS"].Value.ToString());
            frm.ShowDialog();

        }




    }
}

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
    public partial class frmPesquisaEntrada : Form
    {
        public frmPesquisaEntrada()
        {
            InitializeComponent();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex == 0)
                lblPesquisa.Text = "Titulo produto:";
            else if (cbCategoria.SelectedIndex == 1)
                lblPesquisa.Text = "PartNumber:";
            else if (cbCategoria.SelectedIndex == 2)
                lblPesquisa.Text = "Número do Pedido:";
            else
                lblPesquisa.Text = "Data:";

            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar(txtNome.Text, cbCategoria.SelectedIndex);
        }

        private void pesquisar(string texto, int categoria)
        {

            string squery = "SELECT * FROM ENTRADA WHERE ";

            if (categoria == 0)
                squery += "UPPER(TITULO) like '%" + texto.Trim().ToUpper() + "%'";
            else if (categoria == 1)
                squery += "UPPER(PARTNUMBER) like '%" + texto.Trim().ToUpper() + "%'";
            else if (categoria == 2)
                squery += "UPPER(PEDIDO) like '%" + texto.Trim().ToUpper() + "%'";
            else
                squery += "DATA = @DATA";

            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            FbCommand fbCmd = new FbCommand();

            try
            {
                fbConn.Open();
                fbCmd.Connection = fbConn;
                fbCmd.CommandType = CommandType.Text;
                fbCmd.CommandText = squery;

                if (categoria == 3)
                {
                    try
                    {
                        fbCmd.Parameters.Add("@DATA", FbDbType.Date).Value = Convert.ToDateTime(texto);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Data digitada não é válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Clear();
                        pesquisar("", 0);
                    }
                    
                }
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

        private void frmPesquisaEntrada_Activated(object sender, EventArgs e)
        {
            pesquisar("", 0);
        }

        private void frmPesquisaEntrada_Load(object sender, EventArgs e)
        {
            cbCategoria.SelectedIndex = 0;
        }

    }
}

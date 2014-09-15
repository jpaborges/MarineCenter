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
    public partial class frmHistoricoBaixa : Form
    {
        public frmHistoricoBaixa()
        {
            InitializeComponent();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex == 0)
                lblPesquisa.Text = "Titulo produto:";
            else if (cbCategoria.SelectedIndex == 1)
                lblPesquisa.Text = "PartNumber:";
            else
                lblPesquisa.Text = "Nome do cliente:";

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                btnPesquisar_Click(sender, e);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar(txtNome.Text, cbCategoria.SelectedIndex);
        }

        private void pesquisar(string texto, int categoria)
        {
           /* string squery = "select estoque.titulo, estoque.partnumber, saida_estoque.motivo,saida_estoque.quantidade, cliente.nome, cliente.fone " +
            "from estoque,saida_estoque, cliente " +
            "where (estoque.id = saida_estoque.id_produto) and (cliente.id = saida_estoque.id_cliente) and ";

           */

            string squery = "SELECT * FROM SAIDA WHERE ";

            if (categoria == 0)
                squery += "UPPER(TITULO) like '%" + texto.Trim().ToUpper() + "%'";
            else if (categoria == 1)
                squery += "UPPER(PARTNUMBER) like '%" + texto.Trim().ToUpper() + "%'";
            else
                squery += "UPPER(NOME) like '%" + texto.Trim().ToUpper() + "%'";

            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

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

        private void frmHistoricoBaixa_Activated(object sender, EventArgs e)
        {
            pesquisar("", 0);
        }
    }
}

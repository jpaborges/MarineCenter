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
    public partial class frmPesquisaEstoque : Form
    {
        public frmPesquisaEstoque()
        {
            InitializeComponent();
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
            string squery;

            if (Funcoes.Usuario == Funcoes.TUsuarios.Administrador)
                squery = "SELECT  ESTOQUE.ID,  ESTOQUE.PARTNUMBER,  ESTOQUE.TITULO,  FORNECEDOR.NOME, ESTOQUE.PRECO_VENDA, ESTOQUE.PRECO_CUSTO, ESTOQUE.DESCONTO, ESTOQUE.QUANTIDADE, ESTOQUE.MINIMO, ESTOQUE.OBS " +
                    "FROM ESTOQUE, FORNECEDOR " +
                    "WHERE FORNECEDOR.ID = ESTOQUE.ID_FORNECEDOR AND ";
            else
                squery = "SELECT  ESTOQUE.ID,  ESTOQUE.PARTNUMBER,  ESTOQUE.TITULO,  FORNECEDOR.NOME, ESTOQUE.PRECO_VENDA, ESTOQUE.DESCONTO, ESTOQUE.QUANTIDADE, ESTOQUE.OBS " +
                                    "FROM ESTOQUE, FORNECEDOR " +
                                    "WHERE FORNECEDOR.ID = ESTOQUE.ID_FORNECEDOR AND ";

            if (categoria == 1)
                squery += "UPPER(ESTOQUE.TITULO) like '%" + texto.Trim().ToUpper() + "%'";
            else if (categoria == 0)
                squery += "UPPER(ESTOQUE.PARTNUMBER) like '%" + texto.Trim().ToUpper() + "%'";
            else
                squery += "UPPER(FORNECEDOR.NOME) like '%" + texto.Trim().ToUpper() + "%'";


            FbConnection fbConn = new FbConnection(Funcoes.strConn);
            
            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                fbConn.Open();
                

                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);

                dgvUsuarios.DataSource = dtUsuarios;
                dgvUsuarios.Columns["PRECO_VENDA"].DefaultCellStyle.Format = "c";
                dgvUsuarios.Columns["PRECO_CUSTO"].DefaultCellStyle.Format = "c";
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

        private void frmPesquisaEstoque_Shown(object sender, EventArgs e)
        {
            Funcoes.Centralizar(panel1, frmUsuarioNome.ActiveForm.Width, frmUsuarioNome.ActiveForm.Height);
            cbCategoria.SelectedIndex = 0;
            if (Funcoes.Usuario != Funcoes.TUsuarios.Administrador)
            {
                btImprimir.Visible = false;
                btAlterar.Visible = false;
                btRemover.Visible = false;
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex == 1)
                lblPesquisa.Text = "Nome:";
            else if (cbCategoria.SelectedIndex == 0)
                lblPesquisa.Text = "PartNumber:";
            else
                lblPesquisa.Text = "Fornecedor:";

        }

        private void frmPesquisaEstoque_Activated(object sender, EventArgs e)
        {
            pesquisar("", 0);
            btRemover.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
            btAlterar.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            frmImprimir frm = new frmImprimir();


            string squery;
            int categoria = cbCategoria.SelectedIndex;
            string texto = txtNome.Text;

                squery = "SELECT  ESTOQUE.ID,  ESTOQUE.PARTNUMBER,  ESTOQUE.TITULO,  FORNECEDOR.NOME, ESTOQUE.PRECO_VENDA, ESTOQUE.PRECO_CUSTO, ESTOQUE.QUANTIDADE " +
                    "FROM ESTOQUE, FORNECEDOR " +
                    "WHERE FORNECEDOR.ID = ESTOQUE.ID_FORNECEDOR AND ";
           
            if (categoria == 1)
                squery += "UPPER(ESTOQUE.TITULO) like '%" + texto.Trim().ToUpper() + "%'";
            else if (categoria == 0)
                squery += "UPPER(ESTOQUE.PARTNUMBER) like '%" + texto.Trim().ToUpper() + "%'";
            else
                squery += "UPPER(FORNECEDOR.NOME) like '%" + texto.Trim().ToUpper() + "%'";

            frm.squery = squery;
            frm.ShowDialog();
        } 

        private void btAlterar_Click(object sender, EventArgs e)
        {
            CadProduto frm = new CadProduto();
            frm.ehUpdate = true;
            
            frm.txtPartNumber.Text = dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString();
            frm.ShowDialog();
          
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            string squery = string.Format("DELETE FROM ESTOQUE WHERE PARTNUMBER = '{0}'",
                    dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString());
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
                pesquisar("", 0);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            btRemover.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
            btAlterar.Enabled = (dgvUsuarios.SelectedRows.Count == 1);
        }




    }
}

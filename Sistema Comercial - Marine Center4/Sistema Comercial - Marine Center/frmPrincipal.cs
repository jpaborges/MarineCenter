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
    public partial class frmPrincipal : Form
    {
   

        public void Atualizar_usuario()
        {
            if (Funcoes.Usuario != Funcoes.TUsuarios.Nao_Logado)
            {
                lblStatus.Text = "Bem vindo, " + Funcoes.Nome_usuario;
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    item.Visible = true;
                    item.Enabled = true;
                }

                bool enab = (Funcoes.Usuario == Funcoes.TUsuarios.Vendedor);
                
                    cadastroToolStripMenuItem.Enabled = !enab;
                    buscaToolStripMenuItem.Enabled = !enab;
                    porNomeToolStripMenuItem.Enabled = !enab;
                    cadastroDeItemToolStripMenuItem.Enabled = !enab;
                    relatorioToolStripMenuItem.Enabled = !enab;
                    darBaixaToolStripMenuItem.Enabled = !enab;
                    entradaToolStripMenuItem.Enabled = !enab;
                    zerarOSToolStripMenuItem.Enabled = !enab;
                        

                
            }

            
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void porClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerarOrdemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdemServico frm = new frmOrdemServico();
            frm.ShowDialog();
        }



        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            
            Funcoes.Centralizar(pnlGrid, Size.Width, Size.Height);
            

            FrmLogin frm = new FrmLogin();
            menuStrip1.Visible = false;
            lblStatus.Visible = false;
            pnlGrid.Visible = false;
            frm.ShowDialog();

            menuStrip1.Visible = true;
            lblStatus.Visible = true;
            pnlGrid.Visible = true;
            lblStatus.Left = Width - lblStatus.Width - 10; 
            
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            Funcoes.Centralizar(pnlGrid, Size.Width, Size.Height);
            lblStatus.Left = Width - lblStatus.Width - 10; 
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          
            frmCadUsuario frm = new frmCadUsuario();

            frm.ShowDialog();
        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
           
            frmUsuarioNome frm = new frmUsuarioNome();

            frm.ShowDialog();
        }

        private void trocarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Funcoes.Usuario = Funcoes.TUsuarios.Nao_Logado;
        }

        private void frmPrincipal_Enter(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            Atualizar_usuario();

            if (Funcoes.Usuario != Funcoes.TUsuarios.Nao_Logado)
            {
                string squery =
                    "SELECT  ID,  PARTNUMBER, TITULO, QUANTIDADE, MINIMO " +
                    "FROM ESTOQUE " +
                    "WHERE QUANTIDADE <= MINIMO";

                




                FbConnection fbConn = new FbConnection(Funcoes.strConn);

                FbCommand fbCmd = new FbCommand(squery, fbConn);

                try
                {
                    fbConn.Open();

                    FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                    DataTable dtUsuarios = new DataTable();
                    fbDa.Fill(dtUsuarios);

                    dataGridView1.DataSource = dtUsuarios;
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
        }

        private void cadastroDeForncedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFornecedor frm = new frmCadFornecedor();
            frm.ShowDialog();
        }

        private void cadastroDeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadProduto frm = new CadProduto();
            frm.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaEstoque frm = new frmPesquisaEstoque();
            frm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCliente frm = new CadCliente();
            frm.ShowDialog();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaCliente frm = new frmPesquisaCliente();
            frm.ShowDialog();
        }

       
        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmVerRelatorios frm = new frmVerRelatorios();
            frm.WindowState = FormWindowState.Maximized;

            string squery = "SELECT  ESTOQUE.ID, ESTOQUE.PARTNUMBER,  ESTOQUE.TITULO,  FORNECEDOR.NOME, ESTOQUE.PRECO_VENDA, ESTOQUE.PRECO_CUSTO, ESTOQUE.QUANTIDADE " +
                "FROM ESTOQUE, FORNECEDOR " +
                "WHERE FORNECEDOR.ID = ESTOQUE.ID_FORNECEDOR";

            frm.carregarRelatorio(squery, 1);
            frm.ShowDialog();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ordemDeServicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void darBaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaixa frm = new frmBaixa();
            frm.ShowDialog();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoricoBaixa frm = new frmHistoricoBaixa();
            frm.ShowDialog();
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPesquisarOS frm = new frmPesquisarOS();
            frm.ShowDialog();
        }

        private void darEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntrada frm = new frmEntrada();
            frm.ShowDialog();
        }

        private void pesquisarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPesquisaEntrada frm = new frmPesquisaEntrada();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void zerarOS()
        {
            string squery = "DELETE FROM SERVICO WHERE 1 = 1;";
            string squery2 = "SET GENERATOR gen_servicos TO 0;";

                FbConnection fbConn = new FbConnection(Funcoes.strConn);

                FbCommand fbCmd = new FbCommand(squery, fbConn);
                FbCommand fbCmd2 = new FbCommand(squery2, fbConn);

                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    fbConn.Open();
                    fbCmd.ExecuteNonQuery();
                    fbCmd2.ExecuteNonQuery();
                    MessageBox.Show("Ordem de servico zerada");
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o FireBird " + fbex.Message, "Erro");
                }
                finally
                {
                    fbConn.Close();
                    Cursor.Current = Cursors.Default;
                }
              
            
        }

        private void zerarOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja zerar as Ordens de Serviços?\nClicando em sim será apagado todas as ordens cadastradas e não poderá voltar atras.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                zerarOS();
            }
        }

       

        
    }
}

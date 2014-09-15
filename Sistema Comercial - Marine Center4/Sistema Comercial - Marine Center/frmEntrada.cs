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
    public partial class frmEntrada : Form
    {
        private  List<Produto> produtos = new List<Produto>();
        private List<Produto> produtosSelecionados = new List<Produto>();
        private Produto prod;

        private double total;

        public double Total
        {
            get { return total; }
            set {
                txtTotal.Text = string.Format("R${0}", value);
                total = value; }
        }

        public frmEntrada()
        {
            InitializeComponent();
        }

        private void CarregarProdutos()
        {
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            string queryPecas = "SELECT ID, TITULO, PRECO_CUSTO, PARTNUMBER, QUANTIDADE FROM ESTOQUE ORDER BY TITULO";
            FbCommand fbCmdPecas = new FbCommand(queryPecas, fbConn);

            try
            {
                fbConn.Open();

                //Pecas
                    FbDataReader rPecas = fbCmdPecas.ExecuteReader();

                    retorno.Clear();
                    Produto p;
                    while (rPecas.Read())
                    {
                        p = new Produto();
                        p.ID = Convert.ToInt32(rPecas[0].ToString());
                        p.Titulo = rPecas[1].ToString();
                        p.Preco_custo = Convert.ToDouble(rPecas[2].ToString());
                        p.PartNumber = rPecas[3].ToString();
                        p.QuantidaAnterior = Convert.ToInt32(rPecas[4].ToString());
                        produtos.Add(p);                    
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

        private void btAdicionarPecasServicos_Click(object sender, EventArgs e)
        {
            if (prod != null)
            {
                prod.Quantidade = Convert.ToInt32(txtQuantidadePeca.Text);
                produtosSelecionados.Add(prod);
                Total += prod.Quantidade * prod.Preco_custo;
                lbPecasServicos.Items.Add(string.Format("{0} | {1} | {2} | R${3} | Total R${4}", prod.PartNumber, prod.Titulo, prod.Quantidade, prod.Preco_custo, (prod.Quantidade * prod.Preco_custo)));
                txtQuantidadePeca.Clear();
                txtTitulo.Clear();
                txtPartNumber.Clear();
            }
        }

        private void txtPartNumber_Leave(object sender, EventArgs e)
        {
            var queryprod = (from q in produtos where q.PartNumber == txtPartNumber.Text select q);
            if (queryprod.Count() > 0)
            {
                Produto p = queryprod.First();

                if (p != null)
                {
                    txtTitulo.Text = p.Titulo;
                    prod = p;
                }
            }
            else
            {
                prod = null;
                txtTitulo.Clear();
                if (MessageBox.Show("PartNumber não encontrado, deseja cadastrar esse produto", "Informação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CadProduto frm = new CadProduto();
                    frm.veioDeOS = true;
                    frm.txtPartNumber.Text = txtPartNumber.Text;
                    frm.txtPartNumber.Enabled = false;
                    frm.ShowDialog();
                    frm.txtPartNumber.Enabled = true;
                    CarregarProdutos();
                    txtPartNumber_Leave(sender, e);
                    
                }
            }
        }

        private void frmEntrada_Activated(object sender, EventArgs e)
        {
            CarregarProdutos();
            
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (lbPecasServicos.SelectedItem != null)
            {
                if (MessageBox.Show("Você tem certeza que deseja eliminar essa peça da lista", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string s = lbPecasServicos.SelectedItem.ToString().Split('|')[0].Trim();
                    Produto q = (from p in produtosSelecionados where p.PartNumber.Trim() == s select p).First();

                    Total -= q.Quantidade * q.Preco_custo;
                    produtosSelecionados.Remove(q);
                    lbPecasServicos.Items.Remove(lbPecasServicos.SelectedItem);
                }
            }
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            Total = 0;
            txtData.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FbConnection fbConn = new FbConnection(Funcoes.strConn);
            string queryInsert;
            bool erro = false;
            queryInsert = string.Format("INSERT INTO ENTRADA_ESTOQUE (ID_PRODUTO, QUANTIDADE, DATA, NPEDIDO, QUANTIDADE_DB) VALUES (@ID_PRODUTO, @QUANTIDADE, @DATA, '{0}', @QUANTIDADE_DB)",
                            txtNPedido.Text);
          foreach (Produto p in produtosSelecionados)
          {
                 try
                 {
                        
             
                 FbCommand fbCmdInsert = new FbCommand();
                 //PARAMETROS
                 FbParameter[] prmParametro = new FbParameter[4];
                 prmParametro[0] = new FbParameter("@ID_PRODUTO", p.ID);
                 prmParametro[1] = new FbParameter("@QUANTIDADE", p.Quantidade);
                 prmParametro[2] = new FbParameter("@DATA",Convert.ToDateTime(txtData.Text) );
                
                 prmParametro[3] = new FbParameter("@QUANTIDADE_DB", (p.QuantidaAnterior + p.Quantidade));



                 foreach (FbParameter pr in prmParametro)
                 {
                     fbCmdInsert.Parameters.Add(pr);
                 }
                     fbConn.Open();

                     fbCmdInsert.Connection = fbConn;
                     fbCmdInsert.CommandType = CommandType.Text;
                     fbCmdInsert.CommandText = queryInsert;
                     fbCmdInsert.ExecuteNonQuery();
                 }

                 
                 catch (FbException fbex)
                 {
                     MessageBox.Show("Erro ao acessar o Banco de Dados: " + fbex.Message, "Erro");
                     erro = true;
                 }
                 finally
                 {
                     fbConn.Close();
                     p.QuantidaAnterior += p.Quantidade;
                 }
             }

          if (!erro)
          {
              MessageBox.Show("Entrada gerada com sucesso");
              txtNPedido.Clear();
              txtData.Text = DateTime.Today.ToString("dd/MM/yyyy");
              txtPartNumber.Clear();
              Total = 0;
              txtTitulo.Clear();
              produtosSelecionados.Clear();
              lbPecasServicos.Items.Clear();

          }

    
        }
    }
}

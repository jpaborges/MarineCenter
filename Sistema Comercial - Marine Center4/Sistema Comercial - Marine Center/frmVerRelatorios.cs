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
    public partial class frmVerRelatorios : Form
    {
    

        public frmVerRelatorios()
        {
            InitializeComponent();
        }

        public void carregarRelatorio(string squery, int parametro)
        {
            FbConnection fbConn = new FbConnection(Funcoes.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                fbConn.Open();

                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtUsuarios = new DataTable();
                fbDa.Fill(dtUsuarios);

                //Codigo para o relatorio

                MarineCenterDS ds = new MarineCenterDS();
                DataTable t = ds.Tables["Estoque"];
                DataRow r;
                foreach (DataRow item in dtUsuarios.Rows)
                {
                    r = t.NewRow();
                    r["PartNumber"] = item[1];
                    r["Titulo"] = item[2];
                    r["Fornecedor"] = item[3];
                    r["Preco_Venda"] = item[4];
                    r["Preco_Custo"] = item[5];
                    r["Itens"] = item[6];
                    t.Rows.Add(r);

                }

               if (parametro == 0)
               {
                   RelatorioProdutos objRpt = new RelatorioProdutos();
                   objRpt.SetDataSource(ds.Tables["Estoque"]);
                  objRpt.Refresh();
                  crystalReportViewer1.ReportSource = objRpt;
                  crystalReportViewer1.Refresh();
               }
               else if (parametro == 1)
               {
                   RelatorioProdutos_Venda objRpt = new RelatorioProdutos_Venda();
                   objRpt.SetDataSource(ds.Tables["Estoque"]);
                   objRpt.Refresh();
                   crystalReportViewer1.ReportSource = objRpt;
                   crystalReportViewer1.Refresh();
               }
               else if (parametro == 2)
               {
                   RelatorioProdutos_Custo objRpt = new RelatorioProdutos_Custo();
                   objRpt.SetDataSource(ds.Tables["Estoque"]);
                   objRpt.Refresh();
                   crystalReportViewer1.ReportSource = objRpt;
                   crystalReportViewer1.Refresh();
               }
               else
               {
                   RelatorioProdutos_Venda_Custo objRpt = new RelatorioProdutos_Venda_Custo();
                   objRpt.SetDataSource(ds.Tables["Estoque"]);
                   objRpt.Refresh();
                   crystalReportViewer1.ReportSource = objRpt;
                   crystalReportViewer1.Refresh();
               }
       
                    
                
               
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
        private void frmVerRelatorios_Load(object sender, EventArgs e)
        {
            
        }

        private void frmVerRelatorios_Shown(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class frmRelatorioOS : Form
    {
        public frmRelatorioOS()
        {
            InitializeComponent();
        }

        public void CarregarDados(string NumeroOS)
        {
                    FbConnection fbConn = new 
            FbConnection(Funcoes.strConn);
            string queryServico = string.Format("SELECT * FROM SERVICO WHERE NUMERO_OS = '{0}'", NumeroOS);
            FbCommand fbCmdServico = new FbCommand(queryServico, 
fbConn);


            try
            {
                fbConn.Open();
                DataSet1 ds = new DataSet1();

                //Table Servico
                FbDataAdapter fbDa = new FbDataAdapter(fbCmdServico);
                fbDa.Fill(ds.Tables["SERVICO"]);

                //Table Cliente
                string queryCliente = string.Format("SELECT * FROM CLIENTE WHERE ID = {0}",
                ds.Tables["SERVICO"].Rows[0]["ID_CLIENTE"].ToString());
                FbCommand fbCmdCliente = new FbCommand(queryCliente, fbConn);
                FbDataAdapter fbDaCliente = new 
                FbDataAdapter(fbCmdCliente);
                fbDaCliente.Fill(ds.Tables["CLIENTE"]);

               
                //Table Produtos
                string queryPecas = string.Format("SELECT * FROM PECAS WHERE ID_SERVICOS = {0}",
                ds.Tables["SERVICO"].Rows[0]["ID"].ToString());
                FbCommand fbCmdPecas = new FbCommand(queryPecas, fbConn);
                FbDataAdapter fbDaPecas = new 
                FbDataAdapter(fbCmdPecas);
                fbDaPecas.Fill(ds.Tables["PECAS"]);

                //Codigo para o relatorio
                RelatorioOScomSubReport objRpt = new RelatorioOScomSubReport();
                objRpt.SetDataSource(ds.Tables["SERVICO"]);
                objRpt.Subreports[1].SetDataSource(ds.Tables["PECAS"]);
                objRpt.Subreports[0].SetDataSource(ds.Tables["CLIENTE"]);
                objRpt.Refresh();
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();

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
}

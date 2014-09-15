using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data;
using FirebirdSql.Data.FirebirdClient;

namespace Sistema_Comercial___Marine_Center
{
    public partial class frmCadFornecedor : Form
    {
       

        public string sEmpresa
        {
            get { return txtEmpresa.Text; }
            set { txtEmpresa.Text = value; }
        }
        CadProduto frmProd = null;
        public frmCadFornecedor()
        {
            InitializeComponent();
        }

        public frmCadFornecedor(CadProduto frm)
        {
            InitializeComponent();
            frmProd = frm;
           
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Funcoes.camposObrigatorios(panel1))
            {
                
                FbConnection fbConn = new FbConnection(Funcoes.strConn);

                string queryInsert = string.Format("INSERT INTO FORNECEDOR (NOME, CONTATO, CNPJ, SITE, ENDERECO, FONE1, FONE2) VALUES ('{0}','{1}', '{2}','{3}','{4}','{5}','{6}');",
                    txtEmpresa.Text, txtContato.Text, txtCNPJ.Text, txtSite.Text, txtEndereco.Text, txtTelefone1.Text, txtTelefone2.Text);
               
                string query = string.Format("Select NOME from FORNECEDOR where UPPER(NOME) = '{0}'", txtEmpresa.Text.ToUpper());
                FbCommand fbCmd = new FbCommand(query, fbConn);
                FbCommand fbCmdInsert = new FbCommand(queryInsert, fbConn);

                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();
                    if (!r.Read())
                    {
                        fbCmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Fornecedor cadastrado com sucesso!");
                        if (frmProd != null)
                            frmProd.strFornecedor = sEmpresa;

                        btnLimpar_Click(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Fornecedor ja existente!\nPara ver os fornecedores ja cadastrados acesse:\nEstoque->Pesquisar->Fornecedor");
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
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Funcoes.Limpar(panel1);
        }

        private void frmCadFornecedor_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void frmCadFornecedor_Shown(object sender, EventArgs e)
        {
            Funcoes.Centralizar(panel1, this.Width, Height);
        }
    }
}

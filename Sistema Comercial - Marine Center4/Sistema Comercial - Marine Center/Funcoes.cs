using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;

namespace Sistema_Comercial___Marine_Center
{
    static class Funcoes
    {
        public enum TUsuarios
        {
            Nao_Logado,
            Vendedor,
            Administrador
        }

        public static TUsuarios Usuario;
        public static string Nome_usuario;
        public static string Login_usuario;
        private static  string pathDB = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\MARINECENTER.FDB";
        public static string strConn = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString; //"DataSource=localhost; Database=" + pathDB + "; UserID=sysdba; password=masterkey";
        public static byte[] strToByte(string s)
        {
            
            byte[] b = new byte[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                b[i] = Convert.ToByte(s[i]);
            }

            return b;
        }
        public static bool camposObrigatorios(Panel pnl)
        {
            foreach (var item in pnl.Controls)
            {
                if (item is TextBox)
                    if ((item as TextBox).Text == "")
                    {
                        MessageBox.Show("Campo é obrigatorio!");
                        (item as TextBox).Focus();
                        return false;
                    }
            }
            return true;
        }


        public static bool Logar(string usuario, string senha)
        {
            
            FbConnection fbConn = new FbConnection(strConn);
            string query = string.Format("SELECT NOME, USUARIO, SENHA, PERMISAO FROM USUARIOS WHERE USUARIO = '{0}' AND SENHA = '{1}'", usuario.ToUpper(), senha); 

            FbCommand fbCmd = new FbCommand(query , fbConn);

            try
            {
                fbConn.Open();
                
                FbDataReader r = fbCmd.ExecuteReader();
                
                if (r.Read())
                {
                   

                    Nome_usuario = r[0].ToString();
                    Login_usuario = r[1].ToString();
                    if (r["PERMISAO"].ToString() == "1")
                    {

                        Usuario = TUsuarios.Administrador;
                    }
                    else
                        Usuario = TUsuarios.Vendedor;

                    return true;
                }
                else
                    Usuario = TUsuarios.Nao_Logado;
               
                    
                    
                
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados: " + fbex.Message, "Erro");
                Usuario = TUsuarios.Nao_Logado;
            }
            finally
            {
                fbConn.Close();
            }
            
            return false;
        }

        public static void Centralizar(Panel pnl, int Width, int Height)
        {
            pnl.Top = (Height - pnl.Height) / 2;
            pnl.Left = (Width - pnl.Width) / 2;
        }

        public static void Limpar(Panel pnl)
        {
            foreach (var item in pnl.Controls)
            {
                if (item is TextBox)
                {
                    if ((item as TextBox).Enabled)
                    (item as TextBox).Clear();
                }

                if (item is MaskedTextBox)
                    (item as MaskedTextBox).Clear();

            }

            
        }

    }
}

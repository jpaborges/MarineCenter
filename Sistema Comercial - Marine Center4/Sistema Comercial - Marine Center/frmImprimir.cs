using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Comercial___Marine_Center
{
    public partial class frmImprimir : Form
    {
        public frmImprimir()
        {
            InitializeComponent();
        }
        public string squery;

        private void btImprimir_Click(object sender, EventArgs e)
        {
            frmVerRelatorios frm = new frmVerRelatorios();
            if (cbCusto.Checked && cbVendas.Checked)
                frm.carregarRelatorio(squery, 3);
            else if (cbCusto.Checked && !cbVendas.Checked)
                frm.carregarRelatorio(squery, 2);
            else if (!cbCusto.Checked && cbVendas.Checked)
                frm.carregarRelatorio(squery, 1);
            else
                frm.carregarRelatorio(squery, 0);

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
    }
}

namespace Sistema_Comercial___Marine_Center
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeForncedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darBaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darBaixaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarOrdemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.zerarOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ordemDeServicosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.buscaToolStripMenuItem,
            this.trocarUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // buscaToolStripMenuItem
            // 
            this.buscaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNomeToolStripMenuItem});
            this.buscaToolStripMenuItem.Name = "buscaToolStripMenuItem";
            this.buscaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.buscaToolStripMenuItem.Text = "Pesquisar";
            this.buscaToolStripMenuItem.Click += new System.EventHandler(this.porNomeToolStripMenuItem_Click);
            // 
            // porNomeToolStripMenuItem
            // 
            this.porNomeToolStripMenuItem.Name = "porNomeToolStripMenuItem";
            this.porNomeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.porNomeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.porNomeToolStripMenuItem.Text = "Por Nome";
            this.porNomeToolStripMenuItem.Click += new System.EventHandler(this.porNomeToolStripMenuItem_Click);
            // 
            // trocarUsuarioToolStripMenuItem
            // 
            this.trocarUsuarioToolStripMenuItem.Name = "trocarUsuarioToolStripMenuItem";
            this.trocarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.trocarUsuarioToolStripMenuItem.Text = "Trocar Usuario";
            this.trocarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.trocarUsuarioToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeItemToolStripMenuItem,
            this.cadastroDeForncedorToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.darBaixaToolStripMenuItem,
            this.entradaToolStripMenuItem,
            this.relatorioToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // cadastroDeItemToolStripMenuItem
            // 
            this.cadastroDeItemToolStripMenuItem.Name = "cadastroDeItemToolStripMenuItem";
            this.cadastroDeItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.cadastroDeItemToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cadastroDeItemToolStripMenuItem.Text = "Cadastro de Item";
            this.cadastroDeItemToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeItemToolStripMenuItem_Click);
            // 
            // cadastroDeForncedorToolStripMenuItem
            // 
            this.cadastroDeForncedorToolStripMenuItem.Name = "cadastroDeForncedorToolStripMenuItem";
            this.cadastroDeForncedorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.cadastroDeForncedorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cadastroDeForncedorToolStripMenuItem.Text = "Cadastro de Fornecedor";
            this.cadastroDeForncedorToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeForncedorToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // darBaixaToolStripMenuItem
            // 
            this.darBaixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darBaixaToolStripMenuItem1,
            this.históricoToolStripMenuItem});
            this.darBaixaToolStripMenuItem.Name = "darBaixaToolStripMenuItem";
            this.darBaixaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.darBaixaToolStripMenuItem.Text = "Baixa";
            // 
            // darBaixaToolStripMenuItem1
            // 
            this.darBaixaToolStripMenuItem1.Name = "darBaixaToolStripMenuItem1";
            this.darBaixaToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.darBaixaToolStripMenuItem1.Text = "Dar Baixa";
            this.darBaixaToolStripMenuItem1.Click += new System.EventHandler(this.darBaixaToolStripMenuItem_Click);
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.históricoToolStripMenuItem.Text = "Histórico";
            this.históricoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click);
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darEntradaToolStripMenuItem,
            this.pesquisarToolStripMenuItem3});
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // darEntradaToolStripMenuItem
            // 
            this.darEntradaToolStripMenuItem.Name = "darEntradaToolStripMenuItem";
            this.darEntradaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.darEntradaToolStripMenuItem.Text = "Dar entrada";
            this.darEntradaToolStripMenuItem.Click += new System.EventHandler(this.darEntradaToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem3
            // 
            this.pesquisarToolStripMenuItem3.Name = "pesquisarToolStripMenuItem3";
            this.pesquisarToolStripMenuItem3.Size = new System.Drawing.Size(143, 22);
            this.pesquisarToolStripMenuItem3.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem3.Click += new System.EventHandler(this.pesquisarToolStripMenuItem3_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            this.relatorioToolStripMenuItem.Click += new System.EventHandler(this.relatorioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pesquisarToolStripMenuItem1});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem1
            // 
            this.pesquisarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pToolStripMenuItem});
            this.pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            this.pesquisarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pesquisarToolStripMenuItem1.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem1.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.pToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.pToolStripMenuItem.Text = "Por Nome";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // ordemDeServicosToolStripMenuItem
            // 
            this.ordemDeServicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarOrdemToolStripMenuItem,
            this.pesquisarToolStripMenuItem2,
            this.zerarOSToolStripMenuItem});
            this.ordemDeServicosToolStripMenuItem.Name = "ordemDeServicosToolStripMenuItem";
            this.ordemDeServicosToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.ordemDeServicosToolStripMenuItem.Text = "Ordem de Servicos";
            this.ordemDeServicosToolStripMenuItem.Click += new System.EventHandler(this.ordemDeServicosToolStripMenuItem_Click);
            // 
            // gerarOrdemToolStripMenuItem
            // 
            this.gerarOrdemToolStripMenuItem.Name = "gerarOrdemToolStripMenuItem";
            this.gerarOrdemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.gerarOrdemToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gerarOrdemToolStripMenuItem.Text = "Gerar Ordem";
            this.gerarOrdemToolStripMenuItem.Click += new System.EventHandler(this.gerarOrdemToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem2
            // 
            this.pesquisarToolStripMenuItem2.Name = "pesquisarToolStripMenuItem2";
            this.pesquisarToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.pesquisarToolStripMenuItem2.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem2.Click += new System.EventHandler(this.pesquisarToolStripMenuItem2_Click);
            // 
            // zerarOSToolStripMenuItem
            // 
            this.zerarOSToolStripMenuItem.Name = "zerarOSToolStripMenuItem";
            this.zerarOSToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zerarOSToolStripMenuItem.Text = "Zerar OS";
            this.zerarOSToolStripMenuItem.Visible = false;
            this.zerarOSToolStripMenuItem.Click += new System.EventHandler(this.zerarOSToolStripMenuItem_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.label1);
            this.pnlGrid.Controls.Add(this.dataGridView1);
            this.pnlGrid.Location = new System.Drawing.Point(86, 28);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(631, 436);
            this.pnlGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produto em falta no estoque:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(631, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(748, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Bem vindo, ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 487);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Sistema Comercial Marine Center - Versao 2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Enter += new System.EventHandler(this.frmPrincipal_Enter);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarOrdemToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem trocarUsuarioToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeForncedorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darBaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darBaixaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem zerarOSToolStripMenuItem;

    }
}
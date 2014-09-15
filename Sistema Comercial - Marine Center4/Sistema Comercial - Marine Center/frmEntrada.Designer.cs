namespace Sistema_Comercial___Marine_Center
{
    partial class frmEntrada
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.txtQuantidadePeca = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.lbPecasServicos = new System.Windows.Forms.ListBox();
            this.btAdicionarPecasServicos = new System.Windows.Forms.Button();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtTitulo);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnSalvar);
            this.groupBox4.Controls.Add(this.txtPartNumber);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btRemover);
            this.groupBox4.Controls.Add(this.txtQuantidadePeca);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.lbPecasServicos);
            this.groupBox4.Controls.Add(this.btAdicionarPecasServicos);
            this.groupBox4.Location = new System.Drawing.Point(-1, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(758, 211);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Peças:";
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(675, 17);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 4;
            this.btRemover.Text = "&Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // txtQuantidadePeca
            // 
            this.txtQuantidadePeca.Location = new System.Drawing.Point(532, 19);
            this.txtQuantidadePeca.Name = "txtQuantidadePeca";
            this.txtQuantidadePeca.Size = new System.Drawing.Size(56, 20);
            this.txtQuantidadePeca.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(466, 22);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 13);
            this.label32.TabIndex = 9;
            this.label32.Text = "Quantidade:";
            // 
            // lbPecasServicos
            // 
            this.lbPecasServicos.AllowDrop = true;
            this.lbPecasServicos.FormattingEnabled = true;
            this.lbPecasServicos.Location = new System.Drawing.Point(9, 46);
            this.lbPecasServicos.Name = "lbPecasServicos";
            this.lbPecasServicos.Size = new System.Drawing.Size(743, 95);
            this.lbPecasServicos.TabIndex = 5;
            // 
            // btAdicionarPecasServicos
            // 
            this.btAdicionarPecasServicos.Location = new System.Drawing.Point(594, 17);
            this.btAdicionarPecasServicos.Name = "btAdicionarPecasServicos";
            this.btAdicionarPecasServicos.Size = new System.Drawing.Size(75, 23);
            this.btAdicionarPecasServicos.TabIndex = 3;
            this.btAdicionarPecasServicos.Text = "Adicionar";
            this.btAdicionarPecasServicos.UseVisualStyleBackColor = true;
            this.btAdicionarPecasServicos.Click += new System.EventHandler(this.btAdicionarPecasServicos_Click);
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(72, 19);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(106, 20);
            this.txtPartNumber.TabIndex = 0;
            this.txtPartNumber.Leave += new System.EventHandler(this.txtPartNumber_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PartNumber";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(294, 182);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(137, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNPedido
            // 
            this.txtNPedido.Location = new System.Drawing.Point(108, 17);
            this.txtNPedido.Name = "txtNPedido";
            this.txtNPedido.Size = new System.Drawing.Size(160, 20);
            this.txtNPedido.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Número do pedido:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(226, 19);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(234, 20);
            this.txtTitulo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Titulo:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(675, 147);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(75, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(317, 17);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 1;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 270);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.Name = "frmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Marine Center - Entrada de produtos";
            this.Load += new System.EventHandler(this.frmEntrada_Load);
            this.Activated += new System.EventHandler(this.frmEntrada_Activated);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.TextBox txtQuantidadePeca;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ListBox lbPecasServicos;
        private System.Windows.Forms.Button btAdicionarPecasServicos;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtData;
    }
}
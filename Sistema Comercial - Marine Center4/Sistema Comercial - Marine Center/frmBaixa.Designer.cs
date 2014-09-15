namespace Sistema_Comercial___Marine_Center
{
    partial class frmBaixa
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
            this.lblMotivo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOutros = new System.Windows.Forms.RadioButton();
            this.rbVendido = new System.Windows.Forms.RadioButton();
            this.btVerEstoque = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtQuantidadePeca = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.btDarBaixa = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTitulo);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtPartNumber);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lblMotivo);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btVerEstoque);
            this.groupBox4.Controls.Add(this.cbCliente);
            this.groupBox4.Controls.Add(this.lbCliente);
            this.groupBox4.Controls.Add(this.txtMotivo);
            this.groupBox4.Controls.Add(this.txtQuantidadePeca);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.btDarBaixa);
            this.groupBox4.Location = new System.Drawing.Point(4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 193);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Peças:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(242, 53);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 16;
            this.lblMotivo.Text = "Motivo:";
            this.lblMotivo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOutros);
            this.groupBox1.Controls.Add(this.rbVendido);
            this.groupBox1.Location = new System.Drawing.Point(9, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 43);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motivo";
            // 
            // rbOutros
            // 
            this.rbOutros.AutoSize = true;
            this.rbOutros.Location = new System.Drawing.Point(75, 16);
            this.rbOutros.Name = "rbOutros";
            this.rbOutros.Size = new System.Drawing.Size(56, 17);
            this.rbOutros.TabIndex = 1;
            this.rbOutros.TabStop = true;
            this.rbOutros.Text = "Outros";
            this.rbOutros.UseVisualStyleBackColor = true;
            this.rbOutros.CheckedChanged += new System.EventHandler(this.rbOutros_CheckedChanged);
            // 
            // rbVendido
            // 
            this.rbVendido.AutoSize = true;
            this.rbVendido.Location = new System.Drawing.Point(3, 16);
            this.rbVendido.Name = "rbVendido";
            this.rbVendido.Size = new System.Drawing.Size(56, 17);
            this.rbVendido.TabIndex = 0;
            this.rbVendido.TabStop = true;
            this.rbVendido.Text = "Venda";
            this.rbVendido.UseVisualStyleBackColor = true;
            this.rbVendido.CheckedChanged += new System.EventHandler(this.rbOutros_CheckedChanged);
            // 
            // btVerEstoque
            // 
            this.btVerEstoque.Location = new System.Drawing.Point(242, 138);
            this.btVerEstoque.Name = "btVerEstoque";
            this.btVerEstoque.Size = new System.Drawing.Size(75, 23);
            this.btVerEstoque.TabIndex = 6;
            this.btVerEstoque.Text = "Pesquisar estoque";
            this.btVerEstoque.UseVisualStyleBackColor = true;
            this.btVerEstoque.Click += new System.EventHandler(this.btVerEstoque_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(54, 110);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(413, 21);
            this.cbCliente.TabIndex = 4;
            this.cbCliente.Visible = false;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(6, 113);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(42, 13);
            this.lbCliente.TabIndex = 12;
            this.lbCliente.Text = "Cliente:";
            this.lbCliente.Visible = false;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(242, 69);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(225, 20);
            this.txtMotivo.TabIndex = 3;
            this.txtMotivo.Visible = false;
            // 
            // txtQuantidadePeca
            // 
            this.txtQuantidadePeca.Location = new System.Drawing.Point(477, 21);
            this.txtQuantidadePeca.Name = "txtQuantidadePeca";
            this.txtQuantidadePeca.Size = new System.Drawing.Size(56, 20);
            this.txtQuantidadePeca.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(411, 24);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 13);
            this.label32.TabIndex = 9;
            this.label32.Text = "Quantidade:";
            // 
            // btDarBaixa
            // 
            this.btDarBaixa.Location = new System.Drawing.Point(150, 138);
            this.btDarBaixa.Name = "btDarBaixa";
            this.btDarBaixa.Size = new System.Drawing.Size(75, 23);
            this.btDarBaixa.TabIndex = 5;
            this.btDarBaixa.Text = "Dar baixa";
            this.btDarBaixa.UseVisualStyleBackColor = true;
            this.btDarBaixa.Click += new System.EventHandler(this.btDarBaixa_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(213, 21);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(192, 20);
            this.txtTitulo.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Titulo:";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(69, 21);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(102, 20);
            this.txtPartNumber.TabIndex = 0;
            this.txtPartNumber.Leave += new System.EventHandler(this.txtPartNumber_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "PartNumber";
            // 
            // frmBaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 178);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.Name = "frmBaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marince Center - Baixa";
            this.Shown += new System.EventHandler(this.frmBaixa_Shown);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtQuantidadePeca;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btDarBaixa;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Button btVerEstoque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.RadioButton rbOutros;
        private System.Windows.Forms.RadioButton rbVendido;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Label label1;
    }
}
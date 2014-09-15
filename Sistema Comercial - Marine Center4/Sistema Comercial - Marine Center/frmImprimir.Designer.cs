namespace Sistema_Comercial___Marine_Center
{
    partial class frmImprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimir));
            this.label1 = new System.Windows.Forms.Label();
            this.cbCusto = new System.Windows.Forms.CheckBox();
            this.cbVendas = new System.Windows.Forms.CheckBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar:";
            // 
            // cbCusto
            // 
            this.cbCusto.AutoSize = true;
            this.cbCusto.Location = new System.Drawing.Point(12, 30);
            this.cbCusto.Name = "cbCusto";
            this.cbCusto.Size = new System.Drawing.Size(53, 17);
            this.cbCusto.TabIndex = 1;
            this.cbCusto.Text = "Custo";
            this.cbCusto.UseVisualStyleBackColor = true;
            // 
            // cbVendas
            // 
            this.cbVendas.AutoSize = true;
            this.cbVendas.Location = new System.Drawing.Point(12, 55);
            this.cbVendas.Name = "cbVendas";
            this.cbVendas.Size = new System.Drawing.Size(57, 17);
            this.cbVendas.TabIndex = 2;
            this.cbVendas.Text = "Venda";
            this.cbVendas.UseVisualStyleBackColor = true;
            // 
            // btImprimir
            // 
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImprimir.Location = new System.Drawing.Point(6, 89);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(98, 24);
            this.btImprimir.TabIndex = 6;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // frmImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(112, 117);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.cbVendas);
            this.Controls.Add(this.cbCusto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmImprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbCusto;
        private System.Windows.Forms.CheckBox cbVendas;
        private System.Windows.Forms.Button btImprimir;
    }
}
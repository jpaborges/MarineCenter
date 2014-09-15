namespace Sistema_Comercial___Marine_Center
{
    partial class frmOrdemServico
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
            this.cbPecasServicos = new System.Windows.Forms.ComboBox();
            this.txtHrKm = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtChassiServicos = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdicionarClienteServico = new System.Windows.Forms.Button();
            this.cbClientesServico = new System.Windows.Forms.ComboBox();
            this.txtDataEntradaServicos = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModeloServicos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroOSServicos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCategoriaOS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtDescricaoServico = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cxGarantia = new System.Windows.Forms.CheckBox();
            this.txtAnoServico = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorServicos = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMaoDeObra = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDescontoServicos = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtDeslocamento = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtValorOSServicos = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btSalvarServicos = new System.Windows.Forms.Button();
            this.btLimparServicos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtResposavelTecnico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtParecerTecnico = new System.Windows.Forms.RichTextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btRemover);
            this.groupBox4.Controls.Add(this.txtQuantidadePeca);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.lbPecasServicos);
            this.groupBox4.Controls.Add(this.btAdicionarPecasServicos);
            this.groupBox4.Controls.Add(this.cbPecasServicos);
            this.groupBox4.Location = new System.Drawing.Point(4, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(768, 151);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Peças:";
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(555, 17);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 4;
            this.btRemover.Text = "&Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // txtQuantidadePeca
            // 
            this.txtQuantidadePeca.Location = new System.Drawing.Point(412, 19);
            this.txtQuantidadePeca.Name = "txtQuantidadePeca";
            this.txtQuantidadePeca.Size = new System.Drawing.Size(56, 20);
            this.txtQuantidadePeca.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(346, 22);
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
            this.lbPecasServicos.Size = new System.Drawing.Size(739, 95);
            this.lbPecasServicos.TabIndex = 5;
            // 
            // btAdicionarPecasServicos
            // 
            this.btAdicionarPecasServicos.Location = new System.Drawing.Point(474, 17);
            this.btAdicionarPecasServicos.Name = "btAdicionarPecasServicos";
            this.btAdicionarPecasServicos.Size = new System.Drawing.Size(75, 23);
            this.btAdicionarPecasServicos.TabIndex = 3;
            this.btAdicionarPecasServicos.Text = "Adicionar";
            this.btAdicionarPecasServicos.UseVisualStyleBackColor = true;
            this.btAdicionarPecasServicos.Click += new System.EventHandler(this.btAdicionarPecasServicos_Click);
            // 
            // cbPecasServicos
            // 
            this.cbPecasServicos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbPecasServicos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPecasServicos.FormattingEnabled = true;
            this.cbPecasServicos.Location = new System.Drawing.Point(9, 19);
            this.cbPecasServicos.Name = "cbPecasServicos";
            this.cbPecasServicos.Size = new System.Drawing.Size(331, 21);
            this.cbPecasServicos.TabIndex = 1;
            // 
            // txtHrKm
            // 
            this.txtHrKm.Location = new System.Drawing.Point(514, 94);
            this.txtHrKm.Name = "txtHrKm";
            this.txtHrKm.Size = new System.Drawing.Size(135, 20);
            this.txtHrKm.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(453, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Hr/Km:";
            // 
            // txtChassiServicos
            // 
            this.txtChassiServicos.Location = new System.Drawing.Point(514, 68);
            this.txtChassiServicos.Name = "txtChassiServicos";
            this.txtChassiServicos.Size = new System.Drawing.Size(135, 20);
            this.txtChassiServicos.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(435, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Chassi/Serie:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Ano:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Modelo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAdicionarClienteServico);
            this.groupBox1.Controls.Add(this.cbClientesServico);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes:";
            // 
            // btAdicionarClienteServico
            // 
            this.btAdicionarClienteServico.Location = new System.Drawing.Point(437, 17);
            this.btAdicionarClienteServico.Name = "btAdicionarClienteServico";
            this.btAdicionarClienteServico.Size = new System.Drawing.Size(75, 23);
            this.btAdicionarClienteServico.TabIndex = 2;
            this.btAdicionarClienteServico.Text = "Adicionar";
            this.btAdicionarClienteServico.UseVisualStyleBackColor = true;
            this.btAdicionarClienteServico.Click += new System.EventHandler(this.btAdicionarClienteServico_Click);
            // 
            // cbClientesServico
            // 
            this.cbClientesServico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbClientesServico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClientesServico.FormattingEnabled = true;
            this.cbClientesServico.Location = new System.Drawing.Point(9, 19);
            this.cbClientesServico.Name = "cbClientesServico";
            this.cbClientesServico.Size = new System.Drawing.Size(422, 21);
            this.cbClientesServico.TabIndex = 1;
            // 
            // txtDataEntradaServicos
            // 
            this.txtDataEntradaServicos.Location = new System.Drawing.Point(528, 15);
            this.txtDataEntradaServicos.Mask = "00/00/0000";
            this.txtDataEntradaServicos.Name = "txtDataEntradaServicos";
            this.txtDataEntradaServicos.Size = new System.Drawing.Size(127, 20);
            this.txtDataEntradaServicos.TabIndex = 2;
            this.txtDataEntradaServicos.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Data de entrada:";
            // 
            // txtModeloServicos
            // 
            this.txtModeloServicos.Location = new System.Drawing.Point(212, 68);
            this.txtModeloServicos.Name = "txtModeloServicos";
            this.txtModeloServicos.Size = new System.Drawing.Size(211, 20);
            this.txtModeloServicos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da OS:";
            // 
            // txtNumeroOSServicos
            // 
            this.txtNumeroOSServicos.Enabled = false;
            this.txtNumeroOSServicos.Location = new System.Drawing.Point(212, 19);
            this.txtNumeroOSServicos.Name = "txtNumeroOSServicos";
            this.txtNumeroOSServicos.Size = new System.Drawing.Size(211, 20);
            this.txtNumeroOSServicos.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCategoriaOS);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rtDescricaoServico);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cxGarantia);
            this.groupBox2.Controls.Add(this.txtAnoServico);
            this.groupBox2.Controls.Add(this.txtHrKm);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtChassiServicos);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDataEntradaServicos);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtModeloServicos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNumeroOSServicos);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCorServicos);
            this.groupBox2.Location = new System.Drawing.Point(4, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 234);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordem de Serviço";
            // 
            // cbCategoriaOS
            // 
            this.cbCategoriaOS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCategoriaOS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoriaOS.FormattingEnabled = true;
            this.cbCategoriaOS.Items.AddRange(new object[] {
            "JET SKI",
            "ATV\'S",
            "MOTOR DE POPA",
            "ROADSTER"});
            this.cbCategoriaOS.Location = new System.Drawing.Point(212, 42);
            this.cbCategoriaOS.Name = "cbCategoriaOS";
            this.cbCategoriaOS.Size = new System.Drawing.Size(211, 21);
            this.cbCategoriaOS.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Categoria:";
            // 
            // rtDescricaoServico
            // 
            this.rtDescricaoServico.Location = new System.Drawing.Point(13, 132);
            this.rtDescricaoServico.Name = "rtDescricaoServico";
            this.rtDescricaoServico.Size = new System.Drawing.Size(735, 96);
            this.rtDescricaoServico.TabIndex = 10;
            this.rtDescricaoServico.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Descrição do Serviço";
            // 
            // cxGarantia
            // 
            this.cxGarantia.AutoSize = true;
            this.cxGarantia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cxGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxGarantia.Location = new System.Drawing.Point(432, 44);
            this.cxGarantia.Name = "cxGarantia";
            this.cxGarantia.Size = new System.Drawing.Size(106, 17);
            this.cxGarantia.TabIndex = 4;
            this.cxGarantia.Text = "Está na garantia:";
            this.cxGarantia.UseVisualStyleBackColor = true;
            // 
            // txtAnoServico
            // 
            this.txtAnoServico.Location = new System.Drawing.Point(401, 95);
            this.txtAnoServico.Mask = "0000";
            this.txtAnoServico.Name = "txtAnoServico";
            this.txtAnoServico.Size = new System.Drawing.Size(38, 20);
            this.txtAnoServico.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cor:";
            // 
            // txtCorServicos
            // 
            this.txtCorServicos.Location = new System.Drawing.Point(212, 93);
            this.txtCorServicos.Name = "txtCorServicos";
            this.txtCorServicos.Size = new System.Drawing.Size(137, 20);
            this.txtCorServicos.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(571, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Mão de Obra:";
            // 
            // txtMaoDeObra
            // 
            this.txtMaoDeObra.Location = new System.Drawing.Point(655, 42);
            this.txtMaoDeObra.Name = "txtMaoDeObra";
            this.txtMaoDeObra.Size = new System.Drawing.Size(107, 20);
            this.txtMaoDeObra.TabIndex = 2;
            this.txtMaoDeObra.Leave += new System.EventHandler(this.txtDeslocamento_Leave);
            this.txtMaoDeObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorFreteServicos_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(571, 72);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Desconto:";
            // 
            // txtDescontoServicos
            // 
            this.txtDescontoServicos.Location = new System.Drawing.Point(655, 68);
            this.txtDescontoServicos.Name = "txtDescontoServicos";
            this.txtDescontoServicos.Size = new System.Drawing.Size(107, 20);
            this.txtDescontoServicos.TabIndex = 3;
            this.txtDescontoServicos.Leave += new System.EventHandler(this.txtDeslocamento_Leave);
            this.txtDescontoServicos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorFreteServicos_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(571, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 13);
            this.label27.TabIndex = 12;
            this.label27.Text = "Deslocamento:";
            // 
            // txtDeslocamento
            // 
            this.txtDeslocamento.Location = new System.Drawing.Point(655, 13);
            this.txtDeslocamento.Name = "txtDeslocamento";
            this.txtDeslocamento.Size = new System.Drawing.Size(107, 20);
            this.txtDeslocamento.TabIndex = 1;
            this.txtDeslocamento.TextChanged += new System.EventHandler(this.txtValorFreteServicos_TextChanged);
            this.txtDeslocamento.Leave += new System.EventHandler(this.txtDeslocamento_Leave);
            this.txtDeslocamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorFreteServicos_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(571, 105);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 13);
            this.label28.TabIndex = 14;
            this.label28.Text = "Valor da OS:";
            // 
            // txtValorOSServicos
            // 
            this.txtValorOSServicos.Location = new System.Drawing.Point(655, 98);
            this.txtValorOSServicos.Name = "txtValorOSServicos";
            this.txtValorOSServicos.ReadOnly = true;
            this.txtValorOSServicos.Size = new System.Drawing.Size(107, 20);
            this.txtValorOSServicos.TabIndex = 4;
            this.txtValorOSServicos.Text = "0,00";
            this.txtValorOSServicos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorFreteServicos_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtValorOSServicos);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.txtDeslocamento);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.txtDescontoServicos);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtMaoDeObra);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Location = new System.Drawing.Point(4, 462);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(768, 133);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controles Totais:";
            // 
            // btSalvarServicos
            // 
            this.btSalvarServicos.Location = new System.Drawing.Point(251, 772);
            this.btSalvarServicos.Name = "btSalvarServicos";
            this.btSalvarServicos.Size = new System.Drawing.Size(75, 23);
            this.btSalvarServicos.TabIndex = 6;
            this.btSalvarServicos.Text = "Salvar";
            this.btSalvarServicos.UseVisualStyleBackColor = true;
            this.btSalvarServicos.Click += new System.EventHandler(this.btSalvarServicos_Click);
            // 
            // btLimparServicos
            // 
            this.btLimparServicos.Location = new System.Drawing.Point(373, 772);
            this.btLimparServicos.Name = "btLimparServicos";
            this.btLimparServicos.Size = new System.Drawing.Size(75, 23);
            this.btLimparServicos.TabIndex = 7;
            this.btLimparServicos.Text = "Limpar";
            this.btLimparServicos.UseVisualStyleBackColor = true;
            this.btLimparServicos.Click += new System.EventHandler(this.btLimparServicos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtResposavelTecnico);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.rtParecerTecnico);
            this.groupBox3.Location = new System.Drawing.Point(4, 601);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 165);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parecer Técnico";
            // 
            // txtResposavelTecnico
            // 
            this.txtResposavelTecnico.Location = new System.Drawing.Point(123, 125);
            this.txtResposavelTecnico.Name = "txtResposavelTecnico";
            this.txtResposavelTecnico.Size = new System.Drawing.Size(625, 20);
            this.txtResposavelTecnico.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Resposável Técnico:";
            // 
            // rtParecerTecnico
            // 
            this.rtParecerTecnico.Location = new System.Drawing.Point(9, 19);
            this.rtParecerTecnico.Name = "rtParecerTecnico";
            this.rtParecerTecnico.Size = new System.Drawing.Size(739, 96);
            this.rtParecerTecnico.TabIndex = 1;
            this.rtParecerTecnico.Text = "";
            // 
            // frmOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(840, 573);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btSalvarServicos);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btLimparServicos);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frmOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdemServico";
            this.Shown += new System.EventHandler(this.frmOrdemServico_Shown);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbPecasServicos;
        private System.Windows.Forms.Button btAdicionarPecasServicos;
        private System.Windows.Forms.ComboBox cbPecasServicos;
        private System.Windows.Forms.TextBox txtHrKm;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtChassiServicos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAdicionarClienteServico;
        private System.Windows.Forms.ComboBox cbClientesServico;
        private System.Windows.Forms.MaskedTextBox txtDataEntradaServicos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModeloServicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroOSServicos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorServicos;
        private System.Windows.Forms.MaskedTextBox txtAnoServico;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtQuantidadePeca;
        private System.Windows.Forms.CheckBox cxGarantia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtDescricaoServico;
        private System.Windows.Forms.ComboBox cbCategoriaOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtMaoDeObra;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtDescontoServicos;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtDeslocamento;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtValorOSServicos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btSalvarServicos;
        private System.Windows.Forms.Button btLimparServicos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtResposavelTecnico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtParecerTecnico;
        private System.Windows.Forms.Button btRemover;
    }
}
namespace prjAcademia
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbclienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_fitnessDataSet1 = new prjAcademia.db_fitnessDataSet1();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_fitnessDataSet = new prjAcademia.db_fitnessDataSet();
            this.tb_clienteTableAdapter = new prjAcademia.db_fitnessDataSetTableAdapters.tb_clienteTableAdapter();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtDatnasc = new System.Windows.Forms.MaskedTextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dbfitnessDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tb_clienteTableAdapter1 = new prjAcademia.db_fitnessDataSet1TableAdapters.tb_clienteTableAdapter();
            this.cmbDiaVenc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_fitnessDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_fitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfitnessDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(858, 236);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(367, 26);
            this.txtNome.TabIndex = 0;
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(858, 437);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(367, 96);
            this.txtObs.TabIndex = 7;
            // 
            // picFoto
            // 
            this.picFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picFoto.Location = new System.Drawing.Point(970, 31);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(138, 151);
            this.picFoto.TabIndex = 8;
            this.picFoto.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1002, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nova Foto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastro.Location = new System.Drawing.Point(1114, 595);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(111, 23);
            this.btnCadastro.TabIndex = 8;
            this.btnCadastro.Text = "Novo Cliente";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesativar.Enabled = false;
            this.btnDesativar.Location = new System.Drawing.Point(858, 595);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(75, 23);
            this.btnDesativar.TabIndex = 9;
            this.btnDesativar.Text = "Limpar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(855, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1043, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(855, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1043, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(855, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data Nasc.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1043, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Dia Vencimento:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(855, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Obs.:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txtBusca);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 631);
            this.panel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Palavra-Chave:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nomclienteDataGridViewTextBoxColumn,
            this.telclienteDataGridViewTextBoxColumn,
            this.celclienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbclienteBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(22, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(790, 457);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "Matrícula";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomclienteDataGridViewTextBoxColumn
            // 
            this.nomclienteDataGridViewTextBoxColumn.DataPropertyName = "nom_cliente";
            this.nomclienteDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomclienteDataGridViewTextBoxColumn.Name = "nomclienteDataGridViewTextBoxColumn";
            this.nomclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomclienteDataGridViewTextBoxColumn.Width = 450;
            // 
            // telclienteDataGridViewTextBoxColumn
            // 
            this.telclienteDataGridViewTextBoxColumn.DataPropertyName = "tel_cliente";
            this.telclienteDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telclienteDataGridViewTextBoxColumn.Name = "telclienteDataGridViewTextBoxColumn";
            this.telclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.telclienteDataGridViewTextBoxColumn.Width = 120;
            // 
            // celclienteDataGridViewTextBoxColumn
            // 
            this.celclienteDataGridViewTextBoxColumn.DataPropertyName = "cel_cliente";
            this.celclienteDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celclienteDataGridViewTextBoxColumn.Name = "celclienteDataGridViewTextBoxColumn";
            this.celclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.celclienteDataGridViewTextBoxColumn.Width = 120;
            // 
            // tbclienteBindingSource1
            // 
            this.tbclienteBindingSource1.DataMember = "tb_cliente";
            this.tbclienteBindingSource1.DataSource = this.db_fitnessDataSet1;
            this.tbclienteBindingSource1.CurrentChanged += new System.EventHandler(this.tbclienteBindingSource1_CurrentChanged);
            // 
            // db_fitnessDataSet1
            // 
            this.db_fitnessDataSet1.DataSetName = "db_fitnessDataSet1";
            this.db_fitnessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(737, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(22, 44);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(709, 26);
            this.txtBusca.TabIndex = 0;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            this.txtBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyUp);
            // 
            // tbclienteBindingSource
            // 
            this.tbclienteBindingSource.DataMember = "tb_cliente";
            this.tbclienteBindingSource.DataSource = this.db_fitnessDataSet;
            // 
            // db_fitnessDataSet
            // 
            this.db_fitnessDataSet.DataSetName = "db_fitnessDataSet";
            this.db_fitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(858, 286);
            this.txtRg.Mask = "99,999,999-##";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(179, 26);
            this.txtRg.TabIndex = 1;
            this.txtRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(1046, 286);
            this.txtCPF.Mask = "999,999,999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(179, 26);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(858, 334);
            this.txtTel.Mask = "(99) 0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(179, 26);
            this.txtTel.TabIndex = 3;
            this.txtTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.Location = new System.Drawing.Point(1046, 334);
            this.txtCel.Mask = "(99) 00000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(179, 26);
            this.txtCel.TabIndex = 4;
            this.txtCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtDatnasc
            // 
            this.txtDatnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatnasc.Location = new System.Drawing.Point(858, 383);
            this.txtDatnasc.Mask = "00/00/0000";
            this.txtDatnasc.Name = "txtDatnasc";
            this.txtDatnasc.Size = new System.Drawing.Size(179, 26);
            this.txtDatnasc.TabIndex = 5;
            this.txtDatnasc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtDatnasc.ValidatingType = typeof(System.DateTime);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(997, 595);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(111, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dbfitnessDataSetBindingSource
            // 
            this.dbfitnessDataSetBindingSource.DataSource = this.db_fitnessDataSet;
            this.dbfitnessDataSetBindingSource.Position = 0;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(858, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(367, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Modalidades";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_clienteTableAdapter1
            // 
            this.tb_clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbDiaVenc
            // 
            this.cmbDiaVenc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaVenc.FormattingEnabled = true;
            this.cmbDiaVenc.Items.AddRange(new object[] {
            "10",
            "20"});
            this.cmbDiaVenc.Location = new System.Drawing.Point(1046, 388);
            this.cmbDiaVenc.Name = "cmbDiaVenc";
            this.cmbDiaVenc.Size = new System.Drawing.Size(179, 21);
            this.cmbDiaVenc.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 628);
            this.Controls.Add(this.cmbDiaVenc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtDatnasc);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fire Fitness - Matrículas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_fitnessDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_fitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfitnessDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBusca;
        private db_fitnessDataSet db_fitnessDataSet;
        private System.Windows.Forms.BindingSource tbclienteBindingSource;
        private db_fitnessDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.MaskedTextBox txtDatnasc;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.BindingSource dbfitnessDataSetBindingSource;
        private db_fitnessDataSet1 db_fitnessDataSet1;
        private System.Windows.Forms.BindingSource tbclienteBindingSource1;
        private db_fitnessDataSet1TableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbDiaVenc;

    }
}


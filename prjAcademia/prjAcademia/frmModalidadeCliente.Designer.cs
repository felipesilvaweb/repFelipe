namespace prjAcademia
{
    partial class frmModalidadeCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbmodalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbfitnessDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_fitnessDataSet1 = new prjAcademia.db_fitnessDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.db_fitnessDataSet = new prjAcademia.db_fitnessDataSet();
            this.dbfitnessDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbfitnessDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_modalidadeTableAdapter = new prjAcademia.db_fitnessDataSet1TableAdapters.tb_modalidadeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmodalidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfitnessDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_fitnessDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_fitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfitnessDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfitnessDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 348);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tbmodalidadeBindingSource;
            this.comboBox1.DisplayMember = "nom_modalidade";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(424, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "id_modalidade";
            // 
            // tbmodalidadeBindingSource
            // 
            this.tbmodalidadeBindingSource.DataMember = "tb_modalidade";
            this.tbmodalidadeBindingSource.DataSource = this.dbfitnessDataSet1BindingSource1;
            // 
            // dbfitnessDataSet1BindingSource1
            // 
            this.dbfitnessDataSet1BindingSource1.DataSource = this.db_fitnessDataSet1;
            this.dbfitnessDataSet1BindingSource1.Position = 0;
            // 
            // db_fitnessDataSet1
            // 
            this.db_fitnessDataSet1.DataSetName = "db_fitnessDataSet1";
            this.db_fitnessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // db_fitnessDataSet
            // 
            this.db_fitnessDataSet.DataSetName = "db_fitnessDataSet";
            this.db_fitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbfitnessDataSetBindingSource
            // 
            this.dbfitnessDataSetBindingSource.DataSource = this.db_fitnessDataSet;
            this.dbfitnessDataSetBindingSource.Position = 0;
            // 
            // dbfitnessDataSet1BindingSource
            // 
            this.dbfitnessDataSet1BindingSource.DataSource = this.db_fitnessDataSet1;
            this.dbfitnessDataSet1BindingSource.Position = 0;
            // 
            // tb_modalidadeTableAdapter
            // 
            this.tb_modalidadeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modalidade:";
            // 
            // frmModalidadeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmModalidadeCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associação de Modalidades";
            this.Load += new System.EventHandler(this.frmModalidadeCliente_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmodalidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfitnessDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_fitnessDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_fitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfitnessDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfitnessDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private db_fitnessDataSet db_fitnessDataSet;
        private System.Windows.Forms.BindingSource dbfitnessDataSetBindingSource;
        private db_fitnessDataSet1 db_fitnessDataSet1;
        private System.Windows.Forms.BindingSource dbfitnessDataSet1BindingSource;
        private System.Windows.Forms.BindingSource dbfitnessDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource tbmodalidadeBindingSource;
        private db_fitnessDataSet1TableAdapters.tb_modalidadeTableAdapter tb_modalidadeTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
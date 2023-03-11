namespace Proje6_2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proje6DataSet = new Proje6_2.Proje6DataSet();
            this.pROHAREKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROHAREKETTableAdapter = new Proje6_2.Proje6DataSetTableAdapters.PROHAREKETTableAdapter();
            this.hAREKETNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRUNADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIADSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txturun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmusteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpersonel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROHAREKETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hAREKETNODataGridViewTextBoxColumn,
            this.uRUNADIDataGridViewTextBoxColumn,
            this.mUSTERIADSOYADDataGridViewTextBoxColumn,
            this.pERSONELDataGridViewTextBoxColumn,
            this.fIYATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROHAREKETBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // proje6DataSet
            // 
            this.proje6DataSet.DataSetName = "Proje6DataSet";
            this.proje6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROHAREKETBindingSource
            // 
            this.pROHAREKETBindingSource.DataMember = "PROHAREKET";
            this.pROHAREKETBindingSource.DataSource = this.proje6DataSet;
            // 
            // pROHAREKETTableAdapter
            // 
            this.pROHAREKETTableAdapter.ClearBeforeFill = true;
            // 
            // hAREKETNODataGridViewTextBoxColumn
            // 
            this.hAREKETNODataGridViewTextBoxColumn.DataPropertyName = "HAREKET NO";
            this.hAREKETNODataGridViewTextBoxColumn.HeaderText = "HAREKET NO";
            this.hAREKETNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hAREKETNODataGridViewTextBoxColumn.Name = "hAREKETNODataGridViewTextBoxColumn";
            this.hAREKETNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uRUNADIDataGridViewTextBoxColumn
            // 
            this.uRUNADIDataGridViewTextBoxColumn.DataPropertyName = "URUN ADI";
            this.uRUNADIDataGridViewTextBoxColumn.HeaderText = "URUN ADI";
            this.uRUNADIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uRUNADIDataGridViewTextBoxColumn.Name = "uRUNADIDataGridViewTextBoxColumn";
            // 
            // mUSTERIADSOYADDataGridViewTextBoxColumn
            // 
            this.mUSTERIADSOYADDataGridViewTextBoxColumn.DataPropertyName = "MUSTERI AD SOYAD";
            this.mUSTERIADSOYADDataGridViewTextBoxColumn.HeaderText = "MUSTERI AD SOYAD";
            this.mUSTERIADSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERIADSOYADDataGridViewTextBoxColumn.Name = "mUSTERIADSOYADDataGridViewTextBoxColumn";
            // 
            // pERSONELDataGridViewTextBoxColumn
            // 
            this.pERSONELDataGridViewTextBoxColumn.DataPropertyName = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.HeaderText = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONELDataGridViewTextBoxColumn.Name = "pERSONELDataGridViewTextBoxColumn";
            // 
            // fIYATDataGridViewTextBoxColumn
            // 
            this.fIYATDataGridViewTextBoxColumn.DataPropertyName = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.HeaderText = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIYATDataGridViewTextBoxColumn.Name = "fIYATDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Satis Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txturun
            // 
            this.txturun.Location = new System.Drawing.Point(341, 271);
            this.txturun.Name = "txturun";
            this.txturun.Size = new System.Drawing.Size(100, 22);
            this.txturun.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "URUN KOD";
            // 
            // txtmusteri
            // 
            this.txtmusteri.Location = new System.Drawing.Point(341, 312);
            this.txtmusteri.Name = "txtmusteri";
            this.txtmusteri.Size = new System.Drawing.Size(100, 22);
            this.txtmusteri.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "MUSTERI KOD";
            // 
            // txtpersonel
            // 
            this.txtpersonel.Location = new System.Drawing.Point(341, 358);
            this.txtpersonel.Name = "txtpersonel";
            this.txtpersonel.Size = new System.Drawing.Size(100, 22);
            this.txtpersonel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "PERSONEL KOD";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(341, 401);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 22);
            this.txtfiyat.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "FIYAT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpersonel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmusteri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txturun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROHAREKETBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Proje6DataSet proje6DataSet;
        private System.Windows.Forms.BindingSource pROHAREKETBindingSource;
        private Proje6DataSetTableAdapters.PROHAREKETTableAdapter pROHAREKETTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAREKETNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRUNADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIADSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txturun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label4;
    }
}


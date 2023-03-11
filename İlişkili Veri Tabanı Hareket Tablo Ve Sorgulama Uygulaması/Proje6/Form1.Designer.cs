namespace Proje6
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
            this.proje6DataSet = new Proje6.Proje6DataSet();
            this.pROHAREKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROHAREKETTableAdapter = new Proje6.Proje6DataSetTableAdapters.PROHAREKETTableAdapter();
            this.hAREKETIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aD1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.hAREKETIDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.aDSOYADDataGridViewTextBoxColumn,
            this.aD1DataGridViewTextBoxColumn,
            this.fIYATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROHAREKETBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 375);
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
            // hAREKETIDDataGridViewTextBoxColumn
            // 
            this.hAREKETIDDataGridViewTextBoxColumn.DataPropertyName = "HAREKETID";
            this.hAREKETIDDataGridViewTextBoxColumn.HeaderText = "HAREKETID";
            this.hAREKETIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hAREKETIDDataGridViewTextBoxColumn.Name = "hAREKETIDDataGridViewTextBoxColumn";
            this.hAREKETIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // aDSOYADDataGridViewTextBoxColumn
            // 
            this.aDSOYADDataGridViewTextBoxColumn.DataPropertyName = "ADSOYAD";
            this.aDSOYADDataGridViewTextBoxColumn.HeaderText = "ADSOYAD";
            this.aDSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDSOYADDataGridViewTextBoxColumn.Name = "aDSOYADDataGridViewTextBoxColumn";
            // 
            // aD1DataGridViewTextBoxColumn
            // 
            this.aD1DataGridViewTextBoxColumn.DataPropertyName = "AD1";
            this.aD1DataGridViewTextBoxColumn.HeaderText = "AD1";
            this.aD1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aD1DataGridViewTextBoxColumn.Name = "aD1DataGridViewTextBoxColumn";
            // 
            // fIYATDataGridViewTextBoxColumn
            // 
            this.fIYATDataGridViewTextBoxColumn.DataPropertyName = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.HeaderText = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIYATDataGridViewTextBoxColumn.Name = "fIYATDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 375);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROHAREKETBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Proje6DataSet proje6DataSet;
        private System.Windows.Forms.BindingSource pROHAREKETBindingSource;
        private Proje6DataSetTableAdapters.PROHAREKETTableAdapter pROHAREKETTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hAREKETIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aD1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIYATDataGridViewTextBoxColumn;
    }
}


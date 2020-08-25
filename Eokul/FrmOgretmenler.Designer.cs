namespace Eokul
{
    partial class FrmOgretmenler
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
            this.ogretmenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOgretmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okulSistemiDataSet = new Eokul.OkulSistemiDataSet();
            this.tbl_OgretmenTableAdapter = new Eokul.OkulSistemiDataSetTableAdapters.Tbl_OgretmenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgretmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulSistemiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogretmenidDataGridViewTextBoxColumn,
            this.ogretmenBransDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOgretmenBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // ogretmenidDataGridViewTextBoxColumn
            // 
            this.ogretmenidDataGridViewTextBoxColumn.DataPropertyName = "Ogretmenid";
            this.ogretmenidDataGridViewTextBoxColumn.HeaderText = "Ogretmenid";
            this.ogretmenidDataGridViewTextBoxColumn.Name = "ogretmenidDataGridViewTextBoxColumn";
            this.ogretmenidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogretmenBransDataGridViewTextBoxColumn
            // 
            this.ogretmenBransDataGridViewTextBoxColumn.DataPropertyName = "OgretmenBrans";
            this.ogretmenBransDataGridViewTextBoxColumn.HeaderText = "OgretmenBrans";
            this.ogretmenBransDataGridViewTextBoxColumn.Name = "ogretmenBransDataGridViewTextBoxColumn";
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            // 
            // tblOgretmenBindingSource
            // 
            this.tblOgretmenBindingSource.DataMember = "Tbl_Ogretmen";
            this.tblOgretmenBindingSource.DataSource = this.okulSistemiDataSet;
            // 
            // okulSistemiDataSet
            // 
            this.okulSistemiDataSet.DataSetName = "OkulSistemiDataSet";
            this.okulSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_OgretmenTableAdapter
            // 
            this.tbl_OgretmenTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgretmenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmOgretmenler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmenler";
            this.Load += new System.EventHandler(this.FrmOgretmenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgretmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulSistemiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OkulSistemiDataSet okulSistemiDataSet;
        private System.Windows.Forms.BindingSource tblOgretmenBindingSource;
        private OkulSistemiDataSetTableAdapters.Tbl_OgretmenTableAdapter tbl_OgretmenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretmenBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
    }
}
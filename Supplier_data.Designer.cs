
namespace WindowsFormsApp1
{
    partial class Supplier_data
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
            this.supplier_BillDataSet = new WindowsFormsApp1.Supplier_BillDataSet();
            this.sUPPLIERBILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUPPLIER_BILLTableAdapter = new WindowsFormsApp1.Supplier_BillDataSetTableAdapters.SUPPLIER_BILLTableAdapter();
            this.bILLNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPLIERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wEIGHTSIZEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFERQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILLDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_BillDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBILLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bILLNODataGridViewTextBoxColumn,
            this.sUPPLIERNAMEDataGridViewTextBoxColumn,
            this.sRDataGridViewTextBoxColumn,
            this.bRANDDataGridViewTextBoxColumn,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.sTOCKDataGridViewTextBoxColumn,
            this.wEIGHTDataGridViewTextBoxColumn,
            this.wEIGHTSIZEDataGridViewTextBoxColumn,
            this.dISCOUNTDataGridViewTextBoxColumn,
            this.cGSTDataGridViewTextBoxColumn,
            this.sGSTDataGridViewTextBoxColumn,
            this.iGSTDataGridViewTextBoxColumn,
            this.oFFERQUANTITYDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.tOTALAMOUNTDataGridViewTextBoxColumn,
            this.bILLDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sUPPLIERBILLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(996, 613);
            this.dataGridView1.TabIndex = 0;
            // 
            // supplier_BillDataSet
            // 
            this.supplier_BillDataSet.DataSetName = "Supplier_BillDataSet";
            this.supplier_BillDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUPPLIERBILLBindingSource
            // 
            this.sUPPLIERBILLBindingSource.DataMember = "SUPPLIER_BILL";
            this.sUPPLIERBILLBindingSource.DataSource = this.supplier_BillDataSet;
            // 
            // sUPPLIER_BILLTableAdapter
            // 
            this.sUPPLIER_BILLTableAdapter.ClearBeforeFill = true;
            // 
            // bILLNODataGridViewTextBoxColumn
            // 
            this.bILLNODataGridViewTextBoxColumn.DataPropertyName = "BILL_NO";
            this.bILLNODataGridViewTextBoxColumn.HeaderText = "BILL_NO";
            this.bILLNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bILLNODataGridViewTextBoxColumn.Name = "bILLNODataGridViewTextBoxColumn";
            this.bILLNODataGridViewTextBoxColumn.ReadOnly = true;
            this.bILLNODataGridViewTextBoxColumn.Width = 125;
            // 
            // sUPPLIERNAMEDataGridViewTextBoxColumn
            // 
            this.sUPPLIERNAMEDataGridViewTextBoxColumn.DataPropertyName = "SUPPLIER_NAME";
            this.sUPPLIERNAMEDataGridViewTextBoxColumn.HeaderText = "SUPPLIER_NAME";
            this.sUPPLIERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sUPPLIERNAMEDataGridViewTextBoxColumn.Name = "sUPPLIERNAMEDataGridViewTextBoxColumn";
            this.sUPPLIERNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUPPLIERNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sRDataGridViewTextBoxColumn
            // 
            this.sRDataGridViewTextBoxColumn.DataPropertyName = "SR";
            this.sRDataGridViewTextBoxColumn.HeaderText = "SR";
            this.sRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sRDataGridViewTextBoxColumn.Name = "sRDataGridViewTextBoxColumn";
            this.sRDataGridViewTextBoxColumn.ReadOnly = true;
            this.sRDataGridViewTextBoxColumn.Width = 125;
            // 
            // bRANDDataGridViewTextBoxColumn
            // 
            this.bRANDDataGridViewTextBoxColumn.DataPropertyName = "BRAND";
            this.bRANDDataGridViewTextBoxColumn.HeaderText = "BRAND";
            this.bRANDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bRANDDataGridViewTextBoxColumn.Name = "bRANDDataGridViewTextBoxColumn";
            this.bRANDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bRANDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTNAMEDataGridViewTextBoxColumn
            // 
            this.pRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Name = "pRODUCTNAMEDataGridViewTextBoxColumn";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTOCKDataGridViewTextBoxColumn
            // 
            this.sTOCKDataGridViewTextBoxColumn.DataPropertyName = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.HeaderText = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTOCKDataGridViewTextBoxColumn.Name = "sTOCKDataGridViewTextBoxColumn";
            this.sTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOCKDataGridViewTextBoxColumn.Width = 125;
            // 
            // wEIGHTDataGridViewTextBoxColumn
            // 
            this.wEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WEIGHT_";
            this.wEIGHTDataGridViewTextBoxColumn.HeaderText = "WEIGHT_";
            this.wEIGHTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wEIGHTDataGridViewTextBoxColumn.Name = "wEIGHTDataGridViewTextBoxColumn";
            this.wEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.wEIGHTDataGridViewTextBoxColumn.Width = 125;
            // 
            // wEIGHTSIZEDataGridViewTextBoxColumn
            // 
            this.wEIGHTSIZEDataGridViewTextBoxColumn.DataPropertyName = "WEIGHT_SIZE";
            this.wEIGHTSIZEDataGridViewTextBoxColumn.HeaderText = "WEIGHT_SIZE";
            this.wEIGHTSIZEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wEIGHTSIZEDataGridViewTextBoxColumn.Name = "wEIGHTSIZEDataGridViewTextBoxColumn";
            this.wEIGHTSIZEDataGridViewTextBoxColumn.ReadOnly = true;
            this.wEIGHTSIZEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dISCOUNTDataGridViewTextBoxColumn
            // 
            this.dISCOUNTDataGridViewTextBoxColumn.DataPropertyName = "DISCOUNT";
            this.dISCOUNTDataGridViewTextBoxColumn.HeaderText = "DISCOUNT";
            this.dISCOUNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dISCOUNTDataGridViewTextBoxColumn.Name = "dISCOUNTDataGridViewTextBoxColumn";
            this.dISCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.dISCOUNTDataGridViewTextBoxColumn.Width = 125;
            // 
            // cGSTDataGridViewTextBoxColumn
            // 
            this.cGSTDataGridViewTextBoxColumn.DataPropertyName = "CGST";
            this.cGSTDataGridViewTextBoxColumn.HeaderText = "CGST";
            this.cGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cGSTDataGridViewTextBoxColumn.Name = "cGSTDataGridViewTextBoxColumn";
            this.cGSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cGSTDataGridViewTextBoxColumn.Width = 125;
            // 
            // sGSTDataGridViewTextBoxColumn
            // 
            this.sGSTDataGridViewTextBoxColumn.DataPropertyName = "SGST";
            this.sGSTDataGridViewTextBoxColumn.HeaderText = "SGST";
            this.sGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sGSTDataGridViewTextBoxColumn.Name = "sGSTDataGridViewTextBoxColumn";
            this.sGSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGSTDataGridViewTextBoxColumn.Width = 125;
            // 
            // iGSTDataGridViewTextBoxColumn
            // 
            this.iGSTDataGridViewTextBoxColumn.DataPropertyName = "IGST";
            this.iGSTDataGridViewTextBoxColumn.HeaderText = "IGST";
            this.iGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iGSTDataGridViewTextBoxColumn.Name = "iGSTDataGridViewTextBoxColumn";
            this.iGSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGSTDataGridViewTextBoxColumn.Width = 125;
            // 
            // oFFERQUANTITYDataGridViewTextBoxColumn
            // 
            this.oFFERQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "OFFER_QUANTITY";
            this.oFFERQUANTITYDataGridViewTextBoxColumn.HeaderText = "OFFER_QUANTITY";
            this.oFFERQUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oFFERQUANTITYDataGridViewTextBoxColumn.Name = "oFFERQUANTITYDataGridViewTextBoxColumn";
            this.oFFERQUANTITYDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFERQUANTITYDataGridViewTextBoxColumn.Width = 125;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aMOUNTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tOTALAMOUNTDataGridViewTextBoxColumn
            // 
            this.tOTALAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_AMOUNT";
            this.tOTALAMOUNTDataGridViewTextBoxColumn.HeaderText = "TOTAL_AMOUNT";
            this.tOTALAMOUNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tOTALAMOUNTDataGridViewTextBoxColumn.Name = "tOTALAMOUNTDataGridViewTextBoxColumn";
            this.tOTALAMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALAMOUNTDataGridViewTextBoxColumn.Width = 125;
            // 
            // bILLDATEDataGridViewTextBoxColumn
            // 
            this.bILLDATEDataGridViewTextBoxColumn.DataPropertyName = "BILL_DATE";
            this.bILLDATEDataGridViewTextBoxColumn.HeaderText = "BILL_DATE";
            this.bILLDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bILLDATEDataGridViewTextBoxColumn.Name = "bILLDATEDataGridViewTextBoxColumn";
            this.bILLDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bILLDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // Supplier_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Supplier_data";
            this.Text = "Supplier_data";
            this.Load += new System.EventHandler(this.Supplier_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_BillDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBILLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Supplier_BillDataSet supplier_BillDataSet;
        private System.Windows.Forms.BindingSource sUPPLIERBILLBindingSource;
        private Supplier_BillDataSetTableAdapters.SUPPLIER_BILLTableAdapter sUPPLIER_BILLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPLIERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wEIGHTSIZEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFERQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLDATEDataGridViewTextBoxColumn;
    }
}
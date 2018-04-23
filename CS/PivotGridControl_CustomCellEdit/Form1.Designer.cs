namespace PivotGridControl_CustomCellEdit {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantityPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new PivotGridControl_CustomCellEdit.nwindDataSet();
            this.salesPersonTableAdapter = new PivotGridControl_CustomCellEdit.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.salesPersonBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOrderDate,
            this.fieldProductName,
            this.fieldQuantity,
            this.fieldQuantityPercent});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(660, 403);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomCellValue += new System.EventHandler<DevExpress.XtraPivotGrid.PivotCellValueEventArgs>(this.pivotGridControl1_CustomCellValue);
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOrderDate.AreaIndex = 0;
            this.fieldOrderDate.Caption = "Order Date";
            this.fieldOrderDate.FieldName = "OrderDate";
            this.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderDate.Name = "fieldOrderDate";
            this.fieldOrderDate.UnboundFieldName = "fieldOrderDate";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldProductName.AreaIndex = 0;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 0;
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fieldQuantityPercent
            // 
            this.fieldQuantityPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantityPercent.AreaIndex = 1;
            this.fieldQuantityPercent.Caption = "Quantity %";
            this.fieldQuantityPercent.FieldName = "Quantity";
            this.fieldQuantityPercent.Name = "fieldQuantityPercent";
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 403);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "The CustomCellEdit Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private nwindDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantityPercent;
    }
}


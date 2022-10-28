using System;
using System.Windows.Forms;
using DevExpress.Data.PivotGrid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPivotGrid;

namespace PivotGridControl_CustomCellEdit {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        // Creates new repository items.
        RepositoryItemProgressBar riProgressBar = new RepositoryItemProgressBar();
        RepositoryItemSpinEdit riSpinEdit = new RepositoryItemSpinEdit();
        private void Form1_Load(object sender, EventArgs e) {
            // Binds the pivot grid to data.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);
            // Initializes cell editors used to represent values of regular and total cells respectively.
            pivotGridControl1.RepositoryItems.AddRange(new RepositoryItem[] { riProgressBar, riSpinEdit });            
            pivotGridControl1.CustomCellEdit += new 
                EventHandler<PivotCustomCellEditEventArgs>(pivotGridControl1_CustomCellEdit);
        }
        private void pivotGridControl1_CustomCellEdit(object sender, PivotCustomCellEditEventArgs e) {
            // Specifies editors for cells depending on a cell type.
            if (e.DataField == fieldQuantityPercent) {
                if (e.RowValueType == PivotGridValueType.Value)
                    e.RepositoryItem = riProgressBar;

                if (e.RowValueType == PivotGridValueType.GrandTotal)
                    e.RepositoryItem = riSpinEdit;
            }
        }
        private void pivotGridControl1_CustomCellValue(object sender, PivotCellValueEventArgs e) {
            if (e.DataField == fieldQuantityPercent)
                e.Value = Convert.ToDecimal(e.Value) * 100;
        }
    }
}

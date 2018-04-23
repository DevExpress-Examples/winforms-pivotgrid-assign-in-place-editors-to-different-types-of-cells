using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPivotGrid;

namespace PivotGridControl_CustomCellEdit {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Binds the pivot grid to data.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

            // Specifies the type of data field and format settings.
            fieldQuantity1.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn;
            fieldQuantity1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            fieldQuantity1.CellFormat.FormatString = "{0}%";
        }

        private void pivotGridControl1_CustomCellEdit(object sender, PivotCustomCellEditEventArgs e) {
            // Initializes in-place editors used to represent values of regular and total cells respectively.
            RepositoryItemProgressBar editorForCells = new RepositoryItemProgressBar();
            RepositoryItemSpinEdit editorForTotals = new RepositoryItemSpinEdit();
            PivotGridControl pivot = sender as PivotGridControl;
            pivot.RepositoryItems.AddRange(
                new RepositoryItem[] { editorForCells, editorForTotals });

            // Specifies editors for cells depending on a cell type.
            if (e.DataField == fieldQuantity1) {
                if (e.RowValueType == PivotGridValueType.GrandTotal)
                    e.RepositoryItem = editorForTotals;
                if (e.RowValueType == PivotGridValueType.Value)
                    e.RepositoryItem = editorForCells;
            }
        }

        private void pivotGridControl1_CustomCellValue(object sender, PivotCellValueEventArgs e) {
            if (e.DataField == fieldQuantity1)
                e.Value = Convert.ToDecimal(e.Value) * 100;
        }
    }
}

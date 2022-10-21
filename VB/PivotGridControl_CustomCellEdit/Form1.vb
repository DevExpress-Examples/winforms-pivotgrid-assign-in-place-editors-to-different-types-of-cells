Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPivotGrid

Namespace PivotGridControl_CustomCellEdit

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Binds the pivot grid to data.
            salesPersonTableAdapter.Fill(nwindDataSet.SalesPerson)
            ' Specifies the type of data field and format settings.
            fieldQuantity1.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn
            fieldQuantity1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            fieldQuantity1.CellFormat.FormatString = "{0}%"
        End Sub

        Private Sub pivotGridControl1_CustomCellEdit(ByVal sender As Object, ByVal e As PivotCustomCellEditEventArgs)
            ' Initializes in-place editors used to represent values of regular and total cells respectively.
            Dim editorForCells As RepositoryItemProgressBar = New RepositoryItemProgressBar()
            Dim editorForTotals As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
            Dim pivot As PivotGridControl = TryCast(sender, PivotGridControl)
            pivot.RepositoryItems.AddRange(New RepositoryItem() {editorForCells, editorForTotals})
            ' Specifies editors for cells depending on a cell type.
            If e.DataField Is fieldQuantity1 Then
                If e.RowValueType = PivotGridValueType.GrandTotal Then e.RepositoryItem = editorForTotals
                If e.RowValueType = PivotGridValueType.Value Then e.RepositoryItem = editorForCells
            End If
        End Sub

        Private Sub pivotGridControl1_CustomCellValue(ByVal sender As Object, ByVal e As PivotCellValueEventArgs)
            If e.DataField Is fieldQuantity1 Then e.Value = Convert.ToDecimal(e.Value) * 100
        End Sub
    End Class
End Namespace

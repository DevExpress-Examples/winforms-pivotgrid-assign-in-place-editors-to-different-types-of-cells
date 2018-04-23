Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPivotGrid

Namespace PivotGridControl_CustomCellEdit
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        ' Creates new repository items.
        Dim riProgressBar As New RepositoryItemProgressBar()
        Dim riSpinEdit As New RepositoryItemSpinEdit()

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Binds the pivot grid to data.
            Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

            ' Specifies the type of data field and format settings.
            fieldQuantity1.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn
            fieldQuantity1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            fieldQuantity1.CellFormat.FormatString = "{0}%"

            ' Initializes cell editors used to represent values of regular and total cells respectively.
            pivotGridControl1.RepositoryItems.AddRange(New RepositoryItem() {riProgressBar, riSpinEdit})
        End Sub

        Private Sub pivotGridControl1_CustomCellEdit(ByVal sender As Object,
                            ByVal e As PivotCustomCellEditEventArgs) Handles pivotGridControl1.CustomCellEdit
            ' Specifies editors for cells depending on a cell type.
            If e.DataField Is fieldQuantity1 Then
                If e.RowValueType = PivotGridValueType.GrandTotal Then
                    e.RepositoryItem = riSpinEdit
                End If
                If e.RowValueType = PivotGridValueType.Value Then
                    e.RepositoryItem = riProgressBar
                End If
            End If
        End Sub

        Private Sub pivotGridControl1_CustomCellValue(ByVal sender As Object,
                            ByVal e As PivotCellValueEventArgs) Handles pivotGridControl1.CustomCellValue
            If e.DataField Is fieldQuantity1 Then
                e.Value = Convert.ToDecimal(e.Value) * 100
            End If
        End Sub
    End Class
End Namespace

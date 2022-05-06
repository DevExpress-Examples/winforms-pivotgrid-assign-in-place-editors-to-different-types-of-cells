Namespace PivotGridControl_CustomCellEdit
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim PercentOfTotalBinding1 As DevExpress.XtraPivotGrid.PercentOfTotalBinding = New DevExpress.XtraPivotGrid.PercentOfTotalBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New nwindDataSet()
            Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.salesPersonTableAdapter = New nwindDataSetTableAdapters.SalesPersonTableAdapter()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.DataSource = Me.salesPersonBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldOrderDate1, Me.fieldProductName1, Me.fieldQuantity2, Me.fieldQuantity})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(660, 403)
            Me.pivotGridControl1.TabIndex = 0
            '
            'salesPersonBindingSource
            '
            Me.salesPersonBindingSource.DataMember = "SalesPerson"
            Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
            '
            'nwindDataSet
            '
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'fieldOrderDate1
            '
            Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldOrderDate1.AreaIndex = 0
            Me.fieldOrderDate1.Caption = "Order Date"
            DataSourceColumnBinding1.ColumnName = "OrderDate"
            DataSourceColumnBinding1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderDate1.DataBinding = DataSourceColumnBinding1
            Me.fieldOrderDate1.Name = "fieldOrderDate1"
            '
            'fieldProductName1
            '
            Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldProductName1.AreaIndex = 0
            Me.fieldProductName1.Caption = "Product Name"
            DataSourceColumnBinding2.ColumnName = "ProductName"
            Me.fieldProductName1.DataBinding = DataSourceColumnBinding2
            Me.fieldProductName1.Name = "fieldProductName1"
            '
            'fieldQuantity2
            '
            Me.fieldQuantity2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity2.AreaIndex = 0
            DataSourceColumnBinding3.ColumnName = "Quantity"
            Me.fieldQuantity2.DataBinding = DataSourceColumnBinding3
            Me.fieldQuantity2.Name = "fieldQuantity2"
            '
            'fieldQuantity
            '
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 1
            Me.fieldQuantity.Caption = "Quantity %"
            Me.fieldQuantity.CellFormat.FormatString = "{0} %"
            Me.fieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            PercentOfTotalBinding1.PartitioningCriteria = DevExpress.XtraPivotGrid.CalculationPartitioningCriteria.ColumnValue
            DataSourceColumnBinding4.ColumnName = "Quantity"
            PercentOfTotalBinding1.Source = DataSourceColumnBinding4
            Me.fieldQuantity.DataBinding = PercentOfTotalBinding1
            Me.fieldQuantity.Name = "fieldQuantity"
            '
            'salesPersonTableAdapter
            '
            Me.salesPersonTableAdapter.ClearBeforeFill = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(660, 403)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private nwindDataSet As nwindDataSet
        Private salesPersonBindingSource As System.Windows.Forms.BindingSource
        Private salesPersonTableAdapter As nwindDataSetTableAdapters.SalesPersonTableAdapter
        Private fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldQuantity2 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace


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
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New PivotGridControl_CustomCellEdit.nwindDataSet()
            Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.salesPersonTableAdapter = New PivotGridControl_CustomCellEdit.nwindDataSetTableAdapters.SalesPersonTableAdapter()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataSource = Me.salesPersonBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldOrderDate, Me.fieldProductName, Me.fieldQuantity, Me.fieldQuantity1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(660, 403)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' salesPersonBindingSource
            ' 
            Me.salesPersonBindingSource.DataMember = "SalesPerson"
            Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldOrderDate
            ' 
            Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldOrderDate.AreaIndex = 0
            Me.fieldOrderDate.Caption = "Order Date"
            Me.fieldOrderDate.FieldName = "OrderDate"
            Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderDate.Name = "fieldOrderDate"
            Me.fieldOrderDate.UnboundFieldName = "fieldOrderDate"
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldProductName.AreaIndex = 0
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 0
            Me.fieldQuantity.FieldName = "Quantity"
            Me.fieldQuantity.Name = "fieldQuantity"
            ' 
            ' fieldQuantity1
            ' 
            Me.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity1.AreaIndex = 1
            Me.fieldQuantity1.Caption = "Quantity %"
            Me.fieldQuantity1.FieldName = "Quantity"
            Me.fieldQuantity1.Name = "fieldQuantity1"
            ' 
            ' salesPersonTableAdapter
            ' 
            Me.salesPersonTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(660, 403)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private nwindDataSet As nwindDataSet
        Private salesPersonBindingSource As System.Windows.Forms.BindingSource
        Private salesPersonTableAdapter As nwindDataSetTableAdapters.SalesPersonTableAdapter
        Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace


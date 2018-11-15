<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/PivotGridControl_CustomCellEdit/Form1.cs) (VB: [Form1.vb](./VB/PivotGridControl_CustomCellEdit/Form1.vb))
<!-- default file list end -->
# How to assign different in-place editors to different types of cells


<p>The following code shows how to handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellEdittopic">PivotGridControl.CustomCellEdit</a> event to assign different in-place editors to different types of cells.</p>
<p>In the example, two in-place editors (repository items) are created to represent values of the "Quantity %" field. The ProgressBar editor is used to represent regular cell values, while the SpinEdit editor is used to represent total values for this field.</p>

<br/>



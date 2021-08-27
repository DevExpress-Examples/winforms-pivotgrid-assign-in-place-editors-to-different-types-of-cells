<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581578/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T153888)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/PivotGridControl_CustomCellEdit/Form1.cs) (VB: [Form1.vb](./VB/PivotGridControl_CustomCellEdit/Form1.vb))
* [Program.cs](./CS/PivotGridControl_CustomCellEdit/Program.cs) (VB: [Program.vb](./VB/PivotGridControl_CustomCellEdit/Program.vb))
<!-- default file list end -->
# How to assign different in-place editors to different types of cells


<p>The following code shows how to handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellEdittopic">PivotGridControl.CustomCellEdit</a> event to assign different in-place editors to different types of cells.</p>
<p>In the example, two in-place editors (repository items) are created to represent values of the "Quantity %" field. The ProgressBar editor is used to represent regular cell values, while the SpinEdit editor is used to represent total values for this field.</p>

<br/>



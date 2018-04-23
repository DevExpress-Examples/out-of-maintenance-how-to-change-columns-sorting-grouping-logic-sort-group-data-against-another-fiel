Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Invoices' table. You can move, or remove it, as needed.
			Me.invoicesTableAdapter.Fill(Me.nwindDataSet.Invoices)

'			#Region "#1"
			colUnitPrice.FieldNameSortGroup = "ExtendedPrice"
			colUnitPrice.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
'			#End Region ' #1
		End Sub
	End Class
End Namespace
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            invoicesBindingSource.DataSource = GetInvoicesDataTable()
            colUnitPrice.FieldNameSortGroup = "ExtendedPrice"
            colUnitPrice.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        End Sub

        Private Function GetInvoicesDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.TableName = "Invoices"
            table.Columns.Add(New DataColumn("ProductName", GetType(String)))
            table.Columns.Add(New DataColumn("Discount", GetType(Integer)))
            table.Columns.Add(New DataColumn("Quantity", GetType(Integer)))
            table.Columns.Add(New DataColumn("UnitPrice", GetType(Double)))
            table.Columns.Add(New DataColumn("ExtendedPrice", GetType(Double)))
            Dim random As Random = New Random()
            For i As Integer = 0 To 20 - 1
                Dim index As Integer = i + 1
                table.Rows.Add("Product " & index, index * 2, index Mod 9, (index + random.[Next](1, 10)) * 1000.0R, (index + random.[Next](1, 10)) * 1000.0R + index * 100.0R)
            Next
            Return table
        End Function
    End Class
End Namespace

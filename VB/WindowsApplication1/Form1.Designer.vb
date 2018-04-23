Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.invoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New WindowsApplication1.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colExtendedPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.invoicesTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.InvoicesTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.invoicesBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(695, 412)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' invoicesBindingSource
			' 
			Me.invoicesBindingSource.DataMember = "Invoices"
			Me.invoicesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductName, Me.colUnitPrice, Me.colQuantity, Me.colDiscount, Me.colExtendedPrice})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colProductName
			' 
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 0
			Me.colProductName.Width = 110
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.DisplayFormat.FormatString = "c2"
			Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 1
			Me.colUnitPrice.Width = 189
			' 
			' colQuantity
			' 
			Me.colQuantity.FieldName = "Quantity"
			Me.colQuantity.Name = "colQuantity"
			Me.colQuantity.Visible = True
			Me.colQuantity.VisibleIndex = 3
			Me.colQuantity.Width = 83
			' 
			' colDiscount
			' 
			Me.colDiscount.FieldName = "Discount"
			Me.colDiscount.Name = "colDiscount"
			Me.colDiscount.Visible = True
			Me.colDiscount.VisibleIndex = 4
			Me.colDiscount.Width = 96
			' 
			' colExtendedPrice
			' 
			Me.colExtendedPrice.DisplayFormat.FormatString = "c2"
			Me.colExtendedPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colExtendedPrice.FieldName = "ExtendedPrice"
			Me.colExtendedPrice.Name = "colExtendedPrice"
			Me.colExtendedPrice.OptionsColumn.ReadOnly = True
			Me.colExtendedPrice.Visible = True
			Me.colExtendedPrice.VisibleIndex = 2
			Me.colExtendedPrice.Width = 196
			' 
			' invoicesTableAdapter
			' 
			Me.invoicesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(695, 412)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As nwindDataSet
		Private invoicesBindingSource As System.Windows.Forms.BindingSource
		Private invoicesTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.InvoicesTableAdapter
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn
		Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn
		Private colExtendedPrice As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace


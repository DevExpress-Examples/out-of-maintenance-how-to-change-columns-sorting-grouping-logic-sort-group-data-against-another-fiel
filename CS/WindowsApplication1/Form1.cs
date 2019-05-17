using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            invoicesBindingSource.DataSource = GetInvoicesDataTable();
            colUnitPrice.FieldNameSortGroup = "ExtendedPrice";
            colUnitPrice.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        }

        DataTable GetInvoicesDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Invoices";
            table.Columns.Add(new DataColumn("ProductName", typeof(string)));
            table.Columns.Add(new DataColumn("Discount", typeof(int)));
            table.Columns.Add(new DataColumn("Quantity", typeof(int)));
            table.Columns.Add(new DataColumn("UnitPrice", typeof(double)));
            table.Columns.Add(new DataColumn("ExtendedPrice", typeof(double)));
            Random random = new Random();
            for(int i = 0; i < 20; i++)
            {
                int index = i + 1;
                table.Rows.Add("Product " + index, index * 2, index % 9, (index + random.Next(1, 10)) * 1000d, (index + random.Next(1, 10)) * 1000d + index * 100d);
            }
            return table;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.nwindDataSet.Invoices);

            #region #1
            colUnitPrice.FieldNameSortGroup = "ExtendedPrice";
            colUnitPrice.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            #endregion #1
        }
    }
}
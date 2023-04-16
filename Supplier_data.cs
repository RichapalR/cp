using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Supplier_data : Form
    {
        public Supplier_data()
        {
            InitializeComponent();
        }

        private void Supplier_data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplier_BillDataSet.SUPPLIER_BILL' table. You can move, or remove it, as needed.
            this.sUPPLIER_BILLTableAdapter.Fill(this.supplier_BillDataSet.SUPPLIER_BILL);

        }
    }
}

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
    public partial class home_page : Form
    {
        public home_page(string uname)
        {
            InitializeComponent();
            toolStripMenuItem1.Text = uname;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login_page login = new login_page();
            login.Show();
        }

        private void home_page_Load(object sender, EventArgs e)
        {
            
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_account add_Account = new Add_account(string.Empty);
            add_Account.Show();
        }

        private void addIteamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Product add_iteams = new Add_Product();
            add_iteams.Show();
        }

        private void home_page_FormClosed(object sender, FormClosedEventArgs e)
        {
            login_page login_page = new login_page();
            login_page.Show();
        }

        private void control1_Click(object sender, EventArgs e)
        {
            register_page reg = new register_page();
            reg.Activate();
        }

        private void addAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_account add_Account = new Add_account(string.Empty);
            add_Account.Show();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void modifyAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(); 
            frm1.Show();
            
        }

        private void deleteAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void buyInvoiceBuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buy_product buy_Product = new Buy_product();
            buy_Product.Show();
        }
    }
}

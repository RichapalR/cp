using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ary patel\Downloads\New folder\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        public static string com;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'add_accDataSet.ADD_ACCOUNT' table. You can move, or remove it, as needed.
            this.aDD_ACCOUNTTableAdapter.Fill(this.add_accDataSet.ADD_ACCOUNT);
            //comboBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com = comboBox.Text;
            Add_account add = new Add_account(com);
            add.Show();            
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
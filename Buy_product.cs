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

namespace WindowsFormsApp1
{
    public partial class Buy_product : Form
    {
        int count = 0;
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ary patel\Downloads\New folder\Database1.mdf"";Integrated Security=True");

        public Buy_product()
        {
            InitializeComponent();
//            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
        }

        public void ID()
        {
            string id;
            string query = "SELECT BILL_NO FROM SUPPLIER_BILL ORDER BY BILL_NO Desc;";
            cnn.Open();
            //bill no
            SqlCommand bill_no = new SqlCommand(query, cnn);
            
            SqlDataReader dr = bill_no.ExecuteReader();

            if (dr.Read())
            {
                int i = int.Parse(dr[0].ToString()) + 1;
                id = i.ToString("00");
            }
            else if (Convert.IsDBNull(dr))
            {
                id = "01";
            }
            else
            {
                id = "01";
            }
            cnn.Close();
            
            textBox7.Text = id.ToString();
        }

        public void acc_name()
        {
            SqlCommand acc_name_ = new SqlCommand("SELECT id, acc_name FROM dbo.ADD_ACCOUNT where type_of_customer = 'Supplier'", cnn);
            SqlDataAdapter an = new SqlDataAdapter();
            an.SelectCommand = acc_name_;
            DataTable ac_n = new DataTable();
            an.Fill(ac_n);

            DataRow itemrow = ac_n.NewRow();
            itemrow[1] = "";
            ac_n.Rows.InsertAt(itemrow, 0);

            comboBox1.DataSource = ac_n;
            comboBox1.DisplayMember = "acc_name";
            comboBox1.ValueMember = "id";
        }

        public void brand()
        {
            SqlCommand brand_ = new SqlCommand("SELECT DISTINCT brand FROM dbo.ADD_PRODUCT", cnn);
            SqlDataAdapter br = new SqlDataAdapter();
            br.SelectCommand = brand_;
            DataTable br_n = new DataTable();
            br.Fill(br_n);

            DataRow itemrow = br_n.NewRow();
            itemrow[0] = "";
            br_n.Rows.InsertAt(itemrow, 0);

            comboBox2.DataSource = br_n;
            comboBox2.DisplayMember = "brand";

        }

        public void product_name()
        {
            SqlCommand brand_ = new SqlCommand("SELECT product_name FROM dbo.ADD_PRODUCT where brand = '" + comboBox2.Text + "'", cnn);
            
            SqlDataAdapter br = new SqlDataAdapter();
            br.SelectCommand = brand_;
            DataTable br_n = new DataTable();
            br.Fill(br_n);

            DataRow itemrow = br_n.NewRow();
            itemrow[0] = "";
            br_n.Rows.InsertAt(itemrow, 0);

            comboBox3.DataSource = br_n;
            comboBox3.DisplayMember = "product_name";
            
        }

        public void product_weight()
        {
            SqlCommand cmd = new SqlCommand("SELECT weight_, weight_size, product_Price FROM dbo.ADD_PRODUCT where product_name = '" + comboBox3.Text + "'", cnn);

            SqlDataAdapter br = new SqlDataAdapter();
            br.SelectCommand = cmd;
            DataTable br_n = new DataTable();
            br.Fill(br_n);

            comboBox4.DataSource = br_n;
            comboBox4.DisplayMember = "weight_";

            comboBox5.DataSource = br_n;
            comboBox5.DisplayMember = "weight_size";

            cnn.Open();
            SqlDataReader reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                textBox1.Text = reader1["product_Price"].ToString();
            }
            reader1.Close();
            cnn.Close();
        }

        private void Buy_product_Load(object sender, EventArgs e)
        {
            textBox8.Hide();
            label18.Hide();
            // --------------------------------------------------
            //create table SUPPLIER_BILL
            cnn.Open();
            string query = "use [C:\\USERS\\ARY PATEL\\DOWNLOADS\\NEW FOLDER\\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'SUPPLIER_BILL') BEGIN SELECT BILL_NO FROM SUPPLIER_BILL ORDER BY BILL_NO Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE SUPPLIER_BILL(BILL_NO int, Sr int, SUPPLIER_NAME nvarchar(100), BRAND nvarchar(50), PRODUCT_NAME nvarchar(150), PRICE float, STOCK int, WEIGHT_ int, WEIGHT_SIZE nvarchar(10), DISCOUNT int, CGST float, SGST float, OFFER_QUANTITY int, BILL_DATE date); PRINT 'Table does not exist.' END";
            SqlCommand db = new SqlCommand(query, cnn);
            
            // IF QUERY EXECUTE IT ADD BILL NO
            if (db.ExecuteNonQuery() != 0)
            {
                cnn.Close();
                if (textBox1.Text == "")
                { ID(); }
                
            }
            else
            {
                cnn.Close();
            }

            //            int count = 1;
            count++;
            textBox8.Text = count.ToString();

            // show only supplier type customer
            acc_name();
            brand();
            product_name();

            //-----------------------------------------------------------------------
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            product_weight();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // item no.
            if (count == 1)
            {
                textBox8.Text = count.ToString();
                count++;
            }
            else
            {
                textBox8.Text = count.ToString();
                count++;
            }
            //-------------------------------------------------

            // for add total amount of product
            int amo = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)) - Convert.ToInt32(textBox3.Text);
            double s_amo = (Convert.ToInt32(amo) * Convert.ToDouble(textBox4.Text)) / 100;
            double c_amo = (Convert.ToInt32(amo) * Convert.ToDouble(textBox5.Text)) / 100;
            double i_amo = (Convert.ToInt32(amo) * Convert.ToDouble(textBox9.Text)) / 100;
            double total = Convert.ToDouble(s_amo) + Convert.ToDouble(c_amo) + Convert.ToDouble(i_amo) + Convert.ToInt32(amo);
            
            // add item into list view
            ListViewItem list = new ListViewItem(textBox8.Text);
            list.SubItems.Add(comboBox2.Text);
            list.SubItems.Add(comboBox3.Text);
            list.SubItems.Add(textBox1.Text.ToString());
            list.SubItems.Add(textBox2.Text.ToString());
            list.SubItems.Add(comboBox4.Text.ToString());
            list.SubItems.Add(comboBox5.Text);
            list.SubItems.Add(textBox3.Text.ToString());
            list.SubItems.Add(textBox4.Text.ToString());
            list.SubItems.Add(textBox5.Text.ToString());
            list.SubItems.Add(textBox6.Text.ToString());
            list.SubItems.Add(textBox9.Text.ToString());
            list.SubItems.Add(amo.ToString());

            listView1.Items.Add(list);
            //----------------------------------------------------------
            // after adding item into list view do all are empty except supplier name
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox9.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            product_name();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
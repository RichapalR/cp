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
        double total;
        int count = 0;
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ary patel\Downloads\New folder\Database1.mdf"";Integrated Security=True");

        public Buy_product()
        {
            InitializeComponent();
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
            textBox2.Text = "00";
            textBox3.Text = "00";
            textBox4.Text = "00";
            textBox5.Text = "00";
            textBox6.Text = "00";
            textBox9.Text = "00";
            textBox8.Hide();
            label18.Hide();
            label14.Text = "00";
            label15.Text = "00";
            label16.Text = "00";
            // --------------------------------------------------
            //create table SUPPLIER_BILL
            cnn.Open();
            string query = "use [C:\\USERS\\ARY PATEL\\DOWNLOADS\\NEW FOLDER\\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'SUPPLIER_BILL') BEGIN SELECT BILL_NO FROM SUPPLIER_BILL ORDER BY BILL_NO Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE SUPPLIER_BILL(BILL_NO int, SUPPLIER_NAME nvarchar(50), SR int, BRAND nvarchar(50), PRODUCT_NAME nvarchar(150), PRICE float, STOCK int, WEIGHT_ int, WEIGHT_SIZE nvarchar(5), DISCOUNT int, CGST float, SGST float, IGST float, OFFER_QUANTITY int, AMOUNT numeric(10), TOTAL_AMOUNT numeric(12), BILL_DATE date); PRINT 'Table does not exist.' END";
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
            double amo = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)) - Convert.ToDouble(textBox3.Text);
            double s_amo = (Convert.ToDouble(amo) * Convert.ToDouble(textBox4.Text)) / 100;
            double c_amo = (Convert.ToDouble(amo) * Convert.ToDouble(textBox5.Text)) / 100;
            double i_amo = (Convert.ToDouble(amo) * Convert.ToDouble(textBox9.Text)) / 100;
            double total = Convert.ToDouble(s_amo) + Convert.ToDouble(c_amo) + Convert.ToDouble(i_amo) + Convert.ToInt32(amo);
            double finalamount = amo + s_amo + c_amo + i_amo;
            
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
            list.SubItems.Add(finalamount.ToString());

            listView1.Items.Add(list);
            //----------------------------------------------------------
            // after adding item into list view do all are empty except supplier name
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "00";
            textBox3.Text = "00";
            textBox4.Text = "00";
            textBox5.Text = "00";
            textBox6.Text = "00";
            textBox9.Text = "00";
            //----------------------------------------------------------------
            //label amount of (amount, gst amount, total amount)
            double sum = 0;
            double famount = 0;
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                sum += double.Parse(listView1.Items[i].SubItems[12].Text);
                famount += double.Parse(listView1.Items[i].SubItems[13].Text);
            }
            label14.Text = sum.ToString();
            label16.Text = famount.ToString();
            double gst = Convert.ToDouble(label16.Text) - Convert.ToDouble(label14.Text);
            label15.Text = gst.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            product_name();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem list in listView1.Items)
            {
                try
                {
                    cnn.Open();
                    string insert = "INSERT INTO SUPPLIER_BILL(BILL_NO, SUPPLIER_NAME, SR, BRAND, PRODUCT_NAME, PRICE, STOCK, WEIGHT_, WEIGHT_SIZE, DISCOUNT, CGST, SGST, IGST, OFFER_QUANTITY, AMOUNT, TOTAL_AMOUNT, BILL_DATE) VALUES(@bill_no, @supplier_name, @sr, @brand, @product_name, @price, @stock, @weight_, @weight_size, @discount, @cgst, @sgst, @igst, @offer_quantity, @amount, @total_amount, @date);";
                    SqlCommand inserts = new SqlCommand(insert, cnn);
                    inserts.Parameters.AddWithValue("@bill_no", textBox7.Text);
                    inserts.Parameters.AddWithValue("@supplier_name", comboBox1.Text);
                    inserts.Parameters.AddWithValue("@sr", list.SubItems[0].Text);
                    inserts.Parameters.AddWithValue("@brand", list.SubItems[1].Text);
                    inserts.Parameters.AddWithValue("@product_name", list.SubItems[2].Text);
                    inserts.Parameters.AddWithValue("@price", list.SubItems[3].Text);
                    inserts.Parameters.AddWithValue("@stock", list.SubItems[4].Text);
                    inserts.Parameters.AddWithValue("@weight_", list.SubItems[5].Text);
                    inserts.Parameters.AddWithValue("@weight_size", list.SubItems[6].Text);
                    inserts.Parameters.AddWithValue("@discount", list.SubItems[7].Text);
                    inserts.Parameters.AddWithValue("@cgst", list.SubItems[8].Text);
                    inserts.Parameters.AddWithValue("@sgst", list.SubItems[9].Text);
                    inserts.Parameters.AddWithValue("@igst", list.SubItems[11].Text);
                    inserts.Parameters.AddWithValue("@offer_quantity", list.SubItems[10].Text);
                    inserts.Parameters.AddWithValue("@amount", list.SubItems[12].Text);
                    inserts.Parameters.AddWithValue("@total_amount", list.SubItems[13].Text);
                    inserts.Parameters.AddWithValue("@date", DateTime.Now);
                    inserts.ExecuteNonQuery();
                    cnn.Close();
                    
                }
                catch
                {

                }
            }
            MessageBox.Show("Bill Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem eachitem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachitem);
            }
            double sum = 0;
            double famount = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sum += double.Parse(listView1.Items[i].SubItems[12].Text);
                famount += double.Parse(listView1.Items[i].SubItems[13].Text);
            }
            label14.Text = sum.ToString();
            label16.Text = famount.ToString();
            double gst = Convert.ToDouble(label16.Text) - Convert.ToDouble(label14.Text);
            label15.Text = gst.ToString();
        }
    }
}
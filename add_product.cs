using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//picture error is available

namespace WindowsFormsApp1
{
    public partial class Add_Product : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ary patel\Downloads\New folder\Database1.mdf"";Integrated Security=True");
        //count the number of iteam and do it count++
        public void ID()
        {
            string id;
            string query = "SELECT id FROM ADD_PRODUCT ORDER BY id Desc;";
            con.Open();
            SqlCommand ins = new SqlCommand(query, con);
            SqlDataReader dr = ins.ExecuteReader();

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
            con.Close();
            textBox7.Text = id.ToString();
        }

        public Add_Product()
        {
            InitializeComponent();
        }

        private void add_iteams_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "use [C:\\USERS\\ARY PATEL\\DOWNLOADS\\NEW FOLDER\\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'ADD_PRODUCT') BEGIN SELECT id FROM ADD_PRODUCT ORDER BY id Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE ADD_PRODUCT(id int, brand nvarchar(50), product_name nvarchar(100), product_Price float, stock int, retail_price float, weight_ int, weight_size nvarchar(10), primary key(id)); PRINT 'Table does not exist.' END";
//            string query = "use [C:\\USERS\\ARY PATEL\\DOWNLOADS\\NEW FOLDER\\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'ADD_PRODUCT') BEGIN SELECT id FROM ADD_PRODUCT ORDER BY id Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE ADD_PRODUCT(id int, brand nvarchar(50), product_name nvarchar(100), product_Price float, stock int, retail_price float, weight_ int, weight_size nvarchar(10), product_picture varbinary(max), primary key(id)); PRINT 'Table does not exist.' END";
            SqlCommand db = new SqlCommand(query, con);
            // IF QUERY EXECUTE IT ADD TABLE INDEX NO
            if (db.ExecuteNonQuery() != 0)
            {
                con.Close();
                if (textBox7.Text == "")
                { 
                    ID(); 
                }
            }
            else
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "" || textBox7.Text != "" || /*pictureBox1.Image != null ||*/ comboBox1.SelectedText != "")
                {
                    DateTime date = DateTime.Now;
                    // add valuse in ADD_PRODUCT DB
                    //SqlCommand c = new SqlCommand("INSERT INTO ADD_PRODUCT VALUES(@id, @brand, @product_name, @product_price, @stock, @retail_price, @weight_, @weight_size, @product_picture)", con);
                    SqlCommand c = new SqlCommand("INSERT INTO ADD_PRODUCT VALUES(@id, @brand, @product_name, @product_price, @stock, @retail_price, @weight_, @weight_size)", con);


                    c.Parameters.AddWithValue("@id", textBox7.Text);
                    c.Parameters.AddWithValue("@brand", textBox1.Text);
                    c.Parameters.AddWithValue("@product_name", textBox2.Text);
                    c.Parameters.AddWithValue("@product_Price", textBox3.Text);
                    c.Parameters.AddWithValue("@stock", textBox4.Text);
                    c.Parameters.AddWithValue("@retail_price", textBox5.Text);
                    c.Parameters.AddWithValue("@weight_", textBox6.Text);
                    c.Parameters.AddWithValue("@weight_size", comboBox1.SelectedItem.ToString());
                    //c.Parameters.AddWithValue("@product_picture", pictureBox1.Image);

                    con.Open();
                    c.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("PRODUCT ADDED");


                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    comboBox1.SelectedIndex = 0;
                    //pictureBox1.Image = null;

                    ID();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.SelectedIndex = 0;
            //pictureBox1.Image = null;
        }
    }
}

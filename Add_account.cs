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
    public partial class Add_account : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ary patel\Downloads\New folder\Database1.mdf"";Integrated Security=True");
        //SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-UUUF0RET;Initial Catalog=dball;Integrated Security=True;Pooling=False");
        
        //it can change button name ( add > modify )  and ( reset into delete ) and retrive value from form.cs
        public Add_account(string com )
        {
            InitializeComponent();
            textBox2.Text = com;
            if (textBox2.Text != "")
            {
                button1.Text = "Modify";
                button2.Text = "Delete";
                cnn.Open();
                string fetchquery = "select id from ADD_ACCOUNT WHERE acc_name = '" + textBox2.Text + "' ";
                SqlCommand c = new SqlCommand(fetchquery, cnn);
                SqlDataReader dr = c.ExecuteReader();
                dr.Read();
                textBox1.Text = dr.GetValue(0).ToString();
                cnn.Close();
            }
        }

        public void combobox(string com)
        {
            label15.Text = com.ToString();
        }


        // auto count id/serial no
        public void ID()
        {
            string id;
            string query = "SELECT id FROM ADD_ACCOUNT ORDER BY id Desc;";
            cnn.Open();
            SqlCommand ins = new SqlCommand(query, cnn);
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
            cnn.Close();
            textBox1.Text = id.ToString();
        }

        private void Add_account_Load(object sender, EventArgs e)
        {
            
            //create table ACC_ACCOUNT
            cnn.Open();
            string query = "use [C:\\USERS\\ARY PATEL\\DOWNLOADS\\NEW FOLDER\\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'ADD_ACCOUNT') BEGIN SELECT id FROM ADD_ACCOUNT ORDER BY id Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE ADD_ACCOUNT(id int, acc_name nvarchar(50), type_of_customer nvarchar(10), opening_balance float, address nvarchar(500), city nvarchar(20), pincode numeric(6,0), phone_no numeric(10,0), pan nvarchar(10), aadhaar numeric(12,0), gst_no nvarchar(15), acc_add_date date, primary key(acc_name)); PRINT 'Table does not exist.' END";
            SqlCommand db = new SqlCommand(query, cnn);
                // IF QUERY EXECUTE IT ADD TABLE INDEX NO
                if (db.ExecuteNonQuery() != 0)
                {
                    cnn.Close();
                    if(textBox1.Text == "")
                    { ID(); }
                    //ID();
                }
                else
                {
                    //CREATE ADD_ACCOUNT IF NOT AVAILABLE
                    //SqlCommand cmd = new SqlCommand("CREATE TABLE ADD_ACCOUNT(id int, acc_name nvarchar(50), type_of_customer nvarchar(10), opening_balance float, address nvarchar(500), city nvarchar(20), pincode int, phone_no int, pan nvarchar(10), aadhaar nvarchar(12), gst_no nvarchar(15), acc_add_date date, primary key(acc_name));", cnn);
                    //cmd.ExecuteNonQuery();
                    cnn.Close();
                }

            if (textBox2.Text != "")
            {
                MessageBox.Show("hello");
                button1.Text = "Modify";
                button2.Text = "Delete";
                /*cnn.Open();
                string fetchquery = "select * from '" + comboBox1.SelectedText + "' ";
                SqlCommand c = new SqlCommand(fetchquery, cnn);
                var read = c.ExecuteReader();
                textBox1.Text = (read["ID"].ToString());
                textBox2.Text = (read["add_name"].ToString());
                cnn.Close();*/
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "" || textBox7.Text != "" || textBox9.Text != "" || textBox10.Text != "" || textBox11.Text != "" || comboBox1.SelectedText != "")
                {
                    DateTime date = DateTime.Now;
                    // add valuse in ADD_ACCOUNT
                    SqlCommand c = new SqlCommand("INSERT INTO ADD_ACCOUNT VALUES(@id, @acc_name, @type_of_customer, @opening_balance, @address, @city, @pincode, @phone_no, @pancard, @adhaar_no, @gst_no, @acc_add_date)", cnn);
                                        
                    c.Parameters.AddWithValue("@id", textBox1.Text);
                    c.Parameters.AddWithValue("@acc_name", textBox2.Text);
                    c.Parameters.AddWithValue("@type_of_customer", comboBox1.Text);
                    c.Parameters.AddWithValue("@opening_balance", textBox3.Text);
                    c.Parameters.AddWithValue("@address", textBox4.Text);
                    c.Parameters.AddWithValue("@city", textBox5.Text);
                    c.Parameters.AddWithValue("@pincode", textBox6.Text);
                    c.Parameters.AddWithValue("@phone_no", textBox7.Text);
                    c.Parameters.AddWithValue("@pancard", textBox9.Text);
                    c.Parameters.AddWithValue("@adhaar_no", textBox10.Text);
                    c.Parameters.AddWithValue("@gst_no", textBox11.Text);
                    c.Parameters.AddWithValue("@acc_add_date", date);

                    cnn.Open();

                    c.ExecuteNonQuery();
                    MessageBox.Show("ACCOUNT ADDED");
                    
                    cnn.Close();
                    
                    textBox2.Text = "";
                    textBox3.Text = "00.00";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    comboBox1.SelectedIndex = 0;

                    ID();
                    

                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                cnn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "00.00";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            comboBox1.SelectedIndex = 0;
        }
        private void Add_account_FormClosed(object sender, FormClosedEventArgs e)
        {
            home_page home = new home_page(string.Empty);
            home.Show();
        }
    }
}

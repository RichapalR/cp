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
    public partial class register_page : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ary patel\Downloads\New folder\Database1.mdf"";Integrated Security=True");
//        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-UUUF0RET;Initial Catalog=dball;Integrated Security=True;Pooling=False");

        public void ID()
        {
            string id;
            string query = "SELECT id FROM REGISTRATION ORDER BY id Desc;";
            cnn.Open();
            SqlCommand ins = new SqlCommand(query, cnn);
            SqlDataReader dr = ins.ExecuteReader();

            if(dr.Read())
            {
                int i = int.Parse(dr[0].ToString()) + 1;
                id = i.ToString("0000");
            }
            else if(Convert.IsDBNull(dr))
            {
                id = "0001";
            }
            else
            {
                id = "0001";
            }
            cnn.Close();
            textBox17.Text = id.ToString();
        }
    public register_page()
        {
            InitializeComponent();
        }

        private void register_page_Load(object sender, EventArgs e)
        {
            try
            {
                control3.BringToFront();
                textBox17.Hide();
                label16.Hide();
                cnn.Open();
                //IF TABLE NOT EXISTS THEN CREATE NEW TABLE AND COUNT ID'S FOR AUTO CHANGE ID'S
                string query = "use [C:\\USERS\\ARY PATEL\\DOWNLOADS\\NEW FOLDER\\DATABASE1.MDF] IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'REGISTRATION') BEGIN SELECT id FROM REGISTRATION ORDER BY id Desc PRINT 'Table exists.' END ELSE BEGIN CREATE TABLE REGISTRATION(id int, company_name nvarchar(20), username nvarchar(20), password nvarchar(18), re_password nvarchar(18), address nvarchar(500), mobile_no numeric(10,0), city nvarchar(30), state nvarchar(30), pincode numeric(6,0), gst_no nvarchar(15), pancard nvarchar(10), adhaar_no numeric(12,0), upi_no nvarchar(18), bank_name nvarchar(100), acc_no numeric(15,0), ifsc_code nvarchar(15), acc_type nvarchar(20), primary key(company_name)); PRINT 'Table does not exist.' END";
                                    
                SqlCommand db = new SqlCommand(query, cnn);
                
                if(db.ExecuteNonQuery() != 0)
                {
                    cnn.Close();
                    ID();
                    
                }
                else
                {
                    cnn.Close();
                }
            }
            finally
            {
                
            }

        }

        private void next_name_Click(object sender, EventArgs e)
        {     
            try
            {
                
                if(textBox1.Text=="" || textBox2.Text=="" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Fill all the details");
                }
                if (textBox3.Text != textBox4.Text)
                {
                    MessageBox.Show("Your password isn't same.", "Error!!");
                }
               
                if (textBox3.Text == textBox4.Text & textBox3.Text != "" & textBox4.Text != "" & textBox1.Text != "" & textBox2.Text != "")
                {
                    tabPage2.Show();
                    tabPage1.Hide();
                    checkBox1.Checked = true;
                }

            }
            catch
            {
                MessageBox.Show("Database Error!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text =="")
                {
                    MessageBox.Show("Fill all the details");
                }
                else
                {
                    tabPage3.Show();
                    tabPage2.Hide();
                    checkBox2.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("Database Error!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox14.Text == "")
                {
                    MessageBox.Show("Fill all the details");
                }
                else
                {
                    tabPage4.Show();
                    tabPage3.Hide();
                    checkBox3.Checked = true;
                    label13.Text = "Welcome " + textBox1.Text;
                }
            }
            catch
            {
                MessageBox.Show("Database Error!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text.Length >= 4 || textBox4.Text.Length >= 4)
                {
                    SqlCommand c = new SqlCommand("INSERT INTO REGISTRATION values(@id, @company_name, @user, @password, @re_password, @address, @mobile_no, @city, @state, @pincode, @gst_no, @pancard, @adhaar_no, @upi_no, @bank_name, @acc_no, @ifsc_code, @acc_type)", cnn);

                    c.Parameters.AddWithValue("@id", textBox17.Text);
                    c.Parameters.AddWithValue("@company_name", textBox1.Text);
                    c.Parameters.AddWithValue("@user", textBox2.Text);
                    c.Parameters.AddWithValue("@password", textBox3.Text);
                    c.Parameters.AddWithValue("@re_password", textBox4.Text);
                    c.Parameters.AddWithValue("@address", textBox5.Text);
                    c.Parameters.AddWithValue("@mobile_no", textBox6.Text);
                    c.Parameters.AddWithValue("@city", textBox7.Text);
                    c.Parameters.AddWithValue("@state", textBox8.Text);
                    c.Parameters.AddWithValue("@pincode", textBox9.Text);
                    c.Parameters.AddWithValue("@gst_no", textBox10.Text);
                    c.Parameters.AddWithValue("@pancard", textBox11.Text);
                    c.Parameters.AddWithValue("@adhaar_no", textBox12.Text);
                    c.Parameters.AddWithValue("@upi_no", textBox13.Text);
                    c.Parameters.AddWithValue("@bank_name", textBox14.Text);
                    c.Parameters.AddWithValue("@acc_no", textBox15.Text);
                    c.Parameters.AddWithValue("@ifsc_code", textBox16.Text);
                    c.Parameters.AddWithValue("@acc_type", comboBox1.SelectedItem.ToString());

                    cnn.Open();
                    c.ExecuteNonQuery();
                    MessageBox.Show("thank you");
                    //OPEN LOGIN PAGE AND CLOSE THIS FORM
                    login_page reg = new login_page();
                    reg.Show();
                    this.Hide();
                    cnn.Close();
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

        private void button9_Click(object sender, EventArgs e)
        {
            tabPage3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabPage2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }
    }
}

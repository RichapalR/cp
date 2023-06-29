using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class forgot_password : Form
    {
        public forgot_password()
        {
            InitializeComponent();
        }
        //SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-UUUF0RET;Initial Catalog=dball;Integrated Security=True;Pooling=True");
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ary patel\Downloads\New folder\Database1.mdf"";Integrated Security=True");

        private void forgot_password_Load(object sender, EventArgs e)
        {
            label6.Hide();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 4)
            {
                string username = textBox1.Text;
                string adhaar_no = textBox2.Text;
                string pancard = textBox3.Text;
                string con_password = textBox4.Text;
                string password = textBox5.Text;

                if (isValid())
                {
                    if (validateUserCredentials(username, adhaar_no, pancard))
                    {
                        changePassword();
                        login_page login_page = new login_page();
                        login_page.Show();

                        this.Close();
                    }
                }
                else
                {
                    label6.Text = "invalid data";
                    label6.Show();
                }
            }
            else
            {
                MessageBox.Show("Enter password more then 4 word.");
            }
        }
        private bool validateUserCredentials(string username, int adhaar_card, string pancard)
        {
            string query = "SELECT * FROM REGISTRATION WHERE username = '" + textBox1.Text + "' AND adhaar_no = '" + textBox2.Text + "' AND pancard = '" + textBox3.Text + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isValid()
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                label6.Text = "Enter all the details";
                label6.Show();
                return false;
            }
            else if(textBox4.Text != textBox5.Text)
            {
                label6.Text = "Password and Confirm Password does not match";
                label6.Show();
                return false;
            }
            else
            {
                return true;
            }
        }
      
        private void changePassword()
        {
            string update = "UPDATE REGISTRATION SET password = @password, re_password = @re_password WHERE pancard = @pancard AND adhaar_no = @adhaar_no AND username = @username;";
            
            SqlCommand up = new SqlCommand(update, cnn);
            up.Parameters.AddWithValue("@password", textBox4.Text);
            up.Parameters.AddWithValue("@re_password", textBox5.Text);
            up.Parameters.AddWithValue("@pancard", textBox3.Text);
            up.Parameters.AddWithValue("@adhaar_no", textBox2.Text);
            up.Parameters.AddWithValue("@username", textBox1.Text);
            cnn.Open();
            up.ExecuteNonQuery();

            cnn.Close();
            // do all details blank.
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";



        }
        
    }
    
}

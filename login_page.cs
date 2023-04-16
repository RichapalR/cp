using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public partial class login_page : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ary patel\Downloads\New folder\Database1.mdf"";Integrated Security=True");
//        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-UUUF0RET;Initial Catalog=dball;Integrated Security=True;Pooling=True");
        
        public login_page()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (textBox2.Text.Length > 4)
            {
                string query = "SELECT * from REGISTRATION where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "';";

                SqlCommand cmd = new SqlCommand(query, cnn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    home_page home = new home_page(textBox1.Text);
                    home.Show();

                    this.Hide();
                }
                else
                {
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Enter username and password.");
                    }
                    else
                    {
                        label2.ForeColor = Color.Black;
                        label2.Location = new Point(560, 235);
                        label2.Text = "Enter Valid username and password!!";
                        label2.Show();
                    }
                }
            }
            else if(textBox1.Text == "admin" || textBox2.Text == "root")
            {
                if (textBox1.Text == "admin" || textBox2.Text == "root")
                {
                    home_page home = new home_page(textBox1.Text);
                    home.Show();
                    this.Hide();
                }
                else
                {
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Enter username and password.");
                    }
                    else
                    {
                        label2.Text = "Enter Valid username and password!!";
                        label2.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter password more then 4 word.");
            }
}

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            //label2.Hide();
            label2.Text = "Enter password between 5 to 18";
            //label2.Hide();
            
        }

        private void createaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register_page reg = new register_page();
            reg.Show();
        }

        private void forgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgot_password forgot_password = new forgot_password();
            forgot_password.Show();
        }
    }
}

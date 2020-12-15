using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment2
{
    public partial class Login : Form
    {
        public static String ch;
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj\Desktop\assignment2\Assignment2\Assignment2\Database1.mdf;Integrated Security=True");
            con.Open();
            int count = 0;
            if(comboBoxauthorityChoice.Text == "Admin")
            {
                SqlCommand cmd = new SqlCommand("select count(*) from Admin where Name ='" + textBoxUname.Text + "' and Password='" + textBoxPassword.Text + "'", con);
                count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                
                    ch = "admin";
                    Blank b = new Blank(ch);
                    b.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("INCORRECT ID PASSWORD");
                }
            }
            else if(comboBoxauthorityChoice.Text == "Donor")
            {
                SqlCommand cmd = new SqlCommand("select count(*) from Donor where firstname ='" + textBoxUname.Text + "' and password='" + textBoxPassword.Text + "'", con);
                count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                  
                    ch = "user";
                    Blank b = new Blank(ch);
                    b.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("INCORRECT ID PASSWORD");
                }
            }
            else if(comboBoxauthorityChoice.Text == "Acceptor")
            {
                SqlCommand cmd = new SqlCommand("select count(*) from Acceptor where firstname ='" + textBoxUname.Text + "' and password='" + textBoxPassword.Text + "'", con);
                count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                    
                    ch = "user";
                    Blank b = new Blank(ch);
                    b.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("INCORRECT ID PASSWORD");
                }
            }
            else
            {
                MessageBox.Show("Please select the authority");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxauthorityChoice.Text = "";
            textBoxPassword.Text = "";
            textBoxUname.Text = "";
            comboBoxauthorityChoice.Focus();
        }
    }
}

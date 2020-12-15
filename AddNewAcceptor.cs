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
    public partial class AddNewAcceptor : Form
    {
        public static String fnamea, lnamea, passworda, agea, gendera, countrya, addressa;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gendera = "Female";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gendera = "Male";
        }

        public AddNewAcceptor()
        {
            InitializeComponent();
        }

        private void Browse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Acceptorpic.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            fnamea = firstname.Text;
            lnamea = lastname.Text;
            passworda = TextBoxPass.Text;
            agea = age.Text.ToString();
            countrya = country.Text;
            addressa = address.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj\Desktop\assignment2\Assignment2\Assignment2\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Acceptor VALUES(@firstname,@lastname,@password,@age,@gender,@country,@address)", con);
            cmd.Parameters.AddWithValue("@firstname", fnamea);
            cmd.Parameters.AddWithValue("@lastname", lnamea);
            cmd.Parameters.AddWithValue("@password", passworda);
            cmd.Parameters.AddWithValue("@age", agea);
            cmd.Parameters.AddWithValue("@gender", gendera);
            cmd.Parameters.AddWithValue("@country", countrya);
           
            cmd.Parameters.AddWithValue("@address", addressa);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Acceptor Registered Succesfully");
        }
    }
}

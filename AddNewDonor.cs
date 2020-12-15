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
    public partial class AddNewDonor : Form
    {
        public static String fnamed, lnamed, password, aged, gender, countryd, bloodgroupd, addressd;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void Browse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                Donorpic.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
           fnamed = firstname.Text;
            lnamed = lastname.Text;
            password = TextBoxPass.Text;
            aged = age.Text.ToString();
            countryd = country.Text;
            bloodgroupd = comboBoxBloodGrup.Text;
            addressd = address.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj\Desktop\assignment2\Assignment2\Assignment2\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Donor VALUES(@firstname,@lastname,@password,@age,@gender,@country,@bloodgroup,@address)",con);
            cmd.Parameters.AddWithValue("@firstname", fnamed);
            cmd.Parameters.AddWithValue("@lastname", lnamed);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@age", aged);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@country", countryd);
            cmd.Parameters.AddWithValue("@bloodgroup", bloodgroupd);
            cmd.Parameters.AddWithValue("@address", addressd);
            

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Donor Registered Succesfully");
        }
    }
}

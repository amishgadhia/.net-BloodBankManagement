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
    public partial class AddNewCamp : Form
    {
        private static String campname, campdate, campstate, campaddress;
        public AddNewCamp()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            campname = textBoxCampName.Text;
            campdate = dateTimePickerCampDate.Text;
            campstate = comboBoxCampState.Text;
            campaddress = textBoxCampAddress.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj\Desktop\assignment2\Assignment2\Assignment2\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO BloodBankCamp VALUES(@CampName,@Date,@State,@Address)", con);
            cmd.Parameters.AddWithValue("@CampName", campname);
            cmd.Parameters.AddWithValue("@Date", campdate);
            cmd.Parameters.AddWithValue("@State", campstate);
            cmd.Parameters.AddWithValue("@Address", campaddress);

            cmd.ExecuteNonQuery();
            MessageBox.Show("New Camp Added Succesfully");
        }
    }
}

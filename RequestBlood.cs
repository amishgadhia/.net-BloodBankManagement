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
    public partial class RequestBlood : Form
    {
        private static String bloodAcceptor, bloodgroup, bloodunit;
        public RequestBlood()
        {
            InitializeComponent();
        }

        private void buttonRequestSubmit_Click(object sender, EventArgs e)
        {
            bloodAcceptor = textBoxName.Text;
            bloodgroup = comboBoxBloodGroup.Text;
            bloodunit = textBoxBloodUnit.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj\Desktop\assignment2\Assignment2\Assignment2\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO BloodAcceptor VALUES(@AcceptorName,@BloodGroup,@BloodUnits)", con);
            cmd.Parameters.AddWithValue("@AcceptorName", bloodAcceptor);
            cmd.Parameters.AddWithValue("@BloodGroup", bloodgroup);
            cmd.Parameters.AddWithValue("@BloodUnits", bloodunit);

            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("UPDATE BloodBank SET BloodUnits = BloodUnits -'" + bloodunit + "' WHERE BloodGroup = '" + bloodgroup + "'", con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Blood Acceptance Request Succesfully");
        }
    }
}

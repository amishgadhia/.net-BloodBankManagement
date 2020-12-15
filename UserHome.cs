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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void updateuser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj\Desktop\assignment2\Assignment2\Assignment2\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "A+");
            lblApositiveCount.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "O+");
            lblOpositiveCount.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "O-");
            lblOnegativecount.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "A-");
            lblAnegativeCount.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "B+");
            lblBpositiveCount.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "B-");
            lblBnegativeCount.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "AB-");
            lblABnegativeCount.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "AB+");
            lblABpositiveCount.Text = Convert.ToString(cmd.ExecuteScalar());



            con.Close();
        }

        private void logoutuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ln = new Login();
            ln.Show();
            
        }

        private void donateBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonateBlood db = new DonateBlood();
            db.MdiParent = Blank.ActiveForm;
            db.Show();
        }

        private void viewAllDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllDonor viewad = new ViewAllDonor();
            viewad.MdiParent = Blank.ActiveForm;
            viewad.Show();
        }

        private void requestBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestBlood rb = new RequestBlood();
            rb.MdiParent = Blank.ActiveForm;
            rb.Show();
        }

        private void viewAllAcceptorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllAcceptor vaa = new ViewAllAcceptor();
            vaa.MdiParent = Blank.ActiveForm;
            vaa.Show();
        }

        private void viewAllCampsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllCamps vac = new ViewAllCamps();
            vac.MdiParent = Blank.ActiveForm;
            vac.Show();
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocateBloodBank lbb = new LocateBloodBank();
            lbb.MdiParent = Blank.ActiveForm;
            lbb.Show();
        }
    }
}

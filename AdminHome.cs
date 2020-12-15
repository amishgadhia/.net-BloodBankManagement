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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void updateadmin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj\Desktop\assignment2\Assignment2\Assignment2\Database1.mdf;Integrated Security=True");
            con.Open();
           
            SqlCommand cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup",con);
            cmd.Parameters.AddWithValue("@bloodgroup", "A+");
            lblApositiveCounta.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "O+");
            lblOpositiveCounta.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "O-");
            lblOnegativecounta.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "A-");
            lblAnegativeCounta.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "B+");
            lblBpositiveCounta.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "B-");
            lblBnegativeCounta.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "AB-");
            lblABnegativeCounta.Text = Convert.ToString(cmd.ExecuteScalar());

            cmd = new SqlCommand("SELECT BloodUnits FROM BloodBank WHERE BloodGroup = @bloodgroup", con);
            cmd.Parameters.AddWithValue("@bloodgroup", "AB+");
            lblABpositiveCounta.Text = Convert.ToString(cmd.ExecuteScalar());



            con.Close();
        }

        private void logoutadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ln = new Login();

            ln.Show();
           
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor adnew = new AddNewDonor();
            adnew.MdiParent = Blank.ActiveForm;
            adnew.Show();
        }

        private void viewAllDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllDonor viewad = new ViewAllDonor();
            viewad.MdiParent = Blank.ActiveForm;
            viewad.Show();
        }

        private void addNewAcceptorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAcceptor aanew = new AddNewAcceptor();
            aanew.MdiParent = Blank.ActiveForm;
            aanew.Show();
        }

        private void viewAllAcceptorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllAcceptor viewaa = new ViewAllAcceptor();
            viewaa.MdiParent = Blank.ActiveForm;
            viewaa.Show();
        }

        private void addNewCampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCamp newcamp = new AddNewCamp();
            newcamp.MdiParent = Blank.ActiveForm;
            newcamp.Show();
        }

        private void viewAllCampsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllCamps vewacamp = new ViewAllCamps();
            vewacamp.MdiParent = Blank.ActiveForm;
            vewacamp.Show();
        }
    }
}

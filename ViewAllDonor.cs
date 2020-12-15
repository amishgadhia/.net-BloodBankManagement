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
    public partial class ViewAllDonor : Form
    {
        public ViewAllDonor()
        {
            InitializeComponent();
        }

        private void ViewAllDonor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.BloodDonator' table. You can move, or remove it, as needed.
            this.bloodDonatorTableAdapter1.Fill(this.database1DataSet1.BloodDonator);
            // TODO: This line of code loads data into the 'database1DataSet.BloodDonator' table. You can move, or remove it, as needed.
            //this.bloodDonatorTableAdapter.Fill(this.database1DataSet.BloodDonator);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj\Desktop\assignment2\Assignment2\Assignment2\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM BloodDonator",con);
            SqlCommandBuilder build = new SqlCommandBuilder(ad);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridViewDonor.DataSource = dt;
            con.Close();


        }

        private void dataGridViewDonor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

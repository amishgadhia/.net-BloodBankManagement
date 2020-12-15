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
    public partial class ViewAllCamps : Form
    {
        public ViewAllCamps()
        {
            InitializeComponent();
        }

        private void ViewAllCamps_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj\Desktop\assignment2\Assignment2\Assignment2\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM BloodBankCamp", con);
            SqlCommandBuilder build = new SqlCommandBuilder(ad);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridViewCamps.DataSource = dt;
            con.Close();
        }
    }
}

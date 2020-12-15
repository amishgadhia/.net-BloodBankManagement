using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class LocateBloodBank : Form
    {
        public LocateBloodBank()
        {
            InitializeComponent();
        }

        private void buttonshow_Click(object sender, EventArgs e)
        {
            if(comboBoxStates.Text == "Gujarat")
            {
                lblbloodbankname.Text = "Jivan Jyot";
                lblmanagername.Text = "Jaldeep Ramani";
                lblmonum.Text = "8686457921";
                lbladdress.Text = "Raiya Road, Rajkot 360007";
            }
            else if(comboBoxStates.Text == "Maharashtra")
            {
                lblbloodbankname.Text = "Rakt Jivan";
                lblmanagername.Text = "Harsh Jivani";
                lblmonum.Text = "9966447921";
                lbladdress.Text = "Mohhamad Road, Navi Mumbai 458864";
            }
            else
            {
                MessageBox.Show("Please Select State");
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrintDetails(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(comboBoxStates.Text, new Font("Comic Sans MS", 16, FontStyle.Bold), Brushes.Black, new Point(100, 200));
            e.Graphics.DrawString(lblbloodbankname.Text, new Font("Comic Sans MS", 16, FontStyle.Bold), Brushes.Black, new Point(100, 300));
            e.Graphics.DrawString(lblmanagername.Text, new Font("Comic Sans MS", 16, FontStyle.Bold), Brushes.Black, new Point(100, 400));
            e.Graphics.DrawString(lblmonum.Text, new Font("Comic Sans MS", 16, FontStyle.Bold), Brushes.Black, new Point(100, 500));
            e.Graphics.DrawString(lbladdress.Text, new Font("Comic Sans MS", 16, FontStyle.Bold), Brushes.Black, new Point(100, 600));
        }
    }
}

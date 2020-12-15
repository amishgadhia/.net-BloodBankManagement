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
    public partial class Blank : Form
    {
        public static String ch;
        public Blank(String choice)
        {
            ch = choice;
            InitializeComponent();
        }

        private void Blank_Load(object sender, EventArgs e)
        {
            if (ch == "admin")
            {
                
                AdminHome ah = new AdminHome();
                ah.MdiParent = this;
                ah.Show();
            }
            else if(ch == "user")
            {
                UserHome uh = new UserHome();
                uh.MdiParent = this;
                uh.Show();
            }
            else if(ch == "login")
            {
                Login ln = new Login();
                ln.MdiParent = this;
                ln.Show();
            }
        }
    }
}

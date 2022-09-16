using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansionApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "smashLesh" && txtPassword.Text == "Furkan+2003+")
            {
                new MainForm().Show();
            }
            else
            {
                MessageBox.Show("User Name or Password incorrect");
            }
        }
    }
}

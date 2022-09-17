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
using System.Data.Sql;

namespace PansionApplication
{
    public partial class AdminPanelKayit : Form
    {
        public AdminPanelKayit()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=Hotelİstanbul;Integrated Security=True");

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand command =new SqlCommand("insert into AdminLogin (UserName,UserPassword) " +
                "Values('"+txtUserName.Text.Trim()+"','"+txtUserPassword.Text.Trim()+"')",Connection);
            command.ExecuteNonQuery();
            Connection.Close();

            MessageBox.Show("Registration completed successfully");
        }
    }
}

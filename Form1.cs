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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=Hotelİstanbul;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            Connection.Open();
            string sorgu = "select *from AdminLogin where UserName=@UserName AND UserPassword=@UserPassword";
            SqlParameter pr1 = new SqlParameter("UserName", txtUserName.Text);
            SqlParameter pr2=new SqlParameter("UserPassword",txtPassword.Text);

            SqlCommand sqlCommand = new SqlCommand(sorgu,Connection);

            sqlCommand.Parameters.Add(pr1);
            sqlCommand.Parameters.Add(pr2);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(dt);

            if (dt.Rows.Count>0)
            {
                new MainForm().Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

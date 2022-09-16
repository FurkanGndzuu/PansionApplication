using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansionApplication
{
    public partial class MüsteriBilgileri : Form
    {
        public MüsteriBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection Connection =new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=Hotelİstanbul;Integrated Security=True");

        private void Veriler()
        {
            Connection.Open();
          SqlCommand command = new SqlCommand("select *from Tbl_AddCustomer",Connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem add=new ListViewItem();

                add.Text = reader["CustomerId"].ToString();
                add.SubItems.Add(reader["CustomerName"].ToString());
                add.SubItems.Add(reader["CustomerSurname"].ToString());
                add.SubItems.Add(reader["CustomerPhone"].ToString());
                add.SubItems.Add(reader["CustomerEmail"].ToString());
                add.SubItems.Add(reader["CustomerTc"].ToString());
                add.SubItems.Add(reader["CustomerRoomNo"].ToString());
                add.SubItems.Add(reader["CustomerRoomPrice"].ToString());
                add.SubItems.Add(reader["CustomerLoginHistory"].ToString());
                add.SubItems.Add(reader["CustomerExitHistory"].ToString());

                listView1.Items.Add(add);
                
            }

            Connection.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veriler();
        }
    }
}

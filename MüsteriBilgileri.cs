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
            listView1.Items.Clear();
            
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

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            mtbPhone.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtTcNo.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtRoomNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtPrice.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DateLoginPicker.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DateExitPicker.Text = listView1.SelectedItems[0].SubItems[9].Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand("delete from Tbl_AddCustomer where" +
                " CustomerId=(" + id + ")", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
            Veriler();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            txtMail.Clear();
            mtbPhone.Clear();
            txtPrice.Clear();
            txtRoomNo.Clear();
            txtTcNo.Clear();
            DateLoginPicker.Text = "";
            DateExitPicker.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand("Update Tbl_AddCustomer set CustomerName='"+txtName.Text+"' , CustomerSurname='"+txtSurname.Text+"', CustomerPhone ='"+mtbPhone.Text+"', CustomerEmail ='"+txtMail.Text+"',CustomerRoomNo='"+txtRoomNo.Text+"',CustomerRoomPrice='"+txtPrice.Text+"',CustomerLoginHistory='"+DateLoginPicker.Value.ToString("yyyy-MM-dd")+"',CustomerExitHistory='"+DateExitPicker.Value.ToString("yyyy-MM-dd")+"' where CustomerId="+id+"",Connection);
            command.ExecuteNonQuery();
            Connection.Close();
            Veriler();
        }
    }
}

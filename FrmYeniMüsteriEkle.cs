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
using System.Data;

namespace PansionApplication
{
    public partial class FrmYeniMüsteriEkle : Form
    {
        public FrmYeniMüsteriEkle()
        {
            InitializeComponent();
        }



        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=Hotelİstanbul;Integrated Security=True");


        private void btn101_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "101";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda101 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text+"')" , Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "102";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda102 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "103";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda103 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "104";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda104 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "105";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda105 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "106";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda106 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "107";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda107 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "108";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda108 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "109";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda109 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn110_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "110";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda110 (CustomeName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn111_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "111";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda111 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn112_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "112";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda112 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn113_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "113";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda113 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn114_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "114";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda114 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn115_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "115";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda115 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn116_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "116";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda116 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn117_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "117";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda117 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn118_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "118";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda118 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn119_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "119";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda119 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btn120_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "120";
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Oda120 (CustomerName,CustomerSurname) Values('" + txtName.Text + "','" + txtSurname.Text + "')", Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button is showing you empty rooms");
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button is showing you full rooms");
        }

        private void DateExitPicker_ValueChanged(object sender, EventArgs e)
        {
            int Price;

            DateTime LoginTime= Convert.ToDateTime(DateLoginPicker.Value);
            DateTime ExitTime=Convert.ToDateTime(DateExitPicker.Value);

            TimeSpan Result;

            Result = ExitTime - LoginTime;

            Price=Convert.ToInt32(Result.TotalDays)*50;

            txtPrice.Text = Price.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Connection.Open();

            SqlCommand command = new SqlCommand("insert into Tbl_AddCustomer" +
                " (CustomerName,CustomerSurname,CustomerPhone,CustomerEmail," +
                "CustomerTc,CustomerRoomNo,CustomerRoomPrice,CustomerLoginHistory," +
                "CustomerExitHistory) Values('" + txtName.Text + "','" + txtSurname.Text + "','"+
                mtbPhone.Text+"','"+txtMail.Text+"','"+txtTcNo.Text+"','"+txtRoomNo.Text+"','"+
                txtPrice.Text+"','"+DateLoginPicker.Value.ToString("yyyy-MM-dd")+
                "','"+DateExitPicker.Value.ToString("yyyy-MM-dd") +"')",Connection);

            

            command.ExecuteNonQuery();

            Connection.Close();

            MessageBox.Show("Customer Added");
        }

        private void FrmYeniMüsteriEkle_Load(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand command1 = new SqlCommand("select *from Oda101", Connection);
            SqlDataReader reader1 = command1.ExecuteReader();

            while (reader1.Read())
            {
                btn101.Text = reader1["CustomerName"].ToString() + " " + reader1["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
            }


            Connection.Open();
            SqlCommand command2 = new SqlCommand("select *from Oda102", Connection);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                btn102.Text = reader2["CustomerName"].ToString() + " " + reader2["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
            }
            Connection.Open();
            SqlCommand command3 = new SqlCommand("select *from Oda102", Connection);
            SqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                btn103.Text = reader3["CustomerName"].ToString() + " " + reader3["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command4 = new SqlCommand("select *from Oda104", Connection);
            SqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {
                btn104.Text = reader4["CustomerName"].ToString() + " " + reader4["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command5 = new SqlCommand("select *from Oda105", Connection);
            SqlDataReader reader5 = command5.ExecuteReader();

            while (reader5.Read())
            {
                btn105.Text = reader5["CustomerName"].ToString() + " " + reader5["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command6 = new SqlCommand("select *from Oda106", Connection);
            SqlDataReader reader6 = command6.ExecuteReader();

            while (reader6.Read())
            {
                btn106.Text = reader6["CustomerName"].ToString() + " " + reader6["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command7 = new SqlCommand("select *from Oda107", Connection);
            SqlDataReader reader7 = command7.ExecuteReader();

            while (reader7.Read())
            {
                btn107.Text = reader7["CustomerName"].ToString() + " " + reader7["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command8 = new SqlCommand("select *from Oda108", Connection);
            SqlDataReader reader8 = command8.ExecuteReader();

            while (reader8.Read())
            {
                btn108.Text = reader8["CustomerName"].ToString() + " " + reader8["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command9 = new SqlCommand("select *from Oda109", Connection);
            SqlDataReader reader9 = command9.ExecuteReader();

            while (reader9.Read())
            {
                btn109.Text = reader9["CustomerName"].ToString() + " " + reader9["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command10 = new SqlCommand("select *from Oda110", Connection);
            SqlDataReader reader10 = command10.ExecuteReader();

            while (reader10.Read())
            {
                btn110.Text = reader10["CustomeName"].ToString() + " " + reader10["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn110.Text != "110")
            {
                btn110.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command11 = new SqlCommand("select *from Oda111", Connection);
            SqlDataReader reader11 = command11.ExecuteReader();

            while (reader11.Read())
            {
                btn111.Text = reader11["CustomerName"].ToString() + " " + reader11["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn111.Text != "111")
            {
                btn111.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command12 = new SqlCommand("select *from Oda112", Connection);
            SqlDataReader reader12 = command12.ExecuteReader();

            while (reader12.Read())
            {
                btn112.Text = reader12["CustomerName"].ToString() + " " + reader12["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn112.Text != "112")
            {
                btn112.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command13 = new SqlCommand("select *from Oda113", Connection);
            SqlDataReader reader13 = command13.ExecuteReader();

            while (reader13.Read())
            {
                btn113.Text = reader13["CustomerName"].ToString() + " " + reader13["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn113.Text != "113")
            {
                btn113.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command14 = new SqlCommand("select *from Oda114", Connection);
            SqlDataReader reader14 = command14.ExecuteReader();

            while (reader14.Read())
            {
                btn114.Text = reader14["CustomerName"].ToString() + " " + reader14["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn114.Text != "114")
            {
                btn114.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command15 = new SqlCommand("select *from Oda115", Connection);
            SqlDataReader reader15 = command15.ExecuteReader();

            while (reader15.Read())
            {
                btn115.Text = reader15["CustomerName"].ToString() + " " + reader15["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn115.Text != "115")
            {
                btn115.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command16 = new SqlCommand("select *from Oda116", Connection);
            SqlDataReader reader16 = command16.ExecuteReader();

            while (reader16.Read())
            {
                btn116.Text = reader16["CustomerName"].ToString() + " " + reader16["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn116.Text != "116")
            {
                btn116.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command17 = new SqlCommand("select *from Oda117", Connection);
            SqlDataReader reader17 = command17.ExecuteReader();

            while (reader17.Read())
            {
                btn117.Text = reader17["CustomerName"].ToString() + " " + reader17["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn117.Text != "117")
            {
                btn117.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command18 = new SqlCommand("select *from Oda118", Connection);
            SqlDataReader reader18 = command18.ExecuteReader();

            while (reader18.Read())
            {
                btn118.Text = reader18["CustomerName"].ToString() + " " + reader18["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn118.Text != "118")
            {
                btn118.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command19 = new SqlCommand("select *from Oda119", Connection);
            SqlDataReader reader19 = command19.ExecuteReader();

            while (reader19.Read())
            {
                btn119.Text = reader19["CustomerName"].ToString() + " " + reader19["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn119.Text != "119")
            {
                btn119.BackColor = Color.Red;
            }

            Connection.Open();
            SqlCommand command20 = new SqlCommand("select *from Oda120", Connection);
            SqlDataReader reader20 = command20.ExecuteReader();

            while (reader20.Read())
            {
                btn120.Text = reader20["CustomerName"].ToString() + " " + reader20["CustomerSurname"].ToString();
            }

            Connection.Close();

            if (btn120.Text != "120")
            {
                btn120.BackColor = Color.Red;
            }
        }
    }
}

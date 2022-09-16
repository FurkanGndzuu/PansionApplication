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
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "102";
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "103";
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "104";
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "105";
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "106";
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "107";
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "108";
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "109";
        }

        private void btn110_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "110";
        }

        private void btn111_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "111";
        }

        private void btn112_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "112";
        }

        private void btn113_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "113";
        }

        private void btn114_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "114";
        }

        private void btn115_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "115";
        }

        private void btn116_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "116";
        }

        private void btn117_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "117";
        }

        private void btn118_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "118";
        }

        private void btn119_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "119";
        }

        private void btn120_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "120";
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

        }
    }
}

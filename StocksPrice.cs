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
    public partial class StocksPrice : Form
    {
        public StocksPrice()
        {
            InitializeComponent();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=Hotelİstanbul;Integrated Security=True");


        private void btnSave_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand("insert into Tbl_StocksPrices" +
                " (Food,Beverage,Snacks) Values('" + Convert.ToInt32(txtFood.Text) + "','" +
                Convert.ToInt32(txtBverage.Text) + "','" + Convert.ToInt32(txtSnacks.Text) + "')", Connection);

            command.ExecuteNonQuery();
            Connection.Close();

            MessageBox.Show("Giderler Kaydedildi");
        }

        private void StocksPrice_Load(object sender, EventArgs e)
        {
            Veriler();
        }

        private void Veriler()
        {
            Connection.Open();

            SqlCommand command = new SqlCommand("Select *from Tbl_StocksPrices", Connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();

                add.Text = reader["Food"].ToString();
                add.SubItems.Add(reader["Beverage"].ToString());
                add.SubItems.Add(reader["Snacks"].ToString());
                listView1.Items.Add(add);

            }

            Connection.Close();
        }
    }
}

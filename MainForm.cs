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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            new FrmYeniMüsteriEkle().Show();
        }

        private void BtnRooms_Click(object sender, EventArgs e)
        {
            new FrmRooms().Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new MüsteriBilgileri().Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We created the company in 2022 will expand...");
        }

        private void btnCustomerMesages_Click(object sender, EventArgs e)
        {
            new AdminPanelKayit().Show();   
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            new StocksPrice().Show();
        }
    }
}

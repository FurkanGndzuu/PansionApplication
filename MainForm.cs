﻿using System;
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
    }
}
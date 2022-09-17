namespace PansionApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.BtnRooms = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnEmployeeSalary = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnCustomerMessages = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(41, 39);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(141, 114);
            this.btnAdminLogin.TabIndex = 0;
            this.btnAdminLogin.Text = "Admin Login Panel";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(268, 39);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(141, 114);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // BtnRooms
            // 
            this.BtnRooms.Location = new System.Drawing.Point(513, 39);
            this.BtnRooms.Name = "BtnRooms";
            this.BtnRooms.Size = new System.Drawing.Size(141, 114);
            this.BtnRooms.TabIndex = 2;
            this.BtnRooms.Text = "Rooms";
            this.BtnRooms.UseVisualStyleBackColor = true;
            this.BtnRooms.Click += new System.EventHandler(this.BtnRooms_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 205);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(756, 39);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(141, 114);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customer Information Show";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnEmployeeSalary
            // 
            this.btnEmployeeSalary.Location = new System.Drawing.Point(41, 225);
            this.btnEmployeeSalary.Name = "btnEmployeeSalary";
            this.btnEmployeeSalary.Size = new System.Drawing.Size(141, 114);
            this.btnEmployeeSalary.TabIndex = 5;
            this.btnEmployeeSalary.Text = "Employee Salary";
            this.btnEmployeeSalary.UseVisualStyleBackColor = true;
            // 
            // btnStocks
            // 
            this.btnStocks.Location = new System.Drawing.Point(268, 225);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(141, 114);
            this.btnStocks.TabIndex = 6;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.UseVisualStyleBackColor = true;
            // 
            // btnCustomerMessages
            // 
            this.btnCustomerMessages.Location = new System.Drawing.Point(513, 225);
            this.btnCustomerMessages.Name = "btnCustomerMessages";
            this.btnCustomerMessages.Size = new System.Drawing.Size(141, 114);
            this.btnCustomerMessages.TabIndex = 7;
            this.btnCustomerMessages.Text = "Admin Register";
            this.btnCustomerMessages.UseVisualStyleBackColor = true;
            this.btnCustomerMessages.Click += new System.EventHandler(this.btnCustomerMesages_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(756, 225);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(141, 114);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(909, 700);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnCustomerMessages);
            this.Controls.Add(this.btnStocks);
            this.Controls.Add(this.btnEmployeeSalary);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnRooms);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnAdminLogin);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button BtnRooms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnEmployeeSalary;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnCustomerMessages;
        private System.Windows.Forms.Button btnAbout;
    }
}
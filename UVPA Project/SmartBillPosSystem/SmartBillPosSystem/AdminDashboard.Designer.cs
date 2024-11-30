namespace SmartBillPosSystem
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.ButtonUsers = new System.Windows.Forms.Button();
            this.ButtonSalesReport = new System.Windows.Forms.Button();
            this.ButtonManageProduct = new System.Windows.Forms.Button();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.ButtonDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalOrders = new System.Windows.Forms.Label();
            this.totalSales = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCustomers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(170)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.ButtonLogout);
            this.panel1.Controls.Add(this.ButtonUsers);
            this.panel1.Controls.Add(this.ButtonSalesReport);
            this.panel1.Controls.Add(this.ButtonManageProduct);
            this.panel1.Controls.Add(this.ButtonAddProduct);
            this.panel1.Controls.Add(this.ButtonDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 616);
            this.panel1.TabIndex = 2;
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogout.Location = new System.Drawing.Point(31, 526);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(234, 47);
            this.ButtonLogout.TabIndex = 9;
            this.ButtonLogout.Text = "Back To Login";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUsers.Location = new System.Drawing.Point(32, 473);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.Size = new System.Drawing.Size(234, 47);
            this.ButtonUsers.TabIndex = 6;
            this.ButtonUsers.Text = "Manage Users";
            this.ButtonUsers.UseVisualStyleBackColor = true;
            this.ButtonUsers.Click += new System.EventHandler(this.ButtonUsers_Click);
            // 
            // ButtonSalesReport
            // 
            this.ButtonSalesReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalesReport.Location = new System.Drawing.Point(31, 420);
            this.ButtonSalesReport.Name = "ButtonSalesReport";
            this.ButtonSalesReport.Size = new System.Drawing.Size(234, 47);
            this.ButtonSalesReport.TabIndex = 5;
            this.ButtonSalesReport.Text = "Sales Report";
            this.ButtonSalesReport.UseVisualStyleBackColor = true;
            this.ButtonSalesReport.Click += new System.EventHandler(this.ButtonSalesReport_Click);
            // 
            // ButtonManageProduct
            // 
            this.ButtonManageProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonManageProduct.Location = new System.Drawing.Point(32, 367);
            this.ButtonManageProduct.Name = "ButtonManageProduct";
            this.ButtonManageProduct.Size = new System.Drawing.Size(234, 47);
            this.ButtonManageProduct.TabIndex = 3;
            this.ButtonManageProduct.Text = "Manage Product";
            this.ButtonManageProduct.UseVisualStyleBackColor = true;
            this.ButtonManageProduct.Click += new System.EventHandler(this.ButtonManageProduct_Click);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddProduct.Location = new System.Drawing.Point(31, 314);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(234, 47);
            this.ButtonAddProduct.TabIndex = 2;
            this.ButtonAddProduct.Text = "Add Product";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // ButtonDashboard
            // 
            this.ButtonDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDashboard.Location = new System.Drawing.Point(32, 261);
            this.ButtonDashboard.Name = "ButtonDashboard";
            this.ButtonDashboard.Size = new System.Drawing.Size(234, 47);
            this.ButtonDashboard.TabIndex = 1;
            this.ButtonDashboard.Text = "Dashboard";
            this.ButtonDashboard.UseVisualStyleBackColor = true;
            this.ButtonDashboard.Click += new System.EventHandler(this.ButtonDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartBillPosSystem.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(32, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Orders";
            // 
            // totalOrders
            // 
            this.totalOrders.AutoSize = true;
            this.totalOrders.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.totalOrders.Location = new System.Drawing.Point(84, 52);
            this.totalOrders.Name = "totalOrders";
            this.totalOrders.Size = new System.Drawing.Size(27, 31);
            this.totalOrders.TabIndex = 4;
            this.totalOrders.Text = "0";
            this.totalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalOrders.Click += new System.EventHandler(this.totalOrders_Click);
            // 
            // totalSales
            // 
            this.totalSales.AutoSize = true;
            this.totalSales.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.totalSales.Location = new System.Drawing.Point(89, 52);
            this.totalSales.Name = "totalSales";
            this.totalSales.Size = new System.Drawing.Size(27, 31);
            this.totalSales.TabIndex = 6;
            this.totalSales.Text = "0";
            this.totalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalSales.Click += new System.EventHandler(this.totalSales_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Sales";
            // 
            // totalCustomers
            // 
            this.totalCustomers.AutoSize = true;
            this.totalCustomers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.totalCustomers.Location = new System.Drawing.Point(83, 52);
            this.totalCustomers.Name = "totalCustomers";
            this.totalCustomers.Size = new System.Drawing.Size(27, 31);
            this.totalCustomers.TabIndex = 8;
            this.totalCustomers.Text = "0";
            this.totalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalCustomers.Click += new System.EventHandler(this.totalCustomers_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Customers";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(170)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.totalOrders);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(326, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Controls.Add(this.totalSales);
            this.panel3.Controls.Add(this.label3);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(552, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.totalCustomers);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(777, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 11;
            // 
            // AdminDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Button ButtonUsers;
        private System.Windows.Forms.Button ButtonSalesReport;
        private System.Windows.Forms.Button ButtonManageProduct;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.Button ButtonDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalOrders;
        private System.Windows.Forms.Label totalSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalCustomers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
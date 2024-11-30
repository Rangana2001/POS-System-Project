namespace SmartBillPosSystem
{
    partial class CashierDashboard
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagex = new System.Windows.Forms.DataGridViewImageColumn();
            this.productImagePathFromDb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartbillDataSet1 = new SmartBillPosSystem.smartbillDataSet1();
            this.ButtonSnacks = new System.Windows.Forms.RadioButton();
            this.ButtonDesserts = new System.Windows.Forms.RadioButton();
            this.ButtonPackages = new System.Windows.Forms.RadioButton();
            this.ButtonFoods = new System.Windows.Forms.RadioButton();
            this.ButtonDrinks = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerMobileInput = new System.Windows.Forms.TextBox();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.totalAmountValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOrderProcess = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.productsTableAdapter = new SmartBillPosSystem.smartbillDataSet1TableAdapters.productsTableAdapter();
            this.btnOrderCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartbillDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1232, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(170)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello Welcome!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.ButtonSnacks);
            this.panel2.Controls.Add(this.ButtonDesserts);
            this.panel2.Controls.Add(this.ButtonPackages);
            this.panel2.Controls.Add(this.ButtonFoods);
            this.panel2.Controls.Add(this.ButtonDrinks);
            this.panel2.Location = new System.Drawing.Point(37, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 608);
            this.panel2.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.imagex,
            this.productImagePathFromDb,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(689, 559);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "Product ID";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // imagex
            // 
            this.imagex.FillWeight = 6F;
            this.imagex.HeaderText = "Image";
            this.imagex.MinimumWidth = 100;
            this.imagex.Name = "imagex";
            this.imagex.ReadOnly = true;
            // 
            // productImagePathFromDb
            // 
            this.productImagePathFromDb.DataPropertyName = "image";
            this.productImagePathFromDb.HeaderText = "Image";
            this.productImagePathFromDb.MinimumWidth = 6;
            this.productImagePathFromDb.Name = "productImagePathFromDb";
            this.productImagePathFromDb.ReadOnly = true;
            this.productImagePathFromDb.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.smartbillDataSet1;
            // 
            // smartbillDataSet1
            // 
            this.smartbillDataSet1.DataSetName = "smartbillDataSet1";
            this.smartbillDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ButtonSnacks
            // 
            this.ButtonSnacks.AutoSize = true;
            this.ButtonSnacks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonSnacks.Location = new System.Drawing.Point(283, 7);
            this.ButtonSnacks.Name = "ButtonSnacks";
            this.ButtonSnacks.Size = new System.Drawing.Size(92, 32);
            this.ButtonSnacks.TabIndex = 13;
            this.ButtonSnacks.TabStop = true;
            this.ButtonSnacks.Text = "Snacks";
            this.ButtonSnacks.UseVisualStyleBackColor = true;
            this.ButtonSnacks.CheckedChanged += new System.EventHandler(this.ButtonSnacks_CheckedChanged);
            // 
            // ButtonDesserts
            // 
            this.ButtonDesserts.AutoSize = true;
            this.ButtonDesserts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonDesserts.Location = new System.Drawing.Point(421, 7);
            this.ButtonDesserts.Name = "ButtonDesserts";
            this.ButtonDesserts.Size = new System.Drawing.Size(105, 32);
            this.ButtonDesserts.TabIndex = 14;
            this.ButtonDesserts.TabStop = true;
            this.ButtonDesserts.Text = "Desserts";
            this.ButtonDesserts.UseVisualStyleBackColor = true;
            this.ButtonDesserts.CheckedChanged += new System.EventHandler(this.ButtonDesserts_CheckedChanged);
            // 
            // ButtonPackages
            // 
            this.ButtonPackages.AutoSize = true;
            this.ButtonPackages.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonPackages.Location = new System.Drawing.Point(577, 7);
            this.ButtonPackages.Name = "ButtonPackages";
            this.ButtonPackages.Size = new System.Drawing.Size(112, 32);
            this.ButtonPackages.TabIndex = 15;
            this.ButtonPackages.TabStop = true;
            this.ButtonPackages.Text = "Packages";
            this.ButtonPackages.UseVisualStyleBackColor = true;
            this.ButtonPackages.CheckedChanged += new System.EventHandler(this.ButtonPackages_CheckedChanged_1);
            // 
            // ButtonFoods
            // 
            this.ButtonFoods.AutoSize = true;
            this.ButtonFoods.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFoods.Location = new System.Drawing.Point(13, 7);
            this.ButtonFoods.Name = "ButtonFoods";
            this.ButtonFoods.Size = new System.Drawing.Size(87, 32);
            this.ButtonFoods.TabIndex = 11;
            this.ButtonFoods.TabStop = true;
            this.ButtonFoods.Text = "Foods";
            this.ButtonFoods.UseVisualStyleBackColor = true;
            this.ButtonFoods.CheckedChanged += new System.EventHandler(this.ButtonFoods_CheckedChanged);
            // 
            // ButtonDrinks
            // 
            this.ButtonDrinks.AutoSize = true;
            this.ButtonDrinks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonDrinks.Location = new System.Drawing.Point(136, 7);
            this.ButtonDrinks.Name = "ButtonDrinks";
            this.ButtonDrinks.Size = new System.Drawing.Size(88, 32);
            this.ButtonDrinks.TabIndex = 12;
            this.ButtonDrinks.TabStop = true;
            this.ButtonDrinks.Text = "Drinks";
            this.ButtonDrinks.UseVisualStyleBackColor = true;
            this.ButtonDrinks.CheckedChanged += new System.EventHandler(this.ButtonDrinks_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnOrderCancel);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.customerMobileInput);
            this.panel3.Controls.Add(this.customerNameInput);
            this.panel3.Controls.Add(this.totalAmountValue);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.buttonOrderProcess);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(734, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 608);
            this.panel3.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label5.Location = new System.Drawing.Point(284, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label4.Location = new System.Drawing.Point(3, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer Name";
            // 
            // customerMobileInput
            // 
            this.customerMobileInput.Location = new System.Drawing.Point(287, 508);
            this.customerMobileInput.Multiline = true;
            this.customerMobileInput.Name = "customerMobileInput";
            this.customerMobileInput.Size = new System.Drawing.Size(242, 33);
            this.customerMobileInput.TabIndex = 6;
            // 
            // customerNameInput
            // 
            this.customerNameInput.Location = new System.Drawing.Point(7, 508);
            this.customerNameInput.Multiline = true;
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(242, 33);
            this.customerNameInput.TabIndex = 5;
            this.customerNameInput.TextChanged += new System.EventHandler(this.customerNameInput_TextChanged);
            // 
            // totalAmountValue
            // 
            this.totalAmountValue.AutoSize = true;
            this.totalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.totalAmountValue.Location = new System.Drawing.Point(463, 428);
            this.totalAmountValue.Name = "totalAmountValue";
            this.totalAmountValue.Size = new System.Drawing.Size(58, 29);
            this.totalAmountValue.TabIndex = 4;
            this.totalAmountValue.Text = "0.00";
            this.totalAmountValue.Click += new System.EventHandler(this.totalAmountValue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(272, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Amount:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonOrderProcess
            // 
            this.buttonOrderProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(170)))), ((int)(((byte)(75)))));
            this.buttonOrderProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrderProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderProcess.Location = new System.Drawing.Point(287, 547);
            this.buttonOrderProcess.Name = "buttonOrderProcess";
            this.buttonOrderProcess.Size = new System.Drawing.Size(242, 46);
            this.buttonOrderProcess.TabIndex = 2;
            this.buttonOrderProcess.Text = "Order Process";
            this.buttonOrderProcess.UseVisualStyleBackColor = false;
            this.buttonOrderProcess.Click += new System.EventHandler(this.buttonOrderProcess_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.quantity,
            this.amount});
            this.dataGridView2.Location = new System.Drawing.Point(-1, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(534, 366);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Product Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Order";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // btnOrderCancel
            // 
            this.btnOrderCancel.BackColor = System.Drawing.Color.Red;
            this.btnOrderCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCancel.ForeColor = System.Drawing.Color.White;
            this.btnOrderCancel.Location = new System.Drawing.Point(7, 547);
            this.btnOrderCancel.Name = "btnOrderCancel";
            this.btnOrderCancel.Size = new System.Drawing.Size(242, 46);
            this.btnOrderCancel.TabIndex = 9;
            this.btnOrderCancel.Text = "Order Cancel";
            this.btnOrderCancel.UseVisualStyleBackColor = false;
            this.btnOrderCancel.Click += new System.EventHandler(this.btnOrderCancel_Click);
            // 
            // CashierDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartbillDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton ButtonSnacks;
        private System.Windows.Forms.RadioButton ButtonDesserts;
        private System.Windows.Forms.RadioButton ButtonPackages;
        private System.Windows.Forms.RadioButton ButtonFoods;
        private System.Windows.Forms.RadioButton ButtonDrinks;
        private System.Windows.Forms.Panel panel3;
        private smartbillDataSet1 smartbillDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private smartbillDataSet1TableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewImageColumn imagex;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImagePathFromDb;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Button buttonOrderProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalAmountValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerMobileInput;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.Button btnOrderCancel;
    }
}
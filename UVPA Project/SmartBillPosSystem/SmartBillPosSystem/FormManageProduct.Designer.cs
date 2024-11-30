namespace SmartBillPosSystem
{
    partial class FormManageProduct
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
            this.ButtonFood = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productImagePathFromDb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdFromDb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagex = new System.Windows.Forms.DataGridViewImageColumn();
            this.productNameFromDb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryFromDb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceFromDb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityFromDb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartbillDataSet2 = new SmartBillPosSystem.smartbillDataSet2();
            this.smartbillDataSet1 = new SmartBillPosSystem.smartbillDataSet();
            this.productsTableAdapter = new SmartBillPosSystem.smartbillDataSet2TableAdapters.productsTableAdapter();
            this.ButtonDrinks = new System.Windows.Forms.RadioButton();
            this.ButtonSnacks = new System.Windows.Forms.RadioButton();
            this.ButtonDesserts = new System.Windows.Forms.RadioButton();
            this.ButtonPackages = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartbillDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartbillDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFood
            // 
            this.ButtonFood.AutoSize = true;
            this.ButtonFood.Location = new System.Drawing.Point(37, 106);
            this.ButtonFood.Name = "ButtonFood";
            this.ButtonFood.Size = new System.Drawing.Size(66, 20);
            this.ButtonFood.TabIndex = 0;
            this.ButtonFood.TabStop = true;
            this.ButtonFood.Text = "FOOD";
            this.ButtonFood.UseVisualStyleBackColor = true;
            this.ButtonFood.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productImagePathFromDb,
            this.productIdFromDb,
            this.imagex,
            this.productNameFromDb,
            this.productCategoryFromDb,
            this.productPriceFromDb,
            this.productQuantityFromDb});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 370);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productImagePathFromDb
            // 
            this.productImagePathFromDb.DataPropertyName = "image";
            this.productImagePathFromDb.HeaderText = "Image";
            this.productImagePathFromDb.MinimumWidth = 6;
            this.productImagePathFromDb.Name = "productImagePathFromDb";
            this.productImagePathFromDb.Visible = false;
            this.productImagePathFromDb.Width = 125;
            // 
            // productIdFromDb
            // 
            this.productIdFromDb.DataPropertyName = "product_id";
            this.productIdFromDb.HeaderText = "product_id";
            this.productIdFromDb.MinimumWidth = 6;
            this.productIdFromDb.Name = "productIdFromDb";
            this.productIdFromDb.ReadOnly = true;
            this.productIdFromDb.Width = 125;
            // 
            // imagex
            // 
            this.imagex.FillWeight = 6F;
            this.imagex.HeaderText = "Image";
            this.imagex.MinimumWidth = 100;
            this.imagex.Name = "imagex";
            this.imagex.Width = 101;
            // 
            // productNameFromDb
            // 
            this.productNameFromDb.DataPropertyName = "name";
            this.productNameFromDb.FillWeight = 73.99465F;
            this.productNameFromDb.HeaderText = "Name";
            this.productNameFromDb.MinimumWidth = 6;
            this.productNameFromDb.Name = "productNameFromDb";
            this.productNameFromDb.ReadOnly = true;
            this.productNameFromDb.Width = 125;
            // 
            // productCategoryFromDb
            // 
            this.productCategoryFromDb.DataPropertyName = "category";
            this.productCategoryFromDb.FillWeight = 73.99465F;
            this.productCategoryFromDb.HeaderText = "category";
            this.productCategoryFromDb.MinimumWidth = 6;
            this.productCategoryFromDb.Name = "productCategoryFromDb";
            this.productCategoryFromDb.ReadOnly = true;
            this.productCategoryFromDb.Width = 99;
            // 
            // productPriceFromDb
            // 
            this.productPriceFromDb.DataPropertyName = "price";
            this.productPriceFromDb.FillWeight = 73.99465F;
            this.productPriceFromDb.HeaderText = "price";
            this.productPriceFromDb.MinimumWidth = 6;
            this.productPriceFromDb.Name = "productPriceFromDb";
            this.productPriceFromDb.ReadOnly = true;
            this.productPriceFromDb.Width = 125;
            // 
            // productQuantityFromDb
            // 
            this.productQuantityFromDb.DataPropertyName = "quantity";
            this.productQuantityFromDb.FillWeight = 73.99465F;
            this.productQuantityFromDb.HeaderText = "quantity";
            this.productQuantityFromDb.MinimumWidth = 6;
            this.productQuantityFromDb.Name = "productQuantityFromDb";
            this.productQuantityFromDb.ReadOnly = true;
            this.productQuantityFromDb.Width = 99;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.smartbillDataSet2;
            // 
            // smartbillDataSet2
            // 
            this.smartbillDataSet2.DataSetName = "smartbillDataSet2";
            this.smartbillDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smartbillDataSet1
            // 
            this.smartbillDataSet1.DataSetName = "smartbillDataSet";
            this.smartbillDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonDrinks
            // 
            this.ButtonDrinks.AutoSize = true;
            this.ButtonDrinks.Location = new System.Drawing.Point(188, 106);
            this.ButtonDrinks.Name = "ButtonDrinks";
            this.ButtonDrinks.Size = new System.Drawing.Size(66, 20);
            this.ButtonDrinks.TabIndex = 2;
            this.ButtonDrinks.TabStop = true;
            this.ButtonDrinks.Text = "Drinks";
            this.ButtonDrinks.UseVisualStyleBackColor = true;
            this.ButtonDrinks.CheckedChanged += new System.EventHandler(this.ButtonDrinks_CheckedChanged);
            // 
            // ButtonSnacks
            // 
            this.ButtonSnacks.AutoSize = true;
            this.ButtonSnacks.Location = new System.Drawing.Point(484, 106);
            this.ButtonSnacks.Name = "ButtonSnacks";
            this.ButtonSnacks.Size = new System.Drawing.Size(73, 20);
            this.ButtonSnacks.TabIndex = 4;
            this.ButtonSnacks.TabStop = true;
            this.ButtonSnacks.Text = "Snacks";
            this.ButtonSnacks.UseVisualStyleBackColor = true;
            this.ButtonSnacks.CheckedChanged += new System.EventHandler(this.ButtonSnacks_CheckedChanged);
            // 
            // ButtonDesserts
            // 
            this.ButtonDesserts.AutoSize = true;
            this.ButtonDesserts.Location = new System.Drawing.Point(314, 106);
            this.ButtonDesserts.Name = "ButtonDesserts";
            this.ButtonDesserts.Size = new System.Drawing.Size(82, 20);
            this.ButtonDesserts.TabIndex = 3;
            this.ButtonDesserts.TabStop = true;
            this.ButtonDesserts.Text = "Desserts";
            this.ButtonDesserts.UseVisualStyleBackColor = true;
            this.ButtonDesserts.CheckedChanged += new System.EventHandler(this.ButtonDesserts_CheckedChanged);
            // 
            // ButtonPackages
            // 
            this.ButtonPackages.AutoSize = true;
            this.ButtonPackages.Location = new System.Drawing.Point(657, 106);
            this.ButtonPackages.Name = "ButtonPackages";
            this.ButtonPackages.Size = new System.Drawing.Size(90, 20);
            this.ButtonPackages.TabIndex = 5;
            this.ButtonPackages.TabStop = true;
            this.ButtonPackages.Text = "Packages";
            this.ButtonPackages.UseVisualStyleBackColor = true;
            this.ButtonPackages.CheckedChanged += new System.EventHandler(this.ButtonPackages_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Products";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(170)))), ((int)(((byte)(75)))));
            this.button2.FlatAppearance.BorderSize = 20;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(655, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 31;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.updateBtn.Location = new System.Drawing.Point(37, 535);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBtn.TabIndex = 32;
            this.updateBtn.Text = "Update Product";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteBtn.Location = new System.Drawing.Point(237, 535);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(180, 45);
            this.deleteBtn.TabIndex = 33;
            this.deleteBtn.Text = "Delete Product";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // FormManageProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(786, 592);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonPackages);
            this.Controls.Add(this.ButtonSnacks);
            this.Controls.Add(this.ButtonDesserts);
            this.Controls.Add(this.ButtonDrinks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartbillDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartbillDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ButtonFood;
        private System.Windows.Forms.DataGridView dataGridView1;
        private smartbillDataSet smartbillDataSet1;
        private smartbillDataSet2 smartbillDataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private smartbillDataSet2TableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.RadioButton ButtonDrinks;
        private System.Windows.Forms.RadioButton ButtonSnacks;
        private System.Windows.Forms.RadioButton ButtonDesserts;
        private System.Windows.Forms.RadioButton ButtonPackages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImagePathFromDb;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdFromDb;
        private System.Windows.Forms.DataGridViewImageColumn imagex;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameFromDb;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryFromDb;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceFromDb;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityFromDb;
        private System.Windows.Forms.Button deleteBtn;
    }
}
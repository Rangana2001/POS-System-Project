namespace SmartBillPosSystem.Components
{
    partial class ProductCardComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonSetAvailability = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureProductImage = new System.Windows.Forms.PictureBox();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemove.Location = new System.Drawing.Point(133, 189);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(92, 37);
            this.ButtonRemove.TabIndex = 0;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonSetAvailability
            // 
            this.ButtonSetAvailability.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSetAvailability.Location = new System.Drawing.Point(21, 234);
            this.ButtonSetAvailability.Name = "ButtonSetAvailability";
            this.ButtonSetAvailability.Size = new System.Drawing.Size(204, 37);
            this.ButtonSetAvailability.TabIndex = 1;
            this.ButtonSetAvailability.Text = "Availability";
            this.ButtonSetAvailability.UseVisualStyleBackColor = true;
            this.ButtonSetAvailability.Click += new System.EventHandler(this.ButtonSetAvailability_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelPrice);
            this.panel1.Controls.Add(this.LabelProductName);
            this.panel1.Controls.Add(this.PictureProductImage);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 182);
            this.panel1.TabIndex = 3;
            // 
            // PictureProductImage
            // 
            this.PictureProductImage.Location = new System.Drawing.Point(20, 13);
            this.PictureProductImage.Name = "PictureProductImage";
            this.PictureProductImage.Size = new System.Drawing.Size(204, 100);
            this.PictureProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureProductImage.TabIndex = 0;
            this.PictureProductImage.TabStop = false;
            this.PictureProductImage.Click += new System.EventHandler(this.PictureProductImage_Click);
            // 
            // LabelProductName
            // 
            this.LabelProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelProductName.Location = new System.Drawing.Point(16, 128);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(105, 51);
            this.LabelProductName.TabIndex = 2;
            this.LabelProductName.Text = "ABCD EFGH HUGH LMNK";
            this.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelProductName.Click += new System.EventHandler(this.LabelProductName_Click);
            // 
            // LabelPrice
            // 
            this.LabelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.Location = new System.Drawing.Point(126, 139);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(106, 28);
            this.LabelPrice.TabIndex = 3;
            this.LabelPrice.Text = "RS:500.00";
            this.LabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductCardComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonSetAvailability);
            this.Controls.Add(this.ButtonRemove);
            this.Name = "ProductCardComponent";
            this.Size = new System.Drawing.Size(247, 287);
            this.Load += new System.EventHandler(this.ProductCardComponent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonSetAvailability;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureProductImage;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelProductName;
    }
}

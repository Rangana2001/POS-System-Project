using System;
using System.Windows.Forms;

namespace SmartBillPosSystem
{
    public partial class ReceiptForm : Form
    {
        private readonly string orderId;
        private readonly string orderDate;
        private readonly string productList;
        private readonly int totalAmount;
        private readonly string customerName;
        private readonly string customerMobile;

        public ReceiptForm(string orderId, string orderDate, string productList, int totalAmount, string customerName, string customerMobile)
        {
            InitializeComponent();

            this.orderId = orderId;
            this.orderDate = orderDate;
            this.productList = productList;
            this.totalAmount = totalAmount;
            this.customerName = customerName;
            this.customerMobile = customerMobile;

            DisplayReceipt();
        }

        private void DisplayReceipt()
        {
            string header = $"--------------------- Receipt ---------------------\n\n";
            string orderInfo = $"Order ID: {orderId}\n" +
                               $"Order Date: {orderDate}\n" +
                               $"Customer Name: {customerName}\n" +
                               $"Customer Mobile: {customerMobile}\n\n";
            string productListHeader = "Product List:\n";
            string productListText = $"{productList}\n";
            string totalAmountText = $"Total Amount: {totalAmount:C}\n\n";
            string thankYouText = "Thank you for your order!\n";
            string footer = "---------------------------------------------------";

            string receiptText = header + orderInfo + productListHeader + productListText + totalAmountText + thankYouText + footer;

            receiptTextBox.Text = receiptText;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

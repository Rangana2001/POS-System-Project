using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBillPosSystem
{
    public partial class FormTransactions : Form
    {
        public FormTransactions()
        {
            InitializeComponent();
        }

        private void FormTransactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartbillDataSetTransaction.transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.smartbillDataSetTransaction.transactions);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SpecificDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

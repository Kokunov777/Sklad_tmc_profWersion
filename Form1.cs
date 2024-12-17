using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemSklad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Glav Form";
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm(); // 
            warehouseForm.Show();
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            GoodsForm goodsForm = new GoodsForm();
            goodsForm.Show();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            ContractsForm contractsForm = new ContractsForm(); 
            contractsForm.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();  
            clientForm.Show();
        }

        private void btnReportPayment_Click(object sender, EventArgs e)
        {
            ReportPaymentForm reportPaymentForm = new ReportPaymentForm(); 
            reportPaymentForm.Show();
        }

        private void Playment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LylaUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.sysDataSet.customer);
            salesTableAdapter.FillByActiveSales(sysDataSet.sales);
        }

        // Form Openers ------------------------------------------------------------------
        private void btnOpenCustomers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void btnOpenInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void btnOpenMaterials_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            materials.Show();
        }

        private void btnOpenRecipies_Click(object sender, EventArgs e)
        {
            Recipies recipies = new Recipies();
            recipies.Show();
        }

        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            this.customerTableAdapter.Fill(this.sysDataSet.customer);
            salesTableAdapter.FillByActiveSales(sysDataSet.sales);
            salesTableAdapter.Update(sysDataSet);
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to close this sale?\nThis cannot be undone.", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                salesTableAdapter.CompleteSale(int.Parse(txtSaleID.Text));
                RefreshGrid();

                }
                catch (Exception)
                {
                    MessageBox.Show("You should never see this. Tell me if you do.");
                }

            }
            else
            {

            }
            

        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
           

            DialogResult result = MessageBox.Show("Do you want to close this sale?\nThis cannot be undone.", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                  salesTableAdapter.CancelSale(rtbComments.Text + " | SALE CANCELED AT " + DateTime.Now.ToString("MM/dd/yyyy H:mm"), int.Parse(txtSaleID.Text));
                  RefreshGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("You should never see this. Tell me if you do.");
                }

            }
            else
            {

            }

        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            CreateSale CreateSale = new CreateSale();
            CreateSale.Show();
        }
    }
}

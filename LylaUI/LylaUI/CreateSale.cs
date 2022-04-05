using LylaUI.sysDataSetTableAdapters;
using MySqlX.XDevAPI.Relational;
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
    public partial class CreateSale : Form
    {
        public CreateSale()
        {
            InitializeComponent();
        }

        private void CreateSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysDataSet.iteminventory' table. You can move, or remove it, as needed.
            this.iteminventoryTableAdapter.FillByActive(this.sysDataSet.iteminventory);
            // TODO: This line of code loads data into the 'sysDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.sysDataSet.customer);

        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            try
            {
             salesTableAdapter.InsertSale(int.Parse(txtCustomerID.Text), txtDate.Text, "0", (txtShippingCost.Text), "0", "0", txtRaffleEntry.Text, rtbComments.Text);
             salesTableAdapter.Update(sysDataSet.sales);
             
             int lastSale = int.Parse((salesTableAdapter.SelectLastSale()).ToString());

             AddSoldItems(lastSale);
             RemoveSoldFromInventory(lastSale);
             CalculateTotal(lastSale);
             CalculateMaterialCosts(lastSale);
             CalculateNetProfit(lastSale);
             this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Was everything selected and filled out?\nPlease verify and try again.\nHere's the specific error: "+ex.ToString());
            }

           
        }

        public void AddSoldItems(int lastSale)
        {

            int countRows = 0;
            foreach (var row in dgvOnOrder.Rows)
            {
                countRows++;
            }

            for (int i = 0; i < countRows; i++)
            {
                try
                {
                    int quantity = int.Parse(dgvOnOrder.Rows[i].Cells["Quantity"].Value.ToString());
                    solditemsTableAdapter.InsertSoldItem(int.Parse(dgvOnOrder.Rows[i].Cells["ItemID"].Value.ToString()), lastSale, quantity);
                   // MessageBox.Show("Adding items to sale complete");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong pretty badly with the database. Let Jake know because this probably will stop you from being able to work. Here's the error for me..\n\n" + ex.ToString());
                }
                
            }
        }
        public void RemoveSoldFromInventory(int lastSale)
        {
            int countRows = 0;
            foreach (var row in dgvOnOrder.Rows)
            {
                countRows++;
            }

            for (int i = 0; i < countRows; i++)
            {
                try
                {
                    
                    int quantity = int.Parse(dgvOnOrder.Rows[i].Cells["Quantity"].Value.ToString());
                    var onhand = iteminventoryTableAdapter.ReturnQuantity(int.Parse(dgvOnOrder.Rows[i].Cells["ItemID"].Value.ToString()));
                    int inventoryQuantity = int.Parse(onhand) - quantity;                
                    iteminventoryTableAdapter.UpdateQuantity(inventoryQuantity.ToString(), int.Parse(dgvOnOrder.Rows[i].Cells["ItemID"].Value.ToString()));
                    //MessageBox.Show("removing items from inventory complete");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong pretty badly with the database. Let Jake know because this probably will stop you from being able to work. Here's the error for me..\n\n" + ex.ToString());
                }

            }
        }
        public void CalculateTotal(int lastSale)
        {
            double total=0;
            int countRows = 0;
            foreach (var row in dgvOnOrder.Rows)
            {
                countRows++;
            }

            for (int i = 0; i < countRows; i++)
            {
                try
                {
                    double quantity = double.Parse(dgvOnOrder.Rows[i].Cells["Quantity"].Value.ToString());
                    double price = double.Parse(dgvOnOrder.Rows[i].Cells["Price"].Value.ToString());

                    total = total + (quantity * price);

                   // MessageBox.Show(" Total computation complete");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong pretty badly with the database. Let Jake know because this probably will stop you from being able to work. Here's the error for me..\n\n" + ex.ToString());
                }

                try
                {
                    salesTableAdapter.UpdateOrderTotal(decimal.Parse(total.ToString()), lastSale);
                   // MessageBox.Show(" total updated in database complete");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong pretty badly with the database. Let Jake know because this probably will stop you from being able to work. Here's the error for me..\n\n" + ex.ToString());
                }


            }
        }
        public void CalculateMaterialCosts(int lastSale)
        {
            double totalCost = 0;
            int countRows = 0;
            foreach (var row in dgvOnOrder.Rows)
            {
                countRows++;
            }

            for (int i = 0; i < countRows; i++)
            {
                try
                {
                    int itemID = int.Parse(dgvOnOrder.Rows[i].Cells["ItemID"].Value.ToString());
                    var materialsObject = creationmaterialsTableAdapter.GetDataByItemID(itemID);

                    
                    foreach (DataRow row in materialsObject.Rows)
                    {
                        int materialID = int.Parse(row["MaterialID"].ToString());
                        int quantity = int.Parse(row["Quantity"].ToString());
                        double pricePerUnit = double.Parse(materialsTableAdapter.ReturnCostPerUnit(materialID).ToString());

                        totalCost = totalCost + (quantity * pricePerUnit);
                    }

                   // MessageBox.Show(" material cost calculations complete");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong pretty badly with the database. Let Jake know because this probably will stop you from being able to work. Here's the error for me..\n\n" + ex.ToString());
                }

            }

            try
            {
                salesTableAdapter.UpdateMaterialsCost(decimal.Parse(totalCost.ToString()), lastSale);
               // MessageBox.Show(" database materials update complete");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong pretty badly with the database. Let Jake know because this probably will stop you from being able to work. Here's the error for me..\n\n" + ex.ToString());
            }




        }
        public void CalculateNetProfit(int lastSale)
        {
            var lastRow = salesTableAdapter.ReturnLastRow(lastSale);
            double netProfit = 0;
            foreach (DataRow row in lastRow.Rows)
            {
                double materialsCost = double.Parse(row["MaterialsCost"].ToString());
                double orderTotal = double.Parse(row["OrderTotal"].ToString());
                double shippingCost = double.Parse(row["ShippingCost"].ToString());

                netProfit = orderTotal - shippingCost - materialsCost;

                //MessageBox.Show(" calculating net profit complete complete");
            }

            try
            {
            salesTableAdapter.UpdateNetProfit(decimal.Parse(netProfit.ToString()), lastSale);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong pretty badly with the database. Let Jake know because this probably will stop you from being able to work. Here's the error for me..\n\n" + ex.ToString());
            }

        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("MM/dd/yyyy H:mm");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var row = dgvItems.SelectedRows;

            int count = 0;

            foreach (var item in dgvOnOrder.Rows)
            {
                count++;
            }

            string itemName = row[0].Cells["ItemName"].Value.ToString(); ;
            string itemID = row[0].Cells["ItemsID"].Value.ToString();
            string quantity = txtQuantity.Text;
            string price = row[0].Cells["ItemPrice"].Value.ToString(); ;
            

            dgvOnOrder.Rows.Add();
            dgvOnOrder.Rows[count].Cells["Item"].Value = itemName;
            dgvOnOrder.Rows[count].Cells["Quantity"].Value = quantity;
            dgvOnOrder.Rows[count].Cells["ItemID"].Value = itemID;
            dgvOnOrder.Rows[count].Cells["Price"].Value = price;





        }
    }
}

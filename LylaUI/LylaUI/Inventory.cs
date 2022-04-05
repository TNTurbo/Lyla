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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.creationmaterialsTableAdapter.Fill(this.sysDataSet.creationmaterials);
            this.materialsTableAdapter.Fill(this.sysDataSet.materials);
            this.iteminventoryTableAdapter.FillByActive(this.sysDataSet.iteminventory);

        }

        private void dgvCrafts_CurrentCellChanged(object sender, EventArgs e)
        {

            try
            {
                dgvRecipies.DataSource = null;
                creationmaterialsTableAdapter.FillByItemID(sysDataSet.creationmaterials, int.Parse(txtItemID.Text));
                creationmaterialsTableAdapter.Update(sysDataSet);
                dgvRecipies.DataSource = creationmaterialsBindingSource;
                GetAmountLeft();

            }
            catch (Exception)
            {
                
            }
        }

        public void GetAmountLeft()
        {
            int countRows = 0;

            foreach (DataGridViewRow row in dgvRecipies.Rows)
            {
                countRows++;
            }

            for (int i = 0; i < countRows; i++)
            {
                dgvRecipies.Rows[i].Cells["AmountLeft"].Value = materialsTableAdapter.ReturnOnHandMaterials(int.Parse(dgvRecipies.Rows[i].Cells["MaterialID"].Value.ToString()));

            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateMaterialCosts();
        }

        public void CalculateMaterialCosts()
        {
            double totalCost = 0;
            int countRows = 0;
            int itemID = int.Parse(txtItemID.Text);
            foreach (var row in dgvRecipies.Rows)
            {
                countRows++;
            }

            //for (int i = 0; i < countRows; i++)
            //{
                try
                {
                   
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

           // }

            try
            {
                iteminventoryTableAdapter.UpdateMaterialCost(decimal.Parse(totalCost.ToString()), itemID);
                iteminventoryTableAdapter.Update(sysDataSet.iteminventory);
                txtProfit.Text = (double.Parse(txtPrice.Text) - double.Parse(txtMaterialCost.Text)).ToString();
                iteminventoryBindingSource.EndEdit();
                iteminventoryTableAdapter.Update(sysDataSet.iteminventory);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong pretty badly with the database. Let Jake know because this probably will stop you from being able to work. Here's the error for me..\n\n" + ex.ToString());
            }




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int x = 0; x < int.Parse(txtQuantity.Text); x++)
                {
                    int countRows = 0;
                    bool craftable = true;

                    foreach (DataGridViewRow row in dgvRecipies.Rows)
                    {
                        countRows++;
                    }

                    for (int i = 0; i < countRows; i++)
                    {
                        if (int.Parse(dgvRecipies.Rows[i].Cells["quantityDataGridViewTextBoxQuantity"].Value.ToString()) > int.Parse(dgvRecipies.Rows[i].Cells["AmountLeft"].Value.ToString()))
                        {
                            craftable = false;
                        }

                    }

                    if (craftable == false)
                    {
                        DialogResult result = MessageBox.Show("You don't have enough materials to make this item.\nWould you like to overwrite and proceed?","Confirm", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            craftable = true;

                        }
                        else
                        {
                            break;
                        }
                    }

                   
                    if (craftable == true)
                    {
                        txtItemQuantity.Text = (int.Parse(txtItemQuantity.Text) + 1).ToString();
                        //Remove materials
                        iteminventoryBindingSource.EndEdit();
                        iteminventoryTableAdapter.Update(sysDataSet);
                        for (int i = 0; i < countRows; i++)
                        {
                            materialsTableAdapter.RemoveMaterials(int.Parse(dgvRecipies.Rows[i].Cells["AmountLeft"].Value.ToString())- int.Parse(dgvRecipies.Rows[i].Cells["quantityDataGridViewTextBoxQuantity"].Value.ToString()), int.Parse(dgvRecipies.Rows[i].Cells["MaterialID"].Value.ToString()));
                            dgvRecipies.Rows[i].Cells["AmountLeft"].Value = materialsTableAdapter.ReturnOnHandMaterials(int.Parse(dgvRecipies.Rows[i].Cells["MaterialID"].Value.ToString()));
                            materialsTableAdapter.Update(sysDataSet);
                            
                        }

                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\nWas everything filled in?\nHere are the error details...\n\n"+ex.ToString());
            }
            
           

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtItemQuantity.Text = (int.Parse(txtItemQuantity.Text) - int.Parse(txtQuantity.Text)).ToString();

        }
          

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            iteminventoryBindingSource.AddNew();
            txtRetired.Text = "0";
            EnableControls();
            txtItem.Focus();
        }

        private void btnRetireItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to retire this item?\nThis cannot be undone.", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    txtRetired.Text = "1";
                    iteminventoryBindingSource.EndEdit();
                    iteminventoryTableAdapter.Update(sysDataSet);
                    DisableControls();
                    this.iteminventoryTableAdapter.FillByActive(this.sysDataSet.iteminventory);
                    RefreshItemList();

                }
                catch (Exception)
                {
                    MessageBox.Show("Hi you found a weird bug where when you try to delete something you just made before reloading this window it doesn't work.\n\nI know why but I can't figure out how to fix it, so just bear with me here. You'll need to close the window and then delete it.\n\nNothing has been done.");
                }
                
            }
            else
            {
             
            }

            

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvRecipies.DataSource = null;
            creationmaterialsTableAdapter.FillByItemID(sysDataSet.creationmaterials, int.Parse(txtItemID.Text));
            creationmaterialsTableAdapter.Update(sysDataSet);
            dgvRecipies.DataSource = creationmaterialsBindingSource;
            GetAmountLeft();

        }

        private void btnOpenRecipies_Click(object sender, EventArgs e)
        {
            Recipies recipies = new Recipies();
            recipies.Show();
        }

        public void EnableControls()
        {
            btnConfirm.Visible = true;
            btnEdit.Visible = false;
            btnAdd.Enabled = true;
            btnRetireItem.Enabled = true;
            dgvCrafts.Enabled = false;
            btnNewItem.Enabled = false;
            btnRemove.Enabled = true;

            txtGeneration.Enabled = true;
            txtItem.Enabled = true;
            txtLabor.Enabled = true;
            txtPrice.Enabled = true;
            txtQuality.Enabled = true;
            txtQuantity.Enabled = true;
            txtItemQuantity.Enabled = true;
            btnCancel.Visible = true;

        }

        public void DisableControls()
        {
            btnConfirm.Visible = false;
            btnEdit.Visible = true;
            btnAdd.Enabled = false;
            btnRetireItem.Enabled = false;
            dgvCrafts.Enabled = true;
            btnNewItem.Enabled = true;
            btnRemove.Enabled = false;
            btnCancel.Visible = false;

            txtGeneration.Enabled = false;
            txtItem.Enabled = false;
            txtLabor.Enabled = false;
            txtPrice.Enabled = false;
            txtQuality.Enabled = false;
            txtQuantity.Enabled = false;
            txtItemQuantity.Enabled = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            iteminventoryBindingSource.EndEdit();
            iteminventoryTableAdapter.Update(sysDataSet.iteminventory);
            DisableControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            iteminventoryBindingSource.CancelEdit();
            DisableControls();
        }

        private void btnRefreshItemList_Click(object sender, EventArgs e)
        {
            RefreshItemList();
        }

        public void RefreshItemList()
        {
            this.iteminventoryTableAdapter.FillByActive(this.sysDataSet.iteminventory);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.iteminventoryTableAdapter.Fill(this.sysDataSet.iteminventory);

        }
    }
}

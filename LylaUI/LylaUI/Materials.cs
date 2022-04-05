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
    public partial class Materials : Form
    {
        public Materials()
        {
            InitializeComponent();
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysDataSet.materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.sysDataSet.materials);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                txtQuantity.Text = (int.Parse(txtQuantity.Text) + int.Parse(txtNumberMod.Text)).ToString();
                materialsBindingSource.EndEdit();
                materialsTableAdapter.Update(sysDataSet);

            }
            catch (Exception)
            {

            }
            
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                txtQuantity.Text = (int.Parse(txtQuantity.Text) - int.Parse(txtNumberMod.Text)).ToString();
                materialsBindingSource.EndEdit();
                materialsTableAdapter.Update(sysDataSet);

            }
            catch (Exception)
            {

            }
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            materialsBindingSource.AddNew();
            EnableControls();
            txtMaterial.Focus();

        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + txtMaterial.Text + "?\nThis *CANNOT* be undone.", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    materialsBindingSource.Remove(materialsBindingSource.Current);
                    materialsTableAdapter.Update(sysDataSet);

            }
            else
                {

                }

            
        }

        public void EnableControls()
        {
            txtMaterial.Enabled = true;
            txtQuantity.Enabled = true;
            txtUnitCost.Enabled = true;
            rtbComments.Enabled = true;

            btnCancel.Visible = true;
            btnConfirm.Visible = true;
        }

        public void DisableControls()
        {
            txtMaterial.Enabled = false;
            txtQuantity.Enabled = false;
            txtUnitCost.Enabled = false;
            rtbComments.Enabled = false;

            btnCancel.Visible = false;
            btnConfirm.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                materialsBindingSource.EndEdit();
                DisableControls();
                materialsTableAdapter.Update(sysDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure all fields are filled out.");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            materialsBindingSource.CancelEdit();
            DisableControls();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableControls();
        }
    }
}

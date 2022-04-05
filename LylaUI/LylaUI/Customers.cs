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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        public void EnableAddControls()
        {
           
            txtAddress.Enabled = true;
            txtCity.Enabled = true;
            txtCountry.Enabled = true;
            txtEmail.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtMedium.Enabled = true;
            txtPhone.Enabled = true;
            txtState.Enabled = true;
            txtTier.Text = "Regular";
            txtTier.Enabled = true;
            txtUsername.Enabled = true;
            txtUsername.Focus();
            txtZIP.Enabled = true;
            txtYTD.Text = "0";
            txtYTD.Enabled = true;

            rtbComments.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            dgvCustomer.Enabled = false;

            btnSubmit.Enabled = true;
            btnCancel.Visible = true;
        }

        public void DisableAddControls()
        {

            txtAddress.Enabled = false;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtMedium.Enabled = false;
            txtPhone.Enabled = false;
            txtState.Enabled = false;
            txtUsername.Enabled = false;
            txtZIP.Enabled = false;
            txtTier.Enabled = false;
            dgvCustomer.Enabled = true;
            rtbComments.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            txtYTD.Enabled = false;
            btnSubmit.Enabled = false;
            btnCancel.Visible = false;
        }


        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.sysDataSet.customer);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                customerBindingSource.AddNew();
                EnableAddControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + txtUsername.Text + "?\nThis *CANNOT* be undone.", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                customerBindingSource.Remove(customerBindingSource.Current);
                customerBindingSource.EndEdit();
                customerTableAdapter.Update(sysDataSet.customer);
            }
            else
            {
                
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableAddControls();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                customerBindingSource.EndEdit();
                customerTableAdapter.Update(sysDataSet);
                DisableAddControls();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure all fields are filled out.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            customerBindingSource.CancelEdit();
            DisableAddControls();
        }

     
    }
}

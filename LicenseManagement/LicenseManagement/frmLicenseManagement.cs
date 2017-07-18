using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseManagement.ApplicationBase;
using LicenseManagement.DataModels;

namespace LicenseManagement
{
    public partial class frmLicenseManagement : Form
    {
        private ApplicationBase.LicenseManager lm = null;

        public frmLicenseManagement()
        {
            InitializeComponent();
            InitializeLicenseManager();
        }

        private void InitializeLicenseManager()
        {
            lm = new ApplicationBase.LicenseManager();
        }

        private void loadData(string filter)
        {
            List<LicenseData> lics = null;

            if (!string.IsNullOrEmpty(filter))
            {
                lics = lm.getLicensesAsList(filter);
            }
            else
            {
                lics = lm.getLicensesAsList();
            }

            lstLicenseOwners.Items.Clear();
            foreach (LicenseData ld in lics)
            {
                ListViewItem lvi = new ListViewItem(ld.CustomerID + " - " + ld.CustomerName, imgList.Images.Keys[0].ToString());
                lvi.Tag = ld.CustomerID;
                lstLicenseOwners.Items.Add(lvi);
            }

            dgvLicenseOwners.DataSource = lics;
        }

        private void loadData()
        {
            loadData(null);
        }
        
        private void frmLicenseManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void lstLicenseOwners_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCustomerID.Text.Trim()))
            {
                LicenseData ld = new LicenseData();
                fillValuesFromGUI(ld);

                lm.addLicense(ld);
                clearFields();
                loadData();
            }
            else
            {
                LicenseData ld = new LicenseData();
                int customerID = 0;
                int.TryParse(txtCustomerID.Text.ToString(), out customerID);
                ld.CustomerID = customerID;
                fillValuesFromGUI(ld);

                lm.updateLicense(ld);
                clearFields();
                loadData();
            }            
        }

        private void fillValuesFromGUI(LicenseData ld)
        {
            ld.CustomerName = txtCustomerName.Text.TrimEnd();
            int licenseAmount = 0;
            int.TryParse(txtLicenseAmount.Text.ToString(), out licenseAmount);
            ld.LicenseAmount = licenseAmount;
            int rentFee = 0;
            int.TryParse(txtRentFee.Text.ToString(), out rentFee);
            ld.RentFee = rentFee;

            ld.LastMaintenance = dtpLastMaintenance.Value.ToString("yyyy-MM-dd");
            ld.SupportService = (chbSupportService.Checked) ? 1 : 0;
            ld.LicenseKeys = txtLicenseKeys.Text.TrimEnd();
            ld.SoftwareVersion = txtSoftwareVersion.Text.TrimEnd();
            ld.ContactPerson = txtContactPerson.Text.TrimEnd();
        }

        private void txtLicenseAmount_TextChanged(object sender, EventArgs e)
        {
            btnSaveCustomer.Enabled = checkIntegerValidity(txtLicenseAmount);
        }

        private void txtRentFee_TextChanged(object sender, EventArgs e)
        {
            btnSaveCustomer.Enabled = checkIntegerValidity(txtRentFee);
        }

        private bool checkIntegerValidity(TextBox tb)
        {
            int value = 0;
            if (!int.TryParse(tb.Text.ToString(), out value))
            {
                if(!string.IsNullOrEmpty(tb.Text))
                {
                    return false;
                }
                return true;
            }
            return true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("License Manager - Version 1.0.0\nreleased under LGPLv3");
        }

        private void clearFields()
        {
            txtCustomerID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtLicenseAmount.Text = string.Empty;
            txtRentFee.Text = string.Empty;
            dtpLastMaintenance.Value = DateTime.Today;
            chbSupportService.Checked = false;
            txtLicenseKeys.Text = string.Empty;
            txtSoftwareVersion.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerID.Text.Trim()))
            {
                if(checkIntegerValidity(txtCustomerID))
                {
                    lm.deleteLicense(int.Parse(txtCustomerID.Text));
                    loadData();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                loadData(txtSearch.Text);
            }
            else
            {
                loadData();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void lstLicenseOwners_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lstLicenseOwners.SelectedItems.Count > 0)
            {
                int ID = 0;
                if (int.TryParse(lstLicenseOwners.SelectedItems[0].Tag.ToString(), out ID))
                {
                    loadDetails(ID);
                }              
            }
        }

        private void loadDetails(int ID)
        {
            LicenseData ld = lm.getLicense(ID);
            clearFields();
            txtCustomerID.Text = ld.CustomerID.ToString();
            txtCustomerName.Text = ld.CustomerName;
            txtLicenseAmount.Text = ld.LicenseAmount.ToString();
            txtRentFee.Text = ld.RentFee.ToString();
            string[] parts = ld.LastMaintenance.Split('-');
            if(parts.Length > 2)
            {
                int year, month, day;
                int.TryParse(parts[0], out year);
                int.TryParse(parts[1], out month);
                int.TryParse(parts[2], out day);
                dtpLastMaintenance.Value = new DateTime(year, month, day);
            }
            chbSupportService.Checked = (ld.SupportService == 1) ? true : false;
            txtLicenseKeys.Text = ld.LicenseKeys;
            txtSoftwareVersion.Text = ld.SoftwareVersion;
            txtContactPerson.Text = ld.ContactPerson;
        }

        private void dgvLicenseOwners_SelectionChanged(object sender, EventArgs e)
        {
            if( dgvLicenseOwners.SelectedRows.Count > 0)
            {
                LicenseData ld = (LicenseData)dgvLicenseOwners.SelectedRows[0].DataBoundItem;
                loadDetails(ld.CustomerID);
            }
        }
    }
}

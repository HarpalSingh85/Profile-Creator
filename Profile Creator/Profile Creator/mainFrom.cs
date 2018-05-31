using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile_Creator
{
    public partial class mainForm : Form
    {     

        public mainForm()
        {
            InitializeComponent();            
        }
        
        private void mainForm_Load(object sender, EventArgs e)
        {
            btnProceed.Enabled = false;
            PopulateDefaults defaultdata = new PopulateDefaults();
            cmbBoxLocation.DataSource = new BindingSource(defaultdata.GetLocation(), null);
            cmbBoxLocation.DisplayMember = "Key";
            cmbBoxLocation.ValueMember = "Value";
            cmbBoxProfleType.DataSource = defaultdata.GetProfileType();
            chkBoxfullProvision.CheckState = CheckState.Checked;
            try
            {
            lblCurrentDC.Text = GetCurrentDomain.CurrentDomain;
            }
            catch(Exception Ex)
            {
                toolStripStatuslbl.Text = Ex.Message;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnProceed_Click(object sender, EventArgs e)
        {
            btnProceed.Enabled = false;
            lstBoxDisplay.Items.Clear();
            if(!String.IsNullOrWhiteSpace(txtBoxUser.Text))
            {
                string _profileType = cmbBoxProfleType.SelectedItem.ToString();
                string _ploc = ((KeyValuePair<string, string>)cmbBoxLocation.SelectedItem).Key;
                string _path = ((KeyValuePair<string, string>)cmbBoxLocation.SelectedItem).Value;
                try
                {
                   

                    ADInterfacer adi = new ADInterfacer(txtBoxUser.Text, _path, _ploc, _profileType);
                    adi.UserProvisioningCompleted += Adi_UserProvisioningCompleted;
                    string details =await adi.ProvisionUser();                        
                                      
                    
                    ProvisionDirectory dir = new ProvisionDirectory();
                    dir.HomeDirectoryProvisioned += Dir_HomeDirectoryProvisioned;
                    dir.CitrixDirectoryProvisioned += Dir_CitrixDirectoryProvisioned;
                    await dir.ProvisionHomeDirectory(_path, txtBoxUser.Text);                       
                    await dir.ProvisionCitrixDirectory(txtBoxUser.Text);
                    lstBoxDisplay.Items.Add(details);                                      
                }
                catch (Exception Ex)
                {
                    toolStripStatuslbl.Text = Ex.Message;
                    btnProceed.Enabled = true;
                }
            }
            else
            {
                toolStripStatuslbl.Text = "User cannot be empty";
            }
            btnProceed.Enabled = true;
        }

        private void Dir_CitrixDirectoryProvisioned(object sender, EventArgs e)
        {
            lstBoxDisplay.Items.Add("Citrix home drive provisioned");
        }

        private void Dir_HomeDirectoryProvisioned(object sender, EventArgs e)
        {
            lstBoxDisplay.Items.Add("Home directory provisioned");
        }

        private void Adi_GroupProvisioningCompleted(object source, EventArgs e)
        {
            lstBoxDisplay.Items.Add("AD Groups Added");
        }

        private void Adi_UserProvisioningCompleted(object source, EventArgs e)
        {
            lstBoxDisplay.Items.Add("User Provisioned");
        }

        private void cmbBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selecteditem = (KeyValuePair<string, string>)cmbBoxLocation.SelectedItem;
                        
            //lstBoxDisplay.Items.Add(selecteditem.Key + ":: " +selecteditem.Value);
        }

        private async void txtBoxUser_TextChanged(object sender, EventArgs e)
        {          
            if(!String.IsNullOrWhiteSpace(txtBoxUser.Text))
            {
                if ( await ADUserValidation.ValidateAsync(txtBoxUser.Text))
                {
                    btnProceed.Enabled = true;                    
                }
                else
                {
                    btnProceed.Enabled = false;                   
                }
            }
            
        }

    }
}

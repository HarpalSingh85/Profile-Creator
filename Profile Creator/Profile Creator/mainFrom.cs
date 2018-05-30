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
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtBoxUser.Text))
            {
                string _ploc = ((KeyValuePair<string, string>)cmbBoxLocation.SelectedItem).Key;
                string _path = ((KeyValuePair<string, string>)cmbBoxLocation.SelectedItem).Value;
                try
                {
                    ADInterfacer adi = new ADInterfacer();
                    string details = adi.GetUser(txtBoxUser.Text,_path,_ploc);
                    lstBoxDisplay.Items.Add(details);
                }
                catch (Exception Ex)
                {
                    toolStripStatuslbl.Text = Ex.Message;
                }
            }
            else
            {
                toolStripStatuslbl.Text = "User cannot be empty";
            }
        }

        private void cmbBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecteditem = (KeyValuePair<string, string>)cmbBoxLocation.SelectedItem;
                        
            lstBoxDisplay.Items.Add(selecteditem.Key + ":: " +selecteditem.Value);
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

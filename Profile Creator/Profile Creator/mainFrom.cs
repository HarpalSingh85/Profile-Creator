using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            PopulateDefaults defaultdata = new PopulateDefaults();
            cmbBoxLocation.DataSource = defaultdata.GetLocation();
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
                ADInterfacer adi = new ADInterfacer();
                List<string> details = adi.GetUser(txtBoxUser.Text);
                lstBoxDisplay.Items.Add(details);
            }
            else
            {
                toolStripStatuslbl.Text = "User cannot be empty";
            }
        }
    }
}

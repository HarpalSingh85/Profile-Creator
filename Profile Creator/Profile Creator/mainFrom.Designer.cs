namespace Profile_Creator
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBoxDisplay = new System.Windows.Forms.ListBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.cmbBoxLocation = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbBoxProfleType = new System.Windows.Forms.ComboBox();
            this.chkBoxfullProvision = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoxfullProvision);
            this.groupBox1.Controls.Add(this.cmbBoxProfleType);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.cmbBoxLocation);
            this.groupBox1.Controls.Add(this.txtBoxUser);
            this.groupBox1.Controls.Add(this.lblLocation);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lstBoxDisplay
            // 
            this.lstBoxDisplay.FormattingEnabled = true;
            this.lstBoxDisplay.Location = new System.Drawing.Point(12, 111);
            this.lstBoxDisplay.Name = "lstBoxDisplay";
            this.lstBoxDisplay.Size = new System.Drawing.Size(505, 108);
            this.lstBoxDisplay.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User ID";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(6, 69);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(61, 12);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(90, 20);
            this.txtBoxUser.TabIndex = 2;
            // 
            // cmbBoxLocation
            // 
            this.cmbBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLocation.FormattingEnabled = true;
            this.cmbBoxLocation.Location = new System.Drawing.Point(61, 66);
            this.cmbBoxLocation.Name = "cmbBoxLocation";
            this.cmbBoxLocation.Size = new System.Drawing.Size(151, 21);
            this.cmbBoxLocation.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 42);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // cmbBoxProfleType
            // 
            this.cmbBoxProfleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxProfleType.FormattingEnabled = true;
            this.cmbBoxProfleType.Location = new System.Drawing.Point(61, 39);
            this.cmbBoxProfleType.Name = "cmbBoxProfleType";
            this.cmbBoxProfleType.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxProfleType.TabIndex = 5;
            // 
            // chkBoxfullProvision
            // 
            this.chkBoxfullProvision.AutoSize = true;
            this.chkBoxfullProvision.Location = new System.Drawing.Point(377, 71);
            this.chkBoxfullProvision.Name = "chkBoxfullProvision";
            this.chkBoxfullProvision.Size = new System.Drawing.Size(130, 17);
            this.chkBoxfullProvision.TabIndex = 6;
            this.chkBoxfullProvision.Text = "Complete Provisioning";
            this.chkBoxfullProvision.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatuslbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 259);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(529, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatuslbl
            // 
            this.toolStripStatuslbl.Name = "toolStripStatuslbl";
            this.toolStripStatuslbl.Size = new System.Drawing.Size(0, 17);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(366, 225);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "&Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(447, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 281);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lstBoxDisplay);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Creator Test Demo";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBoxDisplay;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbBoxLocation;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.ComboBox cmbBoxProfleType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.CheckBox chkBoxfullProvision;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslbl;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnExit;
    }
}


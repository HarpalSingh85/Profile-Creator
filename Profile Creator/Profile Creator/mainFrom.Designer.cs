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
            this.chkBoxfullProvision = new System.Windows.Forms.CheckBox();
            this.cmbBoxProfleType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbBoxLocation = new System.Windows.Forms.ComboBox();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lstBoxDisplay = new System.Windows.Forms.ListBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentDC = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCurrentDC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkBoxfullProvision);
            this.groupBox1.Controls.Add(this.cmbBoxProfleType);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.cmbBoxLocation);
            this.groupBox1.Controls.Add(this.txtBoxUser);
            this.groupBox1.Controls.Add(this.lblLocation);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkBoxfullProvision
            // 
            this.chkBoxfullProvision.AutoSize = true;
            this.chkBoxfullProvision.Font = new System.Drawing.Font("Arial", 9F);
            this.chkBoxfullProvision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkBoxfullProvision.Location = new System.Drawing.Point(352, 73);
            this.chkBoxfullProvision.Name = "chkBoxfullProvision";
            this.chkBoxfullProvision.Size = new System.Drawing.Size(151, 19);
            this.chkBoxfullProvision.TabIndex = 6;
            this.chkBoxfullProvision.Text = "Complete Provisioning";
            this.chkBoxfullProvision.UseVisualStyleBackColor = true;
            // 
            // cmbBoxProfleType
            // 
            this.cmbBoxProfleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxProfleType.FormattingEnabled = true;
            this.cmbBoxProfleType.Location = new System.Drawing.Point(61, 43);
            this.cmbBoxProfleType.Name = "cmbBoxProfleType";
            this.cmbBoxProfleType.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxProfleType.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 9F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblType.Location = new System.Drawing.Point(6, 46);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(32, 15);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // cmbBoxLocation
            // 
            this.cmbBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLocation.FormattingEnabled = true;
            this.cmbBoxLocation.Location = new System.Drawing.Point(61, 74);
            this.cmbBoxLocation.Name = "cmbBoxLocation";
            this.cmbBoxLocation.Size = new System.Drawing.Size(151, 21);
            this.cmbBoxLocation.TabIndex = 3;
            this.cmbBoxLocation.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLocation_SelectedIndexChanged);
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtBoxUser.Location = new System.Drawing.Point(61, 12);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(90, 21);
            this.txtBoxUser.TabIndex = 2;
            this.txtBoxUser.TextChanged += new System.EventHandler(this.txtBoxUser_TextChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Arial", 9F);
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblLocation.Location = new System.Drawing.Point(6, 77);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(54, 15);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 9F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblUser.Location = new System.Drawing.Point(6, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(49, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User ID";
            // 
            // lstBoxDisplay
            // 
            this.lstBoxDisplay.Font = new System.Drawing.Font("Arial", 9F);
            this.lstBoxDisplay.FormattingEnabled = true;
            this.lstBoxDisplay.ItemHeight = 15;
            this.lstBoxDisplay.Location = new System.Drawing.Point(12, 120);
            this.lstBoxDisplay.Name = "lstBoxDisplay";
            this.lstBoxDisplay.Size = new System.Drawing.Size(505, 94);
            this.lstBoxDisplay.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatuslbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 262);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(530, 22);
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
            this.btnProceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
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
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnExit.Location = new System.Drawing.Point(447, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(282, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Connected To :";
            // 
            // lblCurrentDC
            // 
            this.lblCurrentDC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentDC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDC.Location = new System.Drawing.Point(376, 14);
            this.lblCurrentDC.Name = "lblCurrentDC";
            this.lblCurrentDC.Size = new System.Drawing.Size(117, 22);
            this.lblCurrentDC.TabIndex = 8;
            this.lblCurrentDC.Text = "#";
            this.lblCurrentDC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 284);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lstBoxDisplay);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Label lblCurrentDC;
        private System.Windows.Forms.Label label1;
    }
}


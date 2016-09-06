namespace NetStudio
{
    partial class Splash
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
            this.panelSplash = new System.Windows.Forms.Panel();
            this.labelSupport = new System.Windows.Forms.Label();
            this.linkLabelCodingCraft = new System.Windows.Forms.LinkLabel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSplash.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSplash
            // 
            this.panelSplash.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelSplash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSplash.Controls.Add(this.labelSupport);
            this.panelSplash.Controls.Add(this.linkLabelCodingCraft);
            this.panelSplash.Controls.Add(this.textBoxDescription);
            this.panelSplash.Controls.Add(this.labelCompanyName);
            this.panelSplash.Controls.Add(this.labelCopyright);
            this.panelSplash.Controls.Add(this.labelVersion);
            this.panelSplash.Controls.Add(this.labelProductName);
            this.panelSplash.Controls.Add(this.buttonClose);
            this.panelSplash.Location = new System.Drawing.Point(0, 0);
            this.panelSplash.Name = "panelSplash";
            this.panelSplash.Size = new System.Drawing.Size(500, 300);
            this.panelSplash.TabIndex = 8;
            // 
            // labelSupport
            // 
            this.labelSupport.AutoSize = true;
            this.labelSupport.Location = new System.Drawing.Point(10, 180);
            this.labelSupport.Name = "labelSupport";
            this.labelSupport.Size = new System.Drawing.Size(44, 13);
            this.labelSupport.TabIndex = 16;
            this.labelSupport.Text = "Contact";
            // 
            // linkLabelCodingCraft
            // 
            this.linkLabelCodingCraft.AutoSize = true;
            this.linkLabelCodingCraft.Location = new System.Drawing.Point(110, 180);
            this.linkLabelCodingCraft.Name = "linkLabelCodingCraft";
            this.linkLabelCodingCraft.Size = new System.Drawing.Size(118, 13);
            this.linkLabelCodingCraft.TabIndex = 15;
            this.linkLabelCodingCraft.TabStop = true;
            this.linkLabelCodingCraft.Text = "anton.fadin@gmail.com";
            this.linkLabelCodingCraft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCodingCraft_LinkClicked);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Location = new System.Drawing.Point(255, 126);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(240, 109);
            this.textBoxDescription.TabIndex = 14;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(10, 130);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(79, 13);
            this.labelCompanyName.TabIndex = 13;
            this.labelCompanyName.Text = "CompanyName";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(10, 275);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(51, 13);
            this.labelCopyright.TabIndex = 12;
            this.labelCopyright.Text = "Copyright";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(110, 155);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 13);
            this.labelVersion.TabIndex = 11;
            this.labelVersion.Text = "Version";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(10, 155);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(72, 13);
            this.labelProductName.TabIndex = 10;
            this.labelProductName.Text = "ProductName";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(406, 264);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(89, 31);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.panelSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Splash";
            this.panelSplash.ResumeLayout(false);
            this.panelSplash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSplash;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.LinkLabel linkLabelCodingCraft;
        private System.Windows.Forms.Label labelSupport;

    }
}
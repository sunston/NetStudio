namespace NetStudio
{
    partial class LanguageForm
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
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.radioButtonCSharp = new System.Windows.Forms.RadioButton();
            this.radioButtonVBNET = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLanguage
            // 
            this.panelLanguage.Controls.Add(this.radioButtonVBNET);
            this.panelLanguage.Controls.Add(this.radioButtonCSharp);
            this.panelLanguage.Location = new System.Drawing.Point(10, 8);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(97, 68);
            this.panelLanguage.TabIndex = 0;
            // 
            // radioButtonCSharp
            // 
            this.radioButtonCSharp.AutoSize = true;
            this.radioButtonCSharp.Checked = true;
            this.radioButtonCSharp.Location = new System.Drawing.Point(20, 7);
            this.radioButtonCSharp.Name = "radioButtonCSharp";
            this.radioButtonCSharp.Size = new System.Drawing.Size(39, 17);
            this.radioButtonCSharp.TabIndex = 0;
            this.radioButtonCSharp.TabStop = true;
            this.radioButtonCSharp.Text = "C#";
            this.radioButtonCSharp.UseVisualStyleBackColor = true;
            // 
            // radioButtonVBNET
            // 
            this.radioButtonVBNET.AutoSize = true;
            this.radioButtonVBNET.Location = new System.Drawing.Point(20, 37);
            this.radioButtonVBNET.Name = "radioButtonVBNET";
            this.radioButtonVBNET.Size = new System.Drawing.Size(64, 17);
            this.radioButtonVBNET.TabIndex = 1;
            this.radioButtonVBNET.TabStop = true;
            this.radioButtonVBNET.Text = "VB.NET";
            this.radioButtonVBNET.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(133, 8);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(93, 31);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(133, 45);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 31);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 87);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panelLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LanguageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выберите язык программирования";
            this.panelLanguage.ResumeLayout(false);
            this.panelLanguage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.RadioButton radioButtonVBNET;
        private System.Windows.Forms.RadioButton radioButtonCSharp;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}
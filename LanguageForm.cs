using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NetStudio.Document; 

namespace NetStudio
{
    public partial class LanguageForm : Form
    {
        private bool m_Result = false;

        public LanguageForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            m_Result = true;
            this.Close(); 
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Result
        {
            get { return m_Result; }
        }

        public CCSLanguage Language
        {
            get
            {
                if (radioButtonCSharp.Checked)
                    return CCSLanguage.CSharp;
                else
                    return CCSLanguage.VisualBasic;  
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassSSH
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            lblAbout.Text = String.Format(lblAbout.Text, Application.ProductVersion);
        }

        private void lnklblMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + lnklblMail.Tag);
        }
    }
}

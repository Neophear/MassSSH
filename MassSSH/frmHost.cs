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
    public partial class frmHost : Form
    {
        public Host host;

        public frmHost(Host h)
        {
            InitializeComponent();

            host = h;
            txtAddress.Text = host.Address;
            txtName.Text = host.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                host.Address = txtAddress.Text;
                host.Name = txtName.Text;

                DialogResult = DialogResult.OK;
            }
            catch (NoValueException)
            {
                txtAddress.BackColor = Color.LightPink;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

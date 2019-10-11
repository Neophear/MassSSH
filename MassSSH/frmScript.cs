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
    public partial class frmScript : Form
    {
        Script script;

        public frmScript(Script s)
        {
            InitializeComponent();
            script = s;
            txtName.Text = s.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                script.Name = txtName.Text;
                DialogResult = DialogResult.OK;
            }
            catch (NoValueException)
            {
                txtName.BackColor = Color.LightPink;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

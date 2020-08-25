using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit
{
    public partial class frmStringsGuiScriptsPrefixDialog : Form
    {
        public string prefix = "";
        public frmStringsGuiScriptsPrefixDialog()
        {
            InitializeComponent();

            this.buttonOk.DialogResult = DialogResult.OK;
            this.buttonCancel.DialogResult = DialogResult.Cancel;
        }

        private void textBoxPrefix_TextChanged(object sender, EventArgs e)
        {
            prefix = this.textBoxPrefix.Text;
        }
    }
}

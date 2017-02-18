using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.Properties;

namespace W3Edit
{
    public partial class frmWCCLicense : Form
    {
        public frmWCCLicense()
        {
            InitializeComponent();
            richTextBox1.LoadFile(new MemoryStream(Encoding.UTF8.GetBytes(Resources.wcc_eula)),RichTextBoxStreamType.RichText);
        }
    }
}

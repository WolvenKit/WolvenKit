using System.IO;
using System.Text;
using System.Windows.Forms;
using RtfPipe;
using WolvenKit.Properties;

namespace WolvenKit
{
    public partial class frmWCCLicense : Form
    {
        public frmWCCLicense()
        {
            InitializeComponent();
            browserwcclicense.DocumentText = Rtf.ToHtml(new RtfSource(new StreamReader(Resources.wcc_eula)));
        }
    }
}

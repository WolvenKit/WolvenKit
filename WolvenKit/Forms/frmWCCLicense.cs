using System.IO;
using System.Text;
using System.Windows.Forms;
using RtfPipe;
using RtfPipe.Support;
using WolvenKit.Properties;

namespace WolvenKit
{
    public partial class frmWCCLicense : Form
    {
        public frmWCCLicense()
        {
            InitializeComponent();
            browserwcclicense.DocumentText = Rtf.ToHtml(new RtfSource(new MemoryStream(Encoding.UTF8.GetBytes(Resources.wcc_eula))));
        }
    }
}

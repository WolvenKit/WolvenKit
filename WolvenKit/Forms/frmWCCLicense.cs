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
            using (var reader = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(Resources.wcc_eula))))
            {
                browserwcclicense.DocumentText = Rtf.ToHtml(new RtfSource(reader));
            }
        }
    }
}

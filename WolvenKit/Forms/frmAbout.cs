using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WolvenKit
{
    partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            Text = string.Format("About {0}", AssemblyTitle);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = string.Format("Version {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyTrademark;
            
            webBrowser1.DocumentText = $@"

    <body bgcolor={ColorTranslator.ToHtml(SystemColors.Control)}>
        <center>
        <h3>Credits</h3> <br>   
        Project lead: Traderain<br><br>
        kote2ster<br>
        (Major programming&Reverse engineering)<br><br> 
        Nightingale<br>
        (Major reverse enginering)<br><br> 
        Murzinio<br>
        (Programming)<br><br> 
        rfuzzo<br>
        (Programming)<br><br> 
        <br><br>
        <b>Based on the code from {"\"Sarcen's Witcher 3 Mod Editor\""} by Sarcen </b><br>
        <h3>Special thanks to</h3><br>
        SkacikPL<br>
        KNG<br>
        erx<br>
        rmemr<br>
        Cthulhu<br>
        <center>
    <body>
";
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof (AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    var titleAttribute = (AssemblyTitleAttribute) attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }

        public string AssemblyDescription
        {
            get
            {
                var attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute) attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof (AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute) attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof (AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute) attributes[0]).Copyright;
            }
        }

        public string AssemblyTrademark
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof (AssemblyTrademarkAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyTrademarkAttribute) attributes[0]).Trademark;
            }
        }

        #endregion
    }
}
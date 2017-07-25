using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace WolvenKit
{
    public partial class frmInstallPackage : Form
    {
        public frmInstallPackage(string PackageFile)
        {
            InitializeComponent();
            authorLBL.Parent = backgroundimagePB;
            authorLBL.BackColor = Color.Transparent;
            modnameLBL.Parent = backgroundimagePB;
            modnameLBL.BackColor = Color.Transparent;
            try
            {
                FileStream fs = File.OpenRead(PackageFile);
                var zf = new ZipFile(fs);
                foreach (ZipEntry zipEntry in zf)
                {
                    if (!zipEntry.IsFile)
                    {
                        continue;
                    }
                    String entryFileName = zipEntry.Name;
                    if (entryFileName == "Assembly.xml")
                    {
                        byte[] buffer = new byte[4096];
                        Stream zipStream = zf.GetInputStream(zipEntry);
                        using (var ms = new MemoryStream())
                        {
                            StreamUtils.Copy(zipStream, ms, buffer);
                            ParseAssemblyInfo(ms.ToArray());
                        }
                    }
                    if (Path.GetFileNameWithoutExtension(entryFileName) == "Icon")
                    {
                        byte[] buffer = new byte[4096];
                        Stream zipStream = zf.GetInputStream(zipEntry);
                        using (var ms = new MemoryStream())
                        {
                            StreamUtils.Copy(zipStream, ms, buffer);
                            logoPB.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to load the package!");
                this.Close();
            }
        }

        public void ParseAssemblyInfo(byte[] Contents)
        {
            var data = XDocument.Load(new MemoryStream(Contents));
            this.Text = data.Root.Attribute("name").Value + " - Package Installer";
            modnameLBL.Text = data.Root.Attribute("name")?.Value;
            Version v = Version.Parse(data.Root.Attribute("version")?.Value ?? "1.0");

            var metanode = data.Root.Element("metadata");
            authorLBL.Text = metanode?.Element("author")?.Element("displayName")?.Value;

            var colornode = data.Root.Element("colors");
            backgroundimagePB.BackColor = ColorTranslator.FromHtml(colornode?.Element("headerBackground")?.Value ?? "0xFFFFFFFF");
            logoPB.BackColor = ColorTranslator.FromHtml(colornode?.Element("iconBackground")?.Value ?? "0xFFFFFFFF");
            if (colornode?.Element("headerBackground")?.Element("useBlackTextColor")?.Value == "true")
            {
                modnameLBL.ForeColor = Color.Black;
                authorLBL.ForeColor = Color.Black;

            }
            else
            {
                modnameLBL.ForeColor = Color.White;
                authorLBL.ForeColor = Color.White;
            }
            detailWB.DocumentText = $@"<html>
<body>
    <h3>Mod description</h3>
    <p>{metanode?.Element("description")}</p>
    <hr>
    <h3>Aditional information</h3>
    <p>Created by {metanode?.Element("author")?.Element("displayName")?.Value}<br>
    Version {v}<br>License {metanode?.Element("license")?.Value}</p>
    <hr>
</body>
</html>";
        }

        private void installBTN_Click(object sender, EventArgs e)
        {
            //TODO: Once we changed how we pack mods install the mod.
            //Maybe displaying a donation url or something would be nice too.
        }
    }
}

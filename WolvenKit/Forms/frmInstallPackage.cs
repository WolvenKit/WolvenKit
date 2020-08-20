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
using WolvenKit.App;

namespace WolvenKit
{
    public partial class frmInstallPackage : Form
    {
        public string package;
        public string actionlink;

        public frmInstallPackage(string PackageFile)
        {
            InitializeComponent();
            package = PackageFile;
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
                            logoPB.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to load the package!\n" + e.Message);
                this.Close();
            }
        }

        public void ParseAssemblyInfo(byte[] Contents)
        {
            var data = XDocument.Load(new MemoryStream(Contents));
            this.Text = data.Root.Attribute("name").Value + " - Package Installer";
            modnameLBL.Text = data.Root.Attribute("name")?.Value;
            String v = (data.Root.Attribute("version")?.Value ?? "1.0");

            var metanode = data.Root.Element("metadata");
            authorLBL.Text = metanode?.Element("author")?.Element("displayName")?.Value;

            var colornode = data.Root.Element("colors");
            backgroundimagePB.BackColor =
                ColorTranslator.FromHtml(colornode?.Element("headerBackground")?.Value ?? "0xFFFFFFFF");
            logoPB.BackColor = ColorTranslator.FromHtml(colornode?.Element("iconBackground")?.Value ?? "0xFFFFFFFF");
            if (colornode?.Element("headerBackground")?.Attribute("useBlackTextColor")?.Value == "true")
            {
                modnameLBL.ForeColor = Color.Black;
                authorLBL.ForeColor = Color.Black;

            }
            else
            {
                modnameLBL.ForeColor = Color.White;
                authorLBL.ForeColor = Color.White;
            }

            List<string> adition = new List<string>();
            if (metanode?.Element("author")?.Element("twitter")?.Value != "")
                adition.Add(
                    $@"<a href={"\"" + metanode?.Element("author")?.Element("twitter")?.Value + "\""} target={
                            "\"_blank\""
                        }>Twitter</a>");
            if (metanode?.Element("author")?.Element("web")?.Value != "")
                adition.Add(
                    $@"<a href={
                            "\"" + metanode?.Element("author")?.Element("web")?.Value + "\""
                        } target={"\"_blank\""}>Website</a>");
            if (metanode?.Element("author")?.Element("facebook")?.Value != "")
                adition.Add(
                    $@"<a href={"\"" + metanode?.Element("author")?.Element("facebook")?.Value + "\""} target={
                            "\"_blank\""
                        }>Facebook</a>");
            if (metanode?.Element("author")?.Element("youtube")?.Value != "")
                adition.Add(
                    $@"<a href={"\"" + metanode?.Element("author")?.Element("youtube")?.Value + "\""} target={
                            "\"_blank\""
                        }>YouTube</a>");
            var authorlink = metanode?.Element("author")?.Element("displayName")?.Value;
            if (metanode?.Element("author")?.Element("actionLink")?.Value != "")
                authorlink =
                    $@"<a href={"\"" + metanode?.Element("author")?.Element("actionLink")?.Value + "\""} target={
                            "\"_blank\""
                        }>{metanode?.Element("author")?.Element("displayName")?.Value}</a>";
            actionlink = metanode?.Element("author")?.Element("actionLink")?.Value;
            detailWB.DocumentText = $@"
<html>
<body>
    {metanode?.Element("description")}
    <hr>
    <h3>Aditional information</h3>
    <table>
        <tr>
            <td valign=""top"">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td valign=""top"">
                <b>Learn more</b><br>
            </td>
        </tr>
        <tr>
            <td valign=""top"">
                <b>Created by</b> {authorlink}<br>
                <b>Version</b> {v}<br>
                <b>License</b> {metanode?.Element("license")?.Value}
            </td>
            <td>
                &nbsp;
            </td>
            <td valign=""top"">


                {adition.Aggregate("", (c, n) => c += "<br>" + n)}
            </td>
        </tr>
    </table>
    <hr>
</body>
</html>";
        }

        private void installBTN_Click(object sender, EventArgs e)
        {
            //Actually install the mod
            try
            {
                FileStream fs = File.OpenRead(package);
                var zf = new ZipFile(fs);
                foreach (ZipEntry zipEntry in zf)
                {
                    if (!zipEntry.IsFile)
                    {
                        continue;
                    }

                    String entryFileName = zipEntry.Name;
                    if (!entryFileName.StartsWith("Icon") && entryFileName != "Assembly.xml")
                    {
                        byte[] buffer = new byte[4096];
                        Stream zipStream = zf.GetInputStream(zipEntry);
                        Directory.CreateDirectory(Path.GetDirectoryName(
                            Path.Combine(MainController.Get().Configuration.GameRootDir, entryFileName)));
                        using (var f = new FileStream(Path.Combine(MainController.Get().Configuration.GameRootDir,entryFileName),FileMode.Create))
                        {
                            StreamUtils.Copy(zipStream, f, buffer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load the package!\n" + ex.Message);
                this.Close();
            }

            if (MessageBox.Show($@"Installed sucesfully!
(Please always check your files after installing mods).
Modding requires a great deal of work. Please consider donating to the mod's author. (Click yes to do so)", "Info",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(actionlink);
            }
        }
    }
}

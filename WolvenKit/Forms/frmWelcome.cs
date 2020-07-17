using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VisualPlus.Extensibility;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;

namespace WolvenKit.Forms
{
    public partial class frmWelcome : DockContent
    {
        internal class RecentFileObject
        {
            public RecentFileObject(string path)
            {
                Fullpath = path;
            }

            public string Fullpath { get; set; }
            [OLVColumn()]
            public string Filename => Path.GetFileName(Fullpath);
        }

        internal class LinkObject
        {
            public LinkObject(string title, string link, string description = "")
            {
                Title = title;
                Description = description;
                Link = link;
            }

            public string Title { get; set; }
            public string Description { get; set; }
            public string Link { get; set; }
        }


        frmMain main;
        public frmWelcome(frmMain mainref)
        {
            main = mainref;
            InitializeComponent();

            ApplyCustomTheme();
            checkBoxDisable.Checked = MainController.Get().Configuration.IsWelcomeFormDisabled;

            //populate recent files
            var recentfiles = new List<RecentFileObject>();
            if (File.Exists("recent_files.xml"))
            {
                var doc = XDocument.Load("recent_files.xml");
                foreach (var f in doc.Descendants("recentfile"))
                {
                    var fullpath = f.Value;
                    var it = new ListViewItem()
                    {
                        Text = Path.GetFileName(fullpath),
                        Tag = fullpath,
                        ToolTipText = fullpath
                    };
                    recentfiles.Add( new RecentFileObject(fullpath));
                }
            }
            objectListView1.SetObjects(recentfiles);
            objectListView1.RefreshObjects(recentfiles);

            //populate help links
            var helplinks = new List<LinkObject>();
            helplinks.Add(new LinkObject("GitHub repository", "https://github.com/Traderain/Wolven-kit"));
            helplinks.Add(new LinkObject("WolvenKit wiki", "https://github.com/Traderain/Wolven-kit/wiki"));

            //populate tutorial links
            var bgcolor = UIController.Get().GetTheme().ColorPalette.ToolWindowTabSelectedInactive.Background;
            var bgcolorhtml = bgcolor.ToHTML();

            webBrowser1.DocumentText = $@"
<html>
    <body {"style = \" background:" } {bgcolorhtml} {"\""} >
        <li><a href = ${"\"https://github.com/Traderain/Wolven-kit/wiki\""}> WolvenKit Wiki </a></li>
        <li><a href = ${"\"https://github.com/Traderain/Wolven-kit\""}> GitHub Repository </a></li>
    </body>
</html>
          ";


            webBrowser2.DocumentText = $@"
<html>
    <body {"style = \" background:" } {bgcolorhtml} {"\""} >
        <li><a href = ${"\"https://www.youtube.com/watch?v=jUoamicYtjk\""}> Package creation </a></li>
        <li><a href = ${"\"https://www.youtube.com/watch?v=jUoamicYtjk\""}> Sound modding </a></li>
    </body>
</html>
          ";
        }

        protected void ApplyCustomTheme()
        {
            var theme = UIController.Get().GetTheme();

            this.BackColor = theme.ColorPalette.ToolWindowTabSelectedInactive.Background;

            // recent file list
            this.objectListView1.BackColor = theme.ColorPalette.ToolWindowTabSelectedInactive.Background;
            this.objectListView1.ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text;
            objectListView1.UnfocusedSelectedBackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background;

            checkBoxDisable.BackColor = theme.ColorPalette.ToolWindowTabSelectedInactive.Background;
            checkBoxDisable.ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text;

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            main.CreateNewMod();
            this.Close();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if(e.Url.AbsoluteUri.ToString().Length > 0 && !e.Url.AbsoluteUri.ToString().StartsWith("about:blank"))
            {
                e.Cancel = true;
                string url = new String(e.Url.AbsoluteUri.ToArray().Skip(6).Skip(4).Reverse().Skip(3).Reverse().ToArray()).Trim().TrimStart('$', '\\').ToString();
                System.Diagnostics.Process.Start(url);
            }
        }

        private void frmWelcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save disable option
            MainController.Get().Configuration.IsWelcomeFormDisabled = checkBoxDisable.Checked;
            MainController.Get().Configuration.Save();
        }

        private void OpenProjectButton_Click(object sender, EventArgs e)
        {
            main.OpenMod();
            this.Close();
        }

        private void visualButton1_Click_1(object sender, EventArgs e)
        {
            var settings = new frmSettings();
            settings.ShowDialog();
        }

        private void objectListView1_FormatCell(object sender, FormatCellEventArgs e)
        {
            if (e.ColumnIndex == this.olvColumn1.Index)
            {
                e.Item.ForeColor = SystemColors.Highlight;
                e.Item.Font = new Font(e.Item.Font, FontStyle.Bold);
            }
        }

        private void objectListView1_CellClick(object sender, CellClickEventArgs e)
        {
            if (((BrightIdeasSoftware.ObjectListView)sender).SelectedObject != null)
            {
                main.OpenMod((((BrightIdeasSoftware.ObjectListView)sender).SelectedObject as RecentFileObject).Fullpath);
                this.Close();
            }
        }

        private void objectListView1_CellOver(object sender, CellOverEventArgs e)
        {
            //if (e.ColumnIndex == this.olvColumn1.Index)
            //    Cursor.Current = Cursors.Hand;
            //else
            //    Cursor.Current = Cursors.Default;
        }

        private void objectListView1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void objectListView1_CellToolTipShowing(object sender, ToolTipShowingEventArgs e)
        {
            if (e.ColumnIndex == this.olvColumn1.Index)
                Cursor.Current = Cursors.Hand;
        }
    }
}

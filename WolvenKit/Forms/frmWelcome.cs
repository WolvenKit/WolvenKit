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
        }

        private string DocumentText => $@"
<html>
    <head>
        <style>
            body {{ 
                font-family: Calibri, sans-serif; 
                background: { UIController.GetBackColor().ToHTML() }; 
            }} 
            
        </style> 
    </head>
    <body>
        <li><a href = ${"\"https://github.com/Traderain/Wolven-kit/wiki\""}> WolvenKit Wiki </a></li>
        <li><a href = ${"\"https://github.com/Traderain/Wolven-kit\""}> GitHub Repository </a></li>
        <li><a href = ${"\"https://www.youtube.com/watch?v=jUoamicYtjk\""}> Package creation </a></li>
        <li><a href = ${"\"https://www.youtube.com/watch?v=jUoamicYtjk\""}> Sound modding </a></li>
    </body>
</html>
          ";


        protected void ApplyCustomTheme()
        {
            this.BackColor = UIController.GetBackColor();
            this.mainMenuStrip.BackColor = UIController.GetBackColor();

            // recent file list
            this.objectListView1.BackColor = UIController.GetBackColor();
            this.objectListView1.ForeColor = UIController.GetForeColor();
//            objectListView1.UnfocusedSelectedBackColor = UIController.GetPalette().CommandBarToolbarButtonPressed.Background;

            checkBoxDisable.BackColor = UIController.GetBackColor();
            checkBoxDisable.ForeColor = UIController.GetForeColor();

            newProjectBtn.BackColor = UIController.GetPalette().ToolWindowTabUnselected.Background;
//            newProjectBtn.BackColor.Pressed = UIController.GetPalette().CommandBarMenuDefault.Background;
            newProjectBtn.ForeColor = UIController.GetPalette().TabUnselected.Text;
            newProjectBtn.FlatAppearance.BorderColor = UIController.GetBackColor();

            openProjectBtn.BackColor = UIController.GetPalette().ToolWindowTabUnselected.Background;
//            openProjectBtn.BackColor.Pressed = UIController.GetPalette().CommandBarMenuDefault.Background;
            openProjectBtn.ForeColor = UIController.GetPalette().TabUnselected.Text;
            openProjectBtn.FlatAppearance.BorderColor = UIController.GetBackColor();

            preferencesBtn.BackColor = UIController.GetPalette().ToolWindowTabUnselected.Background;
//            preferencesBtn.BackColor.Pressed = UIController.GetPalette().CommandBarMenuDefault.Background;
            preferencesBtn.ForeColor = UIController.GetPalette().TabUnselected.Text;
            preferencesBtn.FlatAppearance.BorderColor = UIController.GetBackColor();

            continueWithoutProjectBtn.ForeColor = UIController.GetPalette().TabButtonSelectedInactivePressed.Glyph;

            wolvenKitLbl.ForeColor = UIController.GetForeColor();

            helpWebBrowser.DocumentText = DocumentText;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
      
        // UI Events //
        
        private void mainMenuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void wolvenKitLbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void communityToolsLbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            main.CreateNewMod();
            this.Close();
        }

        private void newProjectBtn_MouseEnter(object sender, EventArgs e)
        {
            newProjectBtn.BackColor = UIController.GetPalette().ToolWindowTabUnselectedHovered.Background;
        }

        private void newProjectBtn_MouseLeave(object sender, EventArgs e)
        {
            newProjectBtn.BackColor = UIController.GetPalette().ToolWindowTabUnselected.Background;
        }

        private void openProjectBtn_Click(object sender, EventArgs e)
        {
            main.OpenMod();
            this.Close();
        }

        private void openProjectBtn_MouseEnter(object sender, EventArgs e)
        {
            openProjectBtn.BackColor = UIController.GetPalette().ToolWindowTabUnselectedHovered.Background;
        }

        private void openProjectBtn_MouseLeave(object sender, EventArgs e)
        {
            openProjectBtn.BackColor = UIController.GetPalette().ToolWindowTabUnselected.Background;
        }

        private void preferencesBtn_Click(object sender, EventArgs e)
        {
            var settings = new frmSettings();
            settings.RequestApplyTheme += ApplyCustomTheme;


            settings.ShowDialog();
        }

        private void preferencesBtn_MouseEnter(object sender, EventArgs e)
        {
            preferencesBtn.BackColor = UIController.GetPalette().ToolWindowTabUnselectedHovered.Background;
        }

        private void preferencesBtn_MouseLeave(object sender, EventArgs e)
        {
            preferencesBtn.BackColor = UIController.GetPalette().ToolWindowTabUnselected.Background;
        }

        private void continueWithoutProjectBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void continueWithoutProjectBtn_Enter(object sender, EventArgs e)
        {
            continueWithoutProjectBtn.ForeColor = UIController.GetPalette().MainWindowStatusBarDefault.Background;
        }

        private void continueWithoutProjectBtn_Leave(object sender, EventArgs e)
        {
            continueWithoutProjectBtn.ForeColor = UIController.GetPalette().TabButtonSelectedInactivePressed.Glyph;
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


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

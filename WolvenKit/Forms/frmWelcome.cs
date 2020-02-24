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

namespace WolvenKit.Forms
{
    public partial class frmWelcome : Form
    {
        frmMain main;
        public frmWelcome(frmMain mainref)
        {
            main = mainref;
            InitializeComponent();
            recentfilesListView.DoubleClick += RecentFile_click;
            recentfilesListView.MultiSelect = false;
            recentfilesListView.Items.Clear();
            if (File.Exists("recent_files.xml"))
            {
                var doc = XDocument.Load("recent_files.xml");
                recentfilesListView.Enabled = doc.Descendants("recentfile").Any();
                foreach (var f in doc.Descendants("recentfile"))
                {
                    var it = new ListViewItem(f.Value);
                    recentfilesListView.Items.Add(it);
                }
                recentfilesListView.Enabled = true;
            }
            else
            {
                recentfilesListView.Enabled = false;
            }
            webBrowser1.DocumentText = $@"
<html>
    <head>
         <title>
             Welcome page
         </title>
        </head>
        <body>
        <center>
            Welcome to Wolven kit. This tool will help you with modding {"\"The Witcher 3\""}. Here you can find links to tutorial and getting started.
        </center>
        <h3><strong> Tutorials </strong></h3>
            <ul>
                <li><a href = ${"\"https://www.youtube.com/watch?v=jUoamicYtjk\""}> Package creation </a></li>
       
                       <li> Please stay tuned for more tutorials in the future </li>
          
                      </ul>
          
              </body>
          </html>
          ";
        }

        private void RecentFile_click(object sender, EventArgs e)
        {
            if(recentfilesListView.SelectedItems.Count> 0)
            {
                main.openMod(recentfilesListView.SelectedItems[0].Text);
                this.Close();
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            main.createNewMod();
            this.Close();
        }

        private void visualButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void visualButton2_Click(object sender, EventArgs e)
        {
            main.openMod();
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
    }
}

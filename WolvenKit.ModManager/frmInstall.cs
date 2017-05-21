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
using ICSharpCode.SharpZipLib.Zip;

namespace WolvenKit.ModManager
{
    public partial class frmInstall : Form
    {
        public frmInstall(string filename)
        {
            InitializeComponent();
            this.Text = "Installing: " + Path.GetFileName(filename);
            Init(filename);
        }

        public void Init(string filename)
        {
            var instream = new ZipInputStream(new FileStream(filename, FileMode.Open));
            ZipEntry zipEntry = instream.GetNextEntry();
            var files = new List<string>();
            while (zipEntry != null)
            {
                String entryFileName = zipEntry.Name;
                if (entryFileName.EndsWith(".w3modproj"))
                {
                    //TODO: Load the xdocument.
                }
                else
                {
                    files.Add(entryFileName);
                }
                zipEntry = instream.GetNextEntry();
            }
            FilesTreeView.Nodes.AddRange(files.Select(y=> new TreeNode(y)).ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Add to entries to virtually install
        }
    }
}

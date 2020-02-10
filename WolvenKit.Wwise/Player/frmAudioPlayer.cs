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
using System.Diagnostics;

namespace WolvenKit.Wwise.Player
{
    public partial class frmAudioPlayer : Form
    {
        const string wdir = "vgmstream\\AudioWorkingDir\\";
        string audiofile;

        public frmAudioPlayer(string file)
        {
            InitializeComponent();
            audiofile = file;
            this.Text = "Sound preview - " + file + "[CONVERTING]";            
        }

        private void FilesListView_DoubleClick(object sender, EventArgs e)
        {
            if(FilesListView.SelectedItems.Count > 0)
            {
                AudioPlayer.fileName = FilesListView.SelectedItems[0].Tag.ToString();
                AudioPlayer.OnButtonPlayClick(this, null);
            }
        }

        private void frmAudioPlayer_Shown(object sender, EventArgs e)
        {
            //Clean the working directory on every start
            Directory.CreateDirectory(wdir);
            foreach (var f in Directory.GetFiles(wdir))
            {
                File.Delete(f);
            }
            string outf = Path.Combine(wdir, Path.GetFileNameWithoutExtension(audiofile) + ".wav");
            string arg = audiofile + " -o " + outf;
            var si = new ProcessStartInfo(
                    "vgmstream\\test.exe",
                    arg
                );
            si.CreateNoWindow = true;
            si.WindowStyle = ProcessWindowStyle.Hidden;
            si.UseShellExecute = false;
            var proc = Process.Start(si);
            proc.WaitForExit(1000);
            this.Text = "Sound preview - " + audiofile + "[DONE]";
            FilesListView.Items.Clear();
            foreach (var f in Directory.GetFiles(wdir))
            {
                var lvi = new ListViewItem(Path.GetFileName(f));
                lvi.Tag = f;
                FilesListView.Items.Add(lvi);
            }
        }
    }
}

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
using WolvenKit.Wwise.Wwise;

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
            Directory.CreateDirectory("bnkext");
            foreach (var f in Directory.GetFiles("bnkext").ToList().Where(x => Path.GetFileName(x) != "bnkextr.exe"))
            {
                File.Delete(f);
            }

            //Clean the working directory on every start
            Directory.CreateDirectory(wdir);
            foreach (var f in Directory.GetFiles(wdir))
            {
                File.Delete(f);
            }
            
            if (Path.GetExtension(audiofile) == ".bnk")
            {
                string arg = audiofile;
                var si = new ProcessStartInfo(
                        "bnkextr.exe",
                        arg
                    );
                si.CreateNoWindow = true;
                si.WorkingDirectory = "bnkext";
                si.WindowStyle = ProcessWindowStyle.Hidden;
                si.UseShellExecute = true;
                var proc = Process.Start(si);
                proc.WaitForExit(-1);
                foreach (var af in Directory.GetFiles("bnkext", "*.wem", SearchOption.AllDirectories))
                {
                    string outf = Path.Combine(wdir, Path.GetFileNameWithoutExtension(af) + ".wav");
                    arg = af + " -o " + outf;
                    si = new ProcessStartInfo(
                            "vgmstream\\test.exe",
                            arg
                        );
                    si.CreateNoWindow = true;
                    si.WindowStyle = ProcessWindowStyle.Hidden;
                    si.UseShellExecute = false;
                    proc = Process.Start(si);
                    proc.WaitForExit(-1);
                }

            }
            else if (Path.GetExtension(audiofile) == ".wem")
            {
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
                proc.WaitForExit();
            }
            else
            {
                MessageBox.Show("Invalid file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            
            this.Text = "Sound preview - " + audiofile + $" - [DONE]";
            FilesListView.Items.Clear();
            foreach (var f in Directory.GetFiles(wdir))
            {
                var lvi = new ListViewItem(Path.GetFileName(f));
                lvi.Tag = f;
                FilesListView.Items.Add(lvi);
            }

            if(FilesListView.Items.Count > 0)
            {
                FilesListView.Items[0].Selected = true;
                AudioPlayer.fileName = FilesListView.SelectedItems[0].Tag.ToString();
                AudioPlayer.OnButtonPlayClick(this, null);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (!audiofile.EndsWith(".wem"))
            {
                MessageBox.Show("Only wem file replacement supported currently!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var of = new OpenFileDialog())
            {
                of.Filter = "Wwise wem files | *.wem";
                of.Multiselect = false;
                if (of.ShowDialog() == DialogResult.OK)
                {
                    var mf = of.FileName;
                    Console.WriteLine("Original file: " + audiofile);
                    Console.WriteLine("Modified file: " + mf);

                    var input = new WemFile();
                    input.LoadFromFile(audiofile, WwAudioFileType.Wem);
                    var output = new WemFile();
                    output.LoadFromFile(mf, WwAudioFileType.Wem);
                    Console.WriteLine("Files loaded!");

                    output.merge_headers(input);
                    output.Merge_Datas(input);
                    output.Calculate_Riff_Size();

                    // Backup
                    File.Move(audiofile, audiofile + ".bak");

                    File.Delete(audiofile);

                    output.WriteToFile(audiofile);

                    MessageBox.Show("Completed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            if (!audiofile.EndsWith(".wem"))
            {
                MessageBox.Show("Only wem file replacement supported currently!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (var of = new OpenFileDialog())
                {

                    of.Filter = "Wav audio files | *.wav";
                    of.Multiselect = false;
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        var wav = of.FileName;
                        var wavinput = new WemFile();
                        wavinput.LoadFromFile(wav, WwAudioFileType.Wav);
                        wavinput.Generate();
                        wavinput.Calculate_Riff_Size();
                        var op = Path.Combine(Path.GetDirectoryName(wav),
                            Path.GetFileNameWithoutExtension(wav) + "_PREPARED.wav");
                        wavinput.WriteToFile(op);

                        //Reveal the file in windows explorer
                        string args = string.Format("/e, /select, \"{0}\"", op);

                        ProcessStartInfo info = new ProcessStartInfo();
                        info.FileName = "explorer";
                        info.Arguments = args;
                        Process.Start(info);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Bad file! Please only select files converted from the supplied url!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Export()
        {
            if (FilesListView.Items.Count > 0)
            {
                using (var fb = new FolderBrowserDialog())
                {
                    fb.Description = "Please select a folder to save the .wav files";
                    if (fb.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var f in Directory.GetFiles(wdir, "*.wav", SearchOption.AllDirectories))
                        {
                            File.Copy(f, Path.Combine(fb.SelectedPath, Path.GetFileName(f)));
                        }
                        var proc = new System.Diagnostics.Process();
                        proc.StartInfo = new ProcessStartInfo()
                        {
                            FileName = "explorer.exe",
                            Arguments = fb.SelectedPath
                        };
                        proc.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("No files to export!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenConverter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://audio.online-convert.com/convert-to-wav");
        }
    }
}

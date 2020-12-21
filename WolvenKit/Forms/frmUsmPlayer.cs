using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Scaleform;


namespace WolvenKit.Forms
{
    public partial class frmUsmPlayer : DockContent
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private BackgroundWorker videoConverter = new BackgroundWorker()
        {
            WorkerSupportsCancellation = true
        };

        public static Dictionary<string, byte[]> Demuxedfiles;
        public string videofile;
        string infile;

        public Process ffplay = new Process();

        public frmUsmPlayer(string path)
        {
            infile = path;
            InitializeComponent();
            Demuxedfiles = new Dictionary<string, byte[]>();
            videofile = path;
            videoConverter.DoWork += VideoConverter_DoWork;
            videoConverter.RunWorkerCompleted += VideoConverter_RunWorkerCompleted;
            videoConverter.RunWorkerAsync();
            Text = @"Video Preview [" + Path.GetFileNameWithoutExtension(path) + @"]";
            Application.EnableVisualStyles();
            this.DoubleBuffered = true;
        }

        private void UsmPlayer_CloseOnStart(object sender, EventArgs e)
        {
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        public void Demux(string path)
        {
            Demuxedfiles = new CriUsmStream(path).DemultiplexStreams(new MpegStream.DemuxOptionsStruct
            {
                ExtractAudio = true,
                ExtractVideo = true,
                AddHeader = true,
                SplitAudioStreams = false
            });
        }

        private void VideoConverter_DoWork(object sender, DoWorkEventArgs e)
        {
            Demux(videofile);
        }

        private void VideoConverter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs ev)
        {
            var file = Demuxedfiles.First(x => x.Key.EndsWith("m2v")).Value;

            Directory.CreateDirectory("ffmpeg\\ffmpegworkingdir\\");
            try
            {
                Directory.GetFiles("ffmpeg\\ffmpegworkingdir\\").ToList().ForEach(File.Delete);
            }
            catch (Exception)
            {
                MessageBox.Show("A video play is already in progress!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new Action(() =>
                {
                    this.Close();
                }));
                return;
            }
            //Write out audio stream
            var hasaudio = false;
            var adxpath = Path.Combine("ffmpeg\\ffmpegworkingdir\\", "out.adx");
            if(Demuxedfiles.Any(z => z.Key.EndsWith("adx")))
            {
                hasaudio = true;
                var x = Demuxedfiles.ToList().First(y => y.Key.EndsWith("adx"));
                File.WriteAllBytes(adxpath, x.Value);
                ConvertAudio(adxpath, Path.ChangeExtension(adxpath, ".wav"));
            }



            //Write out video stream
            var path = Path.Combine("ffmpeg\\ffmpegworkingdir\\", "out.m2v");
            File.WriteAllBytes(path, file);

            if(hasaudio)
            {
                path = Path.ChangeExtension(path, ".mp4");
                MergeVideoAndAudio(Path.ChangeExtension(adxpath, ".wav"), Path.ChangeExtension(path, ".m2v"), path);
            }

            ffplay.StartInfo.FileName = "ffmpeg//ffplay.exe";
            ffplay.StartInfo.Arguments = "-autoexit -noborder " + path;
            ffplay.StartInfo.CreateNoWindow = true;
            ffplay.StartInfo.RedirectStandardOutput = true;
            ffplay.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            ffplay.StartInfo.UseShellExecute = false;

            ffplay.EnableRaisingEvents = true;
            ffplay.OutputDataReceived += (o, e) => Debug.WriteLine(e.Data ?? "NULL", "ffplay");
            ffplay.ErrorDataReceived += (o, e) => Debug.WriteLine(e.Data ?? "NULL", "ffplay");
            ffplay.Exited += (o, a) =>
            {
                try
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        this.Close();
                    }));
                }
                catch (InvalidOperationException)  {  }
            };
            ffplay.Start();

            //Catch ffplay's handle really fast so there is no flashing
            try
            {
                while (string.IsNullOrEmpty(ffplay.MainWindowTitle))
                {
                    System.Threading.Thread.Sleep(10);
                    ffplay.Refresh();
                }
            }
            catch (InvalidOperationException) {  }

            try
            {
                // child, new parent
                // make 'this' the parent of ffmpeg (presuming you are in scope of a Form or Control)
                SetParent(ffplay.MainWindowHandle, this.Handle);

                // window, x, y, width, height, repaint
                // move the ffplayer window to the top-left corner and set the size
                MoveWindow(ffplay.MainWindowHandle, 0, 0, this.DockPanel.Width, this.DockPanel.Height, true);
            }
            catch (ObjectDisposedException)   {  }

        }

        public void ConvertAudio(string audiofile, string outfile)
        {
            string arg = audiofile + " -o " + outfile;
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

        public void MergeVideoAndAudio(string audio, string video, string outfile)
        {
            string arg = $"-i {video} -i {audio} -c:v copy -c:a aac {outfile}";
            var si = new ProcessStartInfo(
                    "ffmpeg\\ffmpeg.exe",
                    arg
                );
            si.CreateNoWindow = true;
            si.WindowStyle = ProcessWindowStyle.Normal;
            si.UseShellExecute = false;
            var proc = Process.Start(si);
            proc.WaitForExit();
        }

        private void frmUsmPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try 
            { 
                ffplay.Kill(); 
            }
            catch { }
        }
    }
}
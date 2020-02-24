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


namespace WolvenKit.Scaleform
{
    public partial class frmUsmPlayer : DockContent
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

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
                AddHeader = false,
                SplitAudioStreams = false
            });
        }

        private void VideoConverter_DoWork(object sender, DoWorkEventArgs e)
        {
            Demux(videofile);
        }

        private void VideoConverter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs ev)
        {
            statusLabel.Hide();
            var file = Demuxedfiles.First(x => x.Key.EndsWith("m2v")).Value;

            //Play video
            Directory.CreateDirectory("ffmppeg\\ffmpegworkingdir\\");
            var path = Path.Combine("ffmppeg\\ffmpegworkingdir\\", "out.m2v");
            File.WriteAllBytes(path, file);

            ffplay.StartInfo.FileName = "ffmpeg//ffplay.exe";
            ffplay.StartInfo.Arguments = path;
            ffplay.StartInfo.CreateNoWindow = true;
            ffplay.StartInfo.RedirectStandardOutput = true;
            ffplay.StartInfo.UseShellExecute = false;

            ffplay.EnableRaisingEvents = true;
            ffplay.OutputDataReceived += (o, e) => Debug.WriteLine(e.Data ?? "NULL", "ffplay");
            ffplay.ErrorDataReceived += (o, e) => Debug.WriteLine(e.Data ?? "NULL", "ffplay");
            ffplay.Exited += (o, e) => Debug.WriteLine("Exited", "ffplay");
            ffplay.Start();

            Thread.Sleep(500); // you need to wait/check the process started, then...

            // child, new parent
            // make 'this' the parent of ffmpeg (presuming you are in scope of a Form or Control)
            SetParent(ffplay.MainWindowHandle, this.Handle);

            // window, x, y, width, height, repaint
            // move the ffplayer window to the top-left corner and set the size
            MoveWindow(ffplay.MainWindowHandle, 0, 0, this.Width, this.Height, true);

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
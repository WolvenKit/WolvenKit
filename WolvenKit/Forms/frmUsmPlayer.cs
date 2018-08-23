using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Scaleform;

namespace WolvenKit
{
    public partial class frmUsmPlayer : DockContent
    {
        public static Dictionary<string, byte[]> Demuxedfiles;
        public string videofile;

        public frmUsmPlayer(string path)
        {
            InitializeComponent();
            if (Directory.Exists(MainController.Get().VLCLibDir))
            {
                this.usmPlayer.VlcLibDirectory = new DirectoryInfo(MainController.Get().VLCLibDir);
            }
            else
            {
                this.usmPlayer.Enabled = false;
                this.Shown += new EventHandler(UsmPlayer_CloseOnStart);
            }
            Demuxedfiles = new Dictionary<string, byte[]>();
            videofile = path;
            videoConverter.RunWorkerAsync();
            Text = @"Video Preview [" + Path.GetFileNameWithoutExtension(path) + @"]";
            usmPlayer.EndReached += UsmPlayerOnEndReached;
        }

        private void UsmPlayer_CloseOnStart(object sender, EventArgs e)
        {
            MessageBox.Show("You need to have VLC installed to use this feature. Please set the proper path in MainController\nCurrent path: " + MainController.Get().VLCLibDir,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            this.Close();
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
            foreach (var demuxedfile in Demuxedfiles)
            {
#if DEBUG
                File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "DUMP_FOLDER\\" + demuxedfile.Key,
                    demuxedfile.Value);
#endif
            }
        }

        private void VideoConverter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusLabel.Hide();
            var file = new MemoryStream(Demuxedfiles.First(x => x.Key.EndsWith("m2v")).Value);

            usmPlayer.Play(file);
        }

        private void UsmPlayerOnEndReached(object sender, VlcMediaPlayerEndReachedEventArgs vlcMediaPlayerEndReachedEventArgs)
        {
            this.BeginInvoke(new MethodInvoker(Close));
        }
    }
}
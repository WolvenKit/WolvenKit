using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
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
            Demuxedfiles = new Dictionary<string, byte[]>();
            videofile = path;
            videoConverter.RunWorkerAsync();
            Text = @"Video Preview [" + Path.GetFileNameWithoutExtension(path) + @"]";
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
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

        private void videoConverter_DoWork(object sender, DoWorkEventArgs e)
        {
            Demux(videofile);
            foreach (var demuxedfile in Demuxedfiles)
            {
#if DEBUG
                File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + demuxedfile.Key,
                    demuxedfile.Value);
#endif
            }
        }

        private void videoConverter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusLabel.Hide();
            string tempfile = Path.GetTempFileName();
            File.WriteAllBytes(Path.GetTempPath() + "\\" + Demuxedfiles.First(x => x.Key.EndsWith("m2v")).Key, Demuxedfiles.First(x => x.Key.EndsWith("m2v")).Value);
            usmPlayer.Play(new FileInfo(Path.GetTempPath() + "\\" + Demuxedfiles.First(x => x.Key.EndsWith("m2v")).Key));
        }
    }
}
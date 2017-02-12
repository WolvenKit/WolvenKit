using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using W3Edit.Video;

namespace W3Edit
{
    public partial class frmUsmPlayer : Form
    {
        public string videofile;
        public frmUsmPlayer(string path)
        {
            InitializeComponent();
            videofile = path;       
        }

        public void Demux(string path)
        {
            var demuxOptions = new MpegStream.DemuxOptionsStruct
            {
                ExtractAudio = true,
                ExtractVideo = true,
                AddHeader = false,
                SplitAudioStreams = false
            };
            var cus = new CriUsmStream(path);
            var file = cus.DemultiplexStreams(demuxOptions);
            var video = file.First(x => GetExtension(x.Key) == "m2v");
            var tempvideoname = DateTime.Now.Ticks;
            File.WriteAllBytes(Path.Combine(Path.GetTempPath(),tempvideoname + ".m2v"),video.Value);
            usmPlayer.SetMedia(new FileInfo(Path.Combine(Path.GetTempPath(), tempvideoname + ".m2v")));
            usmPlayer.Play();
            //MessageBox.Show(file.Select(x=> x.Key + ": " + x.Value.Length + "(bytes)").Aggregate("",(c,n)=> c+=n + "\n"));
        }

        public static string GetExtension(string s)
        {
            if (s.Contains('.'))
            {
                return s.Split('.').Last();
            }
            return "";
        }

        private void frmUsmPlayer_Shown(object sender, EventArgs e)
        {
            Demux(videofile);                 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.Bundles;
using W3Edit.CR2W;
using W3Edit.Video;
using WeifenLuo.WinFormsUI.Docking;

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
                SplitAudioStreams = false,
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
            else
            {
                return "";
            }
        }

        private void frmUsmPlayer_Shown(object sender, EventArgs e)
        {
            Demux(videofile);                 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using VGMToolbox.format;
using WeifenLuo.WinFormsUI.Docking;

namespace W3Edit
{
    public partial class frmUsmPlayer : DockContent
    {
        public static List<KeyValuePair<string, byte[]>> Demuxedfiles;
        public string videofile;
        public frmUsmPlayer(string path)
        {
            InitializeComponent();
            Demuxedfiles = new List<KeyValuePair<string, byte[]>>();
            videofile = path;
            videoConverter.RunWorkerAsync();
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
            cus.DemultiplexStreams(demuxOptions);
            foreach (var file in Directory.GetFiles(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + "_*").Where(File.Exists))
            {
                Demuxedfiles.Add(new KeyValuePair<string, byte[]>(Path.GetFileName(file), File.ReadAllBytes(file)));
                File.Delete(file);
            }
            //TODO: Convert the vgmtoolbox code so it works in memory :p
        }

        public static string GetExtension(string s)
        {
            return s.Contains('.') ? s.Split('.').Last() : "";
        }

        private void PlayFile(AxWMPLib.AxWindowsMediaPlayer Player,String url)
        {
            Player.URL = url;
        }

        private void usmPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((e.newState == (int)WMPLib.WMPPlayState.wmppsStopped))
            {
                this.Close();
            }
        }

        private void usmPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            MessageBox.Show(@"Cannot play media file.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void videoConverter_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Demux(videofile);
            if (Demuxedfiles.Any(x => Path.GetExtension(x.Key) == ".m2v" || Path.GetExtension(x.Key) == ".m1v"))
            {
                var video = Demuxedfiles.First(x => Path.GetExtension(x.Key) == ".m2v" || Path.GetExtension(x.Key) == ".m1v");
                File.WriteAllBytes(Path.Combine(Path.GetTempPath(), video.Key), video.Value);
                PlayFile(usmPlayer, Path.Combine(Path.GetTempPath(), video.Key));
            }
        }
    }
}

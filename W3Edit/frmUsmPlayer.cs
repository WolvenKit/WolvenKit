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

        private void videoConverter_DoWork(object sender, DoWorkEventArgs e)
        {
            Demux(videofile);
            if (Demuxedfiles.Any(x => Path.GetExtension(x.Key) == ".m2v" || Path.GetExtension(x.Key) == ".m1v"))
            {
                var video = Demuxedfiles.First(x => Path.GetExtension(x.Key) == ".m2v" || Path.GetExtension(x.Key) == ".m1v");
                File.WriteAllBytes(Path.Combine(Path.GetTempPath(), video.Key), video.Value);
                
                usmPlayer.Play(new FileInfo(Path.Combine(Path.GetTempPath(), video.Key)));
            }
        }

        private void videoConverter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusLabel.Hide();
        }
    }
}
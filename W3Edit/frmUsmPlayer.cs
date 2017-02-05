using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public static void Demux(string path)
        {
            var demuxOptions = new MpegStream.DemuxOptionsStruct
            {
                ExtractAudio = true,
                ExtractVideo = true,
                AddHeader = false,
                SplitAudioStreams = false,
            };
            var cus = new CriUsmStream(path);
            cus.DemultiplexStreams(demuxOptions);
        }

        private static void PolymorphExecute(string fullpath, string extension)
        {
            File.WriteAllBytes(Path.GetTempPath() + "asd." + extension, new byte[] { 0x01 });
            var programname = new StringBuilder();
            Win32.FindExecutable("asd." + extension, Path.GetTempPath(), programname);
            if (programname.ToString().ToUpper().Contains(".EXE"))
            {
                Process.Start(programname.ToString(), fullpath);
            }
            else
            {
                throw new InvalidFileTypeException("Invalid file type");
            }
        }

        private void frmUsmPlayer_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            label1.Update();
            Demux(videofile);          
            PolymorphExecute(Path.ChangeExtension(Directory.GetFiles(Path.GetDirectoryName(videofile), "*.m2v").FirstOrDefault(), ".m2v"), ".avi");
            label1.Text = @"Done!";
        }
    }
}

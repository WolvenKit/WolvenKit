using System.IO;
using WolvenKit.CR2W;

namespace WolvenKit
{
    public class LoadFileArgs
    {
        public string Filename { get; set; }
        public MemoryStream Stream { get; set; }
        public frmCR2WDocument Doc { get; set; }
        public bool SuppressErrors { get; set; }
        public LoadFileArgs(string filename, frmCR2WDocument doc, MemoryStream stream = null, bool suppressErrors = false)
        {
            Filename = filename;
            Doc = doc;
            if (stream != null)
                Stream = stream;
            SuppressErrors = suppressErrors;
        }
    }
}
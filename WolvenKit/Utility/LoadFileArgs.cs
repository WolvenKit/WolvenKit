using System.IO;
using WolvenKit.App.ViewModels;
using WolvenKit.CR2W;

namespace WolvenKit
{
    public class LoadFileArgs
    {
        public string Filename { get; set; }
        public MemoryStream Stream { get; set; }
        public DocumentViewModel ViewModel { get; set; }
        public bool SuppressErrors { get; set; }
        public LoadFileArgs(string filename, DocumentViewModel viewmodel, MemoryStream stream = null, bool suppressErrors = false)
        {
            Filename = filename;
            ViewModel = viewmodel;
            if (stream != null)
                Stream = stream;
            SuppressErrors = suppressErrors;
        }
    }
}
using System.IO;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    public class FileSavedEventArgs
    {
        public Stream Stream { get; set; }
        public string FileName { get; set; }
        public IWolvenkitFile File { get; set; }
    }
}
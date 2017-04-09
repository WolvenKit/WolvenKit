using System.IO;
using WolvenKit.CR2W;

namespace WolvenKit
{
    public class FileSavedEventArgs
    {
        public Stream Stream { get; set; }
        public string FileName { get; set; }
        public CR2WFile File { get; set; }
    }
}
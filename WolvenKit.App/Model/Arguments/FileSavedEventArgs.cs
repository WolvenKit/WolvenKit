using System.IO;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;

namespace WolvenKit.App.Model
{
    public class FileSavedEventArgs
    {
        public Stream Stream { get; set; }
        public string FileName { get; set; }
        public IWolvenkitFile File { get; set; }
    }
}
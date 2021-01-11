using System.IO;

namespace WolvenKit.Common.Model.Arguments
{
    public class FileSavedEventArgs
    {
        public Stream Stream { get; set; }
        public string FileName { get; set; }
        public IWolvenkitFile File { get; set; }
    }
}
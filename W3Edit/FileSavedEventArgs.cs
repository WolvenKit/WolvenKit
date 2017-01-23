using System.IO;
using W3Edit.CR2W;

namespace W3Edit
{
    public class FileSavedEventArgs
    {
        public Stream Stream { get; set; }
        public string FileName { get; set; }
        public CR2WFile File { get; set; }
    }
}
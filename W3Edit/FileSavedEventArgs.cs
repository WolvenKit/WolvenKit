using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace W3Edit
{
    public class FileSavedEventArgs
    {
        public Stream Stream { get; set; }
        public string FileName { get; set; }

        public CR2W.CR2WFile File { get; set; }
    }
}

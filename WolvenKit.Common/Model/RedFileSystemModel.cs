using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Model
{
    public class RedFileSystemModel
    {
        public RedFileSystemModel(string fullname)
        {
            FullName = fullname;
        }

        public string Name => Path.GetFileName(FullName);

        public string FullName { get; set; }

        public List<RedFileSystemModel> Directories { get; } = new();

        public List<ulong> Files { get; } = new();

        public string Extension => nameof(ECustomImageKeys.ClosedDirImageKey);

    }
}

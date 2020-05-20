using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Radish.Model
{
    public class BatFile
    {
        public string Path { get; set; }
        public string Name { get => System.IO.Path.GetFileName(Path); }
        public bool Interactive { get; set; }

        public BatFile(string path)
        {
            Path = path;
        }
    }
}

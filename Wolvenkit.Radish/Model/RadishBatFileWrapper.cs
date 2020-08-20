using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Radish.Model
{
    public class RadishBatFileWrapper
    {
        public string Path { get; set; }
        public string Name { get => System.IO.Path.GetFileName(Path); }
        public bool Interactive { get; set; }

        public RadishBatFileWrapper(string path)
        {
            Path = path;
        }
    }
}

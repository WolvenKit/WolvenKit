using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Model
{
    public class HashDump
    {
        public string Path { get; set; }
        public string HashHex { get; set; }
        public ulong HashInt { get; set; }
    }
}

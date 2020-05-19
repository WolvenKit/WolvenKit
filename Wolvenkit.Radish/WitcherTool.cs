using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolvenkit.Radish
{
    public abstract class WitcherTool
    {
        public abstract void Encode(FileStream file);
        public abstract void Decode(FileStream file);
    }
}

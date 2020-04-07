using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Wwise.WEM
{
    class HeaderMerge
    {
        public string original_wem { get; set; }
        public string modified_wem { get; set; }

        HeaderMerge(string original, string modified)
        {
            original_wem = original;
            modified_wem = modified;
        }
    }
}

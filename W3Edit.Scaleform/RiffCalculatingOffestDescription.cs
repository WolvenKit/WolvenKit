using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.Scaleform
{
    public class RiffCalculatingOffsetDescription : CalculatingOffsetDescription
    {
        public const string START_OF_STRING = "start of";
        public const string END_OF_STRING = "end of";

        public string RelativeLocationToRiffChunkString { set; get; }
        public string RiffChunkString { set; get; }
    }
}

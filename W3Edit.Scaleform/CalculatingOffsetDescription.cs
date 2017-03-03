using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.Scaleform
{
    public class CalculatingOffsetDescription : OffsetDescription
    {
        public const string OFFSET_VARIABLE_STRING = "$V";

        public string CalculationString { set; get; }
    }
}

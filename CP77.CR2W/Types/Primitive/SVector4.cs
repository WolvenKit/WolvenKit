using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using CP77.CR2W;
using CP77.CR2W.Reflection;
using CP77.CR2W.Types;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SVector4 : CVariable
    {
        [Ordinal(0)] [RED] public CFloat X { get; set; }
        [Ordinal(1)] [RED] public CFloat Y { get; set; }
        [Ordinal(2)] [RED] public CFloat Z { get; set; }
        [Ordinal(3)] [RED] public CFloat W { get; set; }

        public SVector4(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }


        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, $"V4[{X.val:0.00}, {Y.val:0.00}, {Z.val:0.00}, {W.val:0.00}]");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;

using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SVector2D : CVariable
    {
        [Ordinal(0)] [RED] public CFloat x { get; set; }
        [Ordinal(1)] [RED] public CFloat y { get; set; }

        public SVector2D(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }


        public override CVariable SetValue(object val)
        {
            if (val is SVector2D v)
            {
                this.x = v.x;
                this.y = v.y;
            }

            return this;
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SVector2D(cr2w, parent, name);
        }


        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "V2[{0:0.00}, {1:0.00}]", x.val, y.val);
        }
    }
}
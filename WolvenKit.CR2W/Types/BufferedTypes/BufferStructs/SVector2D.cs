using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SVector2D : CVariable
    {
        [RED] public CFloat x { get; set; }
        [RED] public CFloat y { get; set; }

        public SVector2D(CR2WFile cr2w = null)
            : base(cr2w)
        {
        }


        public override CVariable SetValue(object val)
        {
            if (val is SVector2D v)
            {
                this.x = v.x;
                this.y = v.y;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SVector2D(cr2w);
        }


        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "V2[{0:0.00}, {1:0.00}]", x.val, y.val);
        }
    }
}
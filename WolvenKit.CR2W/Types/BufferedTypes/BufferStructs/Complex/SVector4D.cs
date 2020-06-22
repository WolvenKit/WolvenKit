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
    public class SVector4D : CVariable
    {
        [RED] public CFloat X { get; set; }
        [RED] public CFloat Y { get; set; }
        [RED] public CFloat Z { get; set; }
        [RED] public CFloat W { get; set; }

        public SVector4D(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        

        
        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SVector3D(cr2w, parent, name);
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, $"V4[{X.val:0.00}, {Y.val:0.00}, {Z.val:0.00}, {W.val:0.00}]");
        }
    }
}
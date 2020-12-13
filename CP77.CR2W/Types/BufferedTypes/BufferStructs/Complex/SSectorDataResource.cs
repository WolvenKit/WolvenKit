using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Globalization;
using WolvenKit.Common.Model;
using System.Reflection;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class CSectorDataResource : CVariable
    {
        [Ordinal(0)] [RED] public CFloat box0 { get; set; }
        [Ordinal(1)] [RED] public CFloat box1 { get; set; }
        [Ordinal(2)] [RED] public CFloat box2 { get; set; }
        [Ordinal(3)] [RED] public CFloat box3 { get; set; }
        [Ordinal(4)] [RED] public CFloat box4 { get; set; }
        [Ordinal(5)] [RED] public CFloat box5 { get; set; }
        //public CUInt64 patchHash;
        [Ordinal(7)] [RED] public CString pathHash { get; set; }

        public CSectorDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CSectorDataResource(cr2w, parent, name);
        }

    }
}
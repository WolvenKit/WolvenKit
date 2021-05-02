using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SAnimPointCloudLookAtParamData : CVariable
    {
        [Ordinal(0)] [RED] public CUInt16 unk1 { get; set; }
        [Ordinal(1)] [RED] public CUInt16 unk2 { get; set; }
        [Ordinal(2)] [RED] public CUInt16 unk3 { get; set; }

        public SAnimPointCloudLookAtParamData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }


        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SAnimPointCloudLookAtParamData(cr2w, parent, name);
        }

        public override string ToString()
        {
            return $"[{unk1.ToString()}, {unk2.ToString()}, {unk3.ToString()}]";
        }
    }
}
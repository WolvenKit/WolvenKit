using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SAnimPointCloudLookAtParamData : CVariable
    {
        [RED] public CUInt16 unk1 { get; set; }
        [RED] public CUInt16 unk2 { get; set; }
        [RED] public CUInt16 unk3 { get; set; }

        public SAnimPointCloudLookAtParamData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }


        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SAnimPointCloudLookAtParamData(cr2w, parent, name);
        }

        public override string ToString()
        {
            return $"[{unk1.ToString()}, {unk2.ToString()}, {unk3.ToString()}]";
        }
    }
}
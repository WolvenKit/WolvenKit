using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SFoliageResourceData : CVariable
    {

        [Ordinal(1000)] [REDBuffer] public CHandle<CSRTBaseTree> Treetype { get; set; }
        [Ordinal(1001)] [REDBuffer] public CBufferVLQInt32<SFoliageInstanceData> TreeCollection { get; set; }

        public SFoliageResourceData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        
    }

}
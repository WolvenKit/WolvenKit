using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SFoliageResourceData : CVariable
    {

        [Ordinal(1000)] [REDBuffer] public CHandle<CSRTBaseTree> Treetype { get; set; }
        [Ordinal(1001)] [REDBuffer] public CBufferVLQInt32<SFoliageInstanceData> TreeCollection { get; set; }

        public SFoliageResourceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFoliageResourceData(cr2w, parent, name);
    }

}
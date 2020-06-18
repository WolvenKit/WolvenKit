using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SFoliageResourceData : CVariable
    {

        [RED] public CHandle<CSRTBaseTree> Treetype { get; set; }
        [RED] public CBufferVLQInt32<SFoliageInstanceData> TreeCollection { get; set; }

        public SFoliageResourceData(CR2WFile cr2w) : base(cr2w) { }

        public override CVariable Create(CR2WFile cr2w) => new SFoliageResourceData(cr2w);
    }

}
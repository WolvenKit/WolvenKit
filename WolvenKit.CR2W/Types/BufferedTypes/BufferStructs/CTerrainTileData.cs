using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class STerrainTileData : CVariable
    {
        [Ordinal(1)] [RED] public CInt16 Lod1 { get; set; }
        [Ordinal(2)] [RED] public CInt16 Lod2 { get; set; }
        [Ordinal(3)] [RED] public CInt16 Lod3 { get; set; }
        [Ordinal(4)] [RED] public CInt32 Resolution { get; set; }

        public STerrainTileData(CR2WFile cr2w, CVariable parent, string name) :
            base(cr2w, parent, name)
        {
        }

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STerrainTileData(cr2w, parent, name);
    }
}
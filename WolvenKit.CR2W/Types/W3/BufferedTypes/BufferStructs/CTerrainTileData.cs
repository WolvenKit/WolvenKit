using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class STerrainTileData : CVariable
    {
        public CInt16 Lod1 { get; set; }
        public CInt16 Lod2 { get; set; }
        public CInt16 Lod3 { get; set; }
        public CInt32 Resolution { get; set; }

        public STerrainTileData(CR2WFile cr2w) :
            base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w) => new STerrainTileData(cr2w);
    }
}
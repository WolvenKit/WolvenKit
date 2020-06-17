using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
    class CTerrainTile : CVariable
    {
        [RED("tileFileVersion")] public CUInt32 TileFileVersion { get; set; }

        [RED("collisionType")] public ETerrainTileCollision CollisionType { get; set; }

        [RED("maxHeightValue")] public CUInt16 MaxHeightValue { get; set; }

        [RED("minHeightValue")] public CUInt16 MinHeightValue { get; set; }


        [REDBuffer] public CArray<STerrainTileData> Groups { get; set; }


        public CTerrainTile(CR2WFile cr2w) : base(cr2w)
        {
            Groups = new CArray<STerrainTileData>(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            Groups.Read(file, 0);
            var maxres = file.ReadInt32();
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Groups.Write(file);
            int maxres = 0;


            foreach (var g in Groups)
            {
                var g3 = g.Resolution.val;
                if (g3 > maxres) maxres = g3;
            }
            file.Write(maxres);
        }

        public override CVariable Create(CR2WFile cr2w) => new CTerrainTile(cr2w);
    }




}

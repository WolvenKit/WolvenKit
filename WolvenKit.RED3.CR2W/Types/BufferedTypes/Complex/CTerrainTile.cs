using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    public partial class CTerrainTile : CResource
    {



        [Ordinal(1000)] [REDBuffer] public CArray<STerrainTileData> Groups { get; set; }


        public CTerrainTile(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var maxres = file.ReadInt32();
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            int maxres = 0;
            foreach (var g in Groups)
            {
                var g3 = g.Resolution.val;
                if (g3 > maxres) maxres = g3;
            }
            file.Write(maxres);
        }

    }




}


using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{

    public partial class CLayerInfo : ISerializable
    {
       

        [Ordinal(1000)] [REDBuffer(true)] public CHandle<CLayerGroup> ParentGroup { get; set; }

        public CLayerInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            ParentGroup = new CHandle<CLayerGroup>(cr2w, this, nameof(ParentGroup)) { IsSerialized = true };
        }

        public override void Read(BinaryReader file, uint size)
        {
            var startpos = file.BaseStream.Position;

            base.Read(file, size);

            var endpos = file.BaseStream.Position;
            var bytesread = endpos - startpos;
            if (bytesread != size)
            {
                ParentGroup.ChunkHandle = true;
                ParentGroup.Read(file, 4);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            // HACK check if it has been set in Read()
            if (ParentGroup != null && ParentGroup.ChunkHandle == true)
                ParentGroup.Write(file);
        }



        
    }
}

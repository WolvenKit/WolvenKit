
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{

    public partial class CLayerInfo : ISerializable
    {
       

        [REDBuffer(true)] public CHandle<CLayerGroup> ParentGroup { get; set; }

        public CLayerInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            ParentGroup = new CHandle<CLayerGroup>(cr2w, this, nameof(ParentGroup));
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

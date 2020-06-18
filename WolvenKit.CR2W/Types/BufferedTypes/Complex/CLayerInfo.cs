
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

        public CLayerInfo(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            ParentGroup.ChunkHandle = true;
            ParentGroup.Read(file, 4);

            //base.AddVariable(ParentGroup);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            ParentGroup.Write(file);
        }



        
    }
}

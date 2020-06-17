using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CPhysicalCollision : CVariable
    {
        public CUInt32 Unk1;
        public CBufferVLQ<CName> Collisiontypes;
        public CBytes Data;
            
        public CPhysicalCollision(CR2WFile cr2w) :
            base(cr2w)
        {
            Unk1 = new CUInt32(cr2w) { Name = nameof(Unk1) };
            Data = new CBytes(cr2w) { Name = nameof(Data) };
            Collisiontypes = new CBufferVLQ<CName>(cr2w) { Name = nameof(Collisiontypes) };
        }

        public override void Read(BinaryReader file, uint size)
        {
            var startpos = file.BaseStream.Position;

            Unk1.Read(file, 4);
            Collisiontypes.Read(file, 0);

            var endpos = file.BaseStream.Position;

            Data.Read(file, (uint)(size - (endpos - startpos)));
        }

        public override void Write(BinaryWriter file)
        {
            Unk1.Write(file);
            Collisiontypes.Write(file);
            Data.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CPhysicalCollision(cr2w);
        }
    }
}
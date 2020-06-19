using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta]
    public class CPhysicalCollision : CVariable
    {
        [REDBuffer(true)] public CUInt32 Unk1 { get; set; }
        [REDBuffer(true)] public CBufferVLQ<CName> Collisiontypes { get; set; }
        [REDBuffer(true)] public CBytes Data { get; set; }

        public CPhysicalCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) 
        {
            Unk1 = new CUInt32(cr2w, this, nameof(Unk1) );
            Data = new CBytes(cr2w, this, nameof(Data) );
            Collisiontypes = new CBufferVLQ<CName>(cr2w, this, nameof(Collisiontypes));
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

        public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPhysicalCollision(cr2w, parent, name);
    }
}
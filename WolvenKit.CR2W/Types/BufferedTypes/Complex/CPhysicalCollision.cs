using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [REDMeta]
    public class CPhysicalCollision : CVariable
    {
        [Ordinal(1000)] [REDBuffer(true)] public CUInt32 Unk1 { get; set; }
        [Ordinal(1001)] [REDBuffer(true)] public CBufferVLQInt32<CName> Collisiontypes { get; set; }
        [Ordinal(1002)] [REDBuffer(true)] public CBytes Data { get; set; }

        public CPhysicalCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) 
        {
            Unk1 = new CUInt32(cr2w, this, nameof(Unk1) );
            Data = new CBytes(cr2w, this, nameof(Data) );
            Collisiontypes = new CBufferVLQInt32<CName>(cr2w, this, nameof(Collisiontypes));
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

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPhysicalCollision(cr2w, parent, name);
    }
}
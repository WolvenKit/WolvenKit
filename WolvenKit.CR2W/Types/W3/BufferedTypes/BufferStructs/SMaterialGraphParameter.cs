using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class SMaterialGraphParameter : CVariable
    {
        public CName name;
        public CUInt8 unk1, unk2;

        public SMaterialGraphParameter(CR2WFile cr2w)
            : base(cr2w)
        {
            unk1 = new CUInt8(cr2w) {Name = "Type", };
            unk2 = new CUInt8(cr2w) {Name = "Offset?", };
            name = new CName(cr2w) {Name = "Name",};
        }

        public override void Read(BinaryReader file, uint size)
        {
            unk1.Read(file, size);
            unk2.Read(file, size);
            name.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            unk1.Write(file);
            unk2.Write(file);
            name.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SMaterialGraphParameter(cr2w);
        }


        public override string ToString()
        {
            return "";
        }
    }
}
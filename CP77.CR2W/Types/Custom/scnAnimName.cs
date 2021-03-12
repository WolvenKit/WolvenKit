using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class scnAnimName : scnAnimName_
    {
        [Ordinal(1000)] public List<CName> Unk1 { get; set; }
        [Ordinal(1001)] public UInt32 Unk2 { get; set; }

        public scnAnimName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Unk1 = new List<CName>();
        }

        public override void Read(BinaryReader file, uint size)
        {
            var startPos = file.BaseStream.Position;
            base.Read(file, size);
            var bytesRead = file.BaseStream.Position - startPos;

            if (Type != null)
            {
                switch (Type.Value)
                {
                    case Enums.scnAnimNameType.dynamic:
                        var count = (uint) (size - bytesRead) / 2;

                        for (var i = 0; i < count; i++)
                        {
                            var cname = new CName(cr2w, this, i.ToString());
                            cname.Read(file, 2);
                            Unk1.Add(cname);
                        }
                        break;
                    case Enums.scnAnimNameType.reference:
                        // TODO: what does it reference?
                        Unk2 = file.ReadUInt32();
                        break;
                    case Enums.scnAnimNameType.container:
                        // TODO: what does it reference?
                        Unk2 = file.ReadUInt32();
                        break;
                    case Enums.scnAnimNameType.direct:
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                var cname = new CName(cr2w, this, "0");
                cname.Read(file, 2);
                Unk1.Add(cname);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            if (Type != null)
            {
                switch (Type.Value)
                {
                    case Enums.scnAnimNameType.dynamic:
                        foreach (var cName in Unk1)
                        {
                            cName.Write(file);
                        }
                        break;
                    case Enums.scnAnimNameType.reference:
                        file.Write(Unk2);
                        break;
                    case Enums.scnAnimNameType.container:
                        file.Write(Unk2);
                        break;
                    case Enums.scnAnimNameType.direct:
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                Unk1[0].Write(file);
            }
        }
    }
}

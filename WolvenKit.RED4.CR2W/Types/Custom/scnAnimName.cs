using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class scnAnimName : scnAnimName_
    {
        [Ordinal(1000)] [REDBuffer(true)] public CArrayCompressed<CName> Unk1 { get; set; }
        [Ordinal(1001)] [REDBuffer(true)] public CUInt32 Unk2 { get; set; }

        public scnAnimName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            var startPos = file.BaseStream.Position;
            base.Read(file, size);
            var bytesRead = file.BaseStream.Position - startPos;

            if (Type != null)
            {
                switch (Type.Value)
                {
                    case Enums.scnAnimNameType.direct:
                    case Enums.scnAnimNameType.dynamic:
                        var count = (int) (size - bytesRead) / 2;
                        Unk1.Read(file, 2, count);
                        break;
                    case Enums.scnAnimNameType.reference:
                    case Enums.scnAnimNameType.container:
                        // TODO: what does it reference?
                        Unk2.Read(file, 4);
                        break;
                    default:
                        throw new NotImplementedException("scnAnimName.Read");
                }
            }
            else
            {
                Unk1.Read(file, 2, 1);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            if (Type != null)
            {
                switch (Type.Value)
                {
                    case Enums.scnAnimNameType.direct:
                    case Enums.scnAnimNameType.dynamic:
                        Unk1.Write(file);
                        break;
                    case Enums.scnAnimNameType.reference:
                    case Enums.scnAnimNameType.container:
                        Unk2.Write(file);
                        break;
                    default:
                        throw new NotImplementedException("scnAnimName.Read");
                }
            }
            else
            {
                Unk1.Write(file);
            }
        }
    }
}

using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using WolvenKit.Interfaces.Core;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    class SBlockDataDecal : CVariable
    {
        [Ordinal(0)] [RED] public CUInt16 diffuseTexture { get; set; }
        [Ordinal(1)] [RED] public CUInt16 padding { get; set; }
        [Ordinal(2)] [RED] public CUInt32 specularColor { get; set; }
        [Ordinal(3)] [RED] public CFloat normalTreshold { get; set; }
        //[Ordinal(4)] [RED] public CFloat specularity { get; set; }
        //[Ordinal(5)] [RED] public CFloat fadeTime { get; set; }

        [Ordinal(999)] [REDBuffer(true)] public CBytes unk1 { get; set; }


        public SBlockDataDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            unk1 = new CBytes(cr2w, parent, nameof(unk1));

        }

        public override void Read(BinaryReader file, uint size)
        {
            var startp = file.BaseStream.Position;
            base.Read(file, size);


            var endp = file.BaseStream.Position;
            var read = endp - startp;
            if (read < size)
            {
                unk1.Read(file, size - (uint)read);
            }
            else if (read > size)
            {
                throw new InvalidParsingException("Read too far.");
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            if (unk1.Bytes != null && unk1.Bytes.Length > 0)
                unk1.Write(file);
        }

    }
}

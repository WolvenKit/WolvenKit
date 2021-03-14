using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SMipData : CVariable
    {
        [Ordinal(0)] [RED] public CUInt32 Width { get; set; }
        [Ordinal(1)] [RED] public CUInt32 Height { get; set; }
        [Ordinal(2)] [RED] public CUInt32 Blocksize { get; set; }

        [Ordinal(1004)] [REDBuffer(true)] public CByteArray Mip { get; set; }

        public SMipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Mip = new CByteArray(cr2w, this, nameof(Mip)) { IsSerialized = true };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            // if is uncooked
            if (this.REDFlags == 0)
                Mip.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            // if is uncooked
            if (this.REDFlags == 0)
                Mip.Write(file);
        }
    }
}
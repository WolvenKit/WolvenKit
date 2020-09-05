using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    public partial class CBitmapTexture : ITexture
    {

        [Ordinal(1000)] [REDBuffer] public CUInt32 unk { get; set; }
        [Ordinal(1001)] [REDBuffer(true)] public CUInt32 MipsCount { get; set; }

        [Ordinal(1002)] [REDBuffer(true)] public CCompressedBuffer<SMipData> Mipdata { get; set; }
        [Ordinal(1003)] [REDBuffer(true)] public CUInt32 unk2 { get; set; }
        // Uncooked Textures
        [Ordinal(1004)] [REDBuffer(true)] public CCompressedBuffer<CByteArray> Mips { get; set; }
        // Cooked Textures
        [Ordinal(1005)] [REDBuffer(true)] public CUInt32 ResidentmipSize { get; set; }
        [Ordinal(1006)] [REDBuffer(true)] public CBytes Residentmip { get; set; }


        public CBitmapTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {


            MipsCount = new CUInt32(cr2w, this, nameof(MipsCount));
            Mipdata = new CCompressedBuffer<SMipData>(cr2w, this, nameof(Mipdata));
            unk2 = new CUInt32(cr2w, this, nameof(unk2));
            Mips = new CCompressedBuffer<CByteArray>(cr2w, this, nameof(Mips));
            ResidentmipSize = new CUInt32(cr2w, this, nameof(ResidentmipSize));
            Residentmip = new CBytes(cr2w, this, nameof(Residentmip));
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            MipsCount.Read(file, 4);

            // Uncooked and Cooked xbms have a different file structure. 
            // Uncooked xbms can be identified by their Sourcedata being null
            // and the residentmipindex being not null

            var isCooked =  REDFlags == 0 ;
            if (isCooked)
            {
                if (SourceData == null && ResidentMipIndex == null)
                {

                }
            }

            if (isCooked)
            {
                for (int i = 0; i < MipsCount.val; i++)
                {
                    var mipdata = new SMipData(cr2w, Mipdata, "");
                    mipdata.Read(file, 16);
                    Mipdata.AddVariable(mipdata);

                    var img = new CByteArray(cr2w, Mips, "");
                    img.Read(file, 0);
                    Mips.AddVariable(img);
                }
            }
            else
            {
                Mipdata.Read(file, size, (int)MipsCount.val);
            }

            ResidentmipSize.Read(file, 4);
            unk2.Read(file, 4);
            Residentmip.Read(file, ResidentmipSize.val);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            var isCooked = REDFlags == 0;
            if (isCooked)
            {
                MipsCount.val = (uint)Mips.Count;
                MipsCount.Write(file);
                Mips.Write(file);
            }
            else
            {
                MipsCount.Write(file);
            }


            Mipdata.Write(file);
            ResidentmipSize.Write(file);
            unk2.Write(file);

            Residentmip.Write(file);
        }
    }
}

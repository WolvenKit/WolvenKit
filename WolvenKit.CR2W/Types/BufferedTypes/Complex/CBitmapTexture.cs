using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    public partial class CBitmapTexture : ITexture
    {

        [REDBuffer] public CUInt32 unk { get; set; }
        [REDBuffer] public CUInt32 MipsCount { get; set; }
        [REDBuffer(true)] public CCompressedBuffer<SMipData> Mipdata { get; set; }
        [REDBuffer(true)] public CUInt32 unk2 { get; set; }
        // Imported Textures
        [REDBuffer(true)] public CCompressedBuffer<CByteArray> Mips { get; set; }
        // Cooked Textures
        [REDBuffer(true)] public CUInt32 ResidentmipSize { get; set; }
        [REDBuffer(true)] public CBytes Residentmip { get; set; }


        public CBitmapTexture(CR2WFile cr2w) : base(cr2w)
        {


            Mipdata = new CCompressedBuffer<SMipData>(cr2w, _ => new SMipData(_)) { REDName = "Mipdata" };
            unk2 = new CUInt32(cr2w) { REDName = "unk2" };
            Mips = new CCompressedBuffer<CByteArray>(cr2w, _ => new CByteArray(_)) { REDName = "mips" };
            ResidentmipSize = new CUInt32(cr2w) { REDName = "filesize" };
            Residentmip = new CBytes(cr2w) { REDName = "Image" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            // Imported and Cooked xbms have a different file structure. 
            // Imported xbms can be identified by their Sourcedata being not null

            if (SourceData != null)
            {
                //dbg
                if (ResidentMipIndex != null)
                    throw new NotImplementedException();

                for (int i = 0; i < MipsCount.val; i++)
                {
                    var mipdata = new SMipData(cr2w);
                    mipdata.Read(file, 16);
                    Mipdata.AddVariable(mipdata);

                    var img = new CByteArray(cr2w);
                    //img.SetParent(this);
                    img.Read(file, 0);
                    Mips.AddVariable(img);
                }
                unk2.Read(file, 4);
            }
            else
            {
                //if (ResidentMipIndex == null)
                //throw new NotImplementedException();


                Mipdata.Read(file, size, (int)MipsCount.val);

                ResidentmipSize.Read(file, 4);

                unk2.Read(file, 4);

                //Residentmip.SetParent(this);
                Residentmip.Read(file, ResidentmipSize.val);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);


            Mips.Write(file);

            ResidentmipSize.Write(file);
            unk2.Write(file);

            Residentmip.Write(file);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;
using WolvenKit.Common.Model;
using System.Linq;

namespace WolvenKit.CR2W.Types
{
    public partial class CBitmapTexture : ITexture, IByteSource
    {

        [Ordinal(1000)] [REDBuffer] public CUInt32 unk { get; set; }
        [Ordinal(1001)] [REDBuffer(true)] public CUInt32 MipsCount { get; set; }

        [Ordinal(1002)] [REDBuffer(true)] public CCompressedBuffer<SMipData> Mipdata { get; set; }
        [Ordinal(1003)] [REDBuffer(true)] public CUInt16 unk1 { get; set; }
        [Ordinal(1003)] [REDBuffer(true)] public CUInt16 unk2 { get; set; }
        // Uncooked Textures
       
        // Cooked Textures
        [Ordinal(1005)] [REDBuffer(true)] public CUInt32 ResidentmipSize { get; set; }
        [Ordinal(1006)] [REDBuffer(true)] public CBytes Residentmip { get; set; }


        public CBitmapTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {


            MipsCount = new CUInt32(cr2w, this, nameof(MipsCount)) { IsSerialized = true };
            Mipdata = new CCompressedBuffer<SMipData>(cr2w, this, nameof(Mipdata)) { IsSerialized = true };
            unk1 = new CUInt16(cr2w, this, nameof(unk1)) { IsSerialized = true };
            unk2 = new CUInt16(cr2w, this, nameof(unk2)) { IsSerialized = true };
            
            ResidentmipSize = new CUInt32(cr2w, this, nameof(ResidentmipSize)) { IsSerialized = true };
            Residentmip = new CBytes(cr2w, this, nameof(Residentmip)) { IsSerialized = true };
        }

        public byte[] GetBytes()
        {
            var isUncooked = this.REDFlags == 0;
            byte[] bytesource;
            if (isUncooked)
            {
                if (this.Mipdata.Count <= 0) return null;

                bytesource = this.Mipdata.First().Mip.Bytes;
                for (var index = 1; index < this.Mipdata.Count; index++)
                {
                    var byteArray = this.Mipdata[index].Mip;
                    bytesource = bytesource.Concat(byteArray.Bytes).ToArray();
                }
            }
            else
                bytesource = this.Residentmip.Bytes;

            return bytesource;
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            //TODO: readd for tw3
            //MipsCount.Read(file, 4);

            //Mipdata.Read(file, size, (int)MipsCount.val);

            //ResidentmipSize.Read(file, 4);
            //unk1.Read(file, 2);
            //unk2.Read(file, 2);
            //Residentmip.Read(file, ResidentmipSize.val);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            MipsCount.val = (uint)Mipdata.Count;
            MipsCount.Write(file);

            Mipdata.Write(file);

            ResidentmipSize.Write(file);
            unk1.Write(file);
            unk2.Write(file);

            Residentmip.Write(file);
        }
    }
}

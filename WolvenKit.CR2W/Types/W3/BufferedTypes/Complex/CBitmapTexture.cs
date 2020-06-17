using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CBitmapTexture : ITexture
    {
        [RED("width")] public CUInt32 Width { get; set; }

        [RED("height")] public CUInt32 Height { get; set; }

        [RED("format")] public ETextureRawFormat Format { get; set; }

        [RED("compression")] public ETextureCompression Compression { get; set; }

        [RED("sourceData")] public CHandle<CSourceTexture> SourceData { get; set; }

        [RED("textureGroup")] public CName TextureGroup { get; set; }

        [RED("pcDownscaleBias")] public CInt32 PcDownscaleBias { get; set; }

        [RED("xboneDownscaleBias")] public CInt32 XboneDownscaleBias { get; set; }

        [RED("ps4DownscaleBias")] public CInt32 Ps4DownscaleBias { get; set; }

        [RED("residentMipIndex")] public CUInt8 ResidentMipIndex { get; set; }

        [RED("textureCacheKey")] public CUInt32 TextureCacheKey { get; set; }

        public CUInt32 unk;
        public CUInt32 MipsCount;
        public CCompressedBuffer<SMipData> Mipdata;
        public CUInt32 unk2;
        // Imported Textures
        public CCompressedBuffer<CByteArray> Mips;
        // Cooked Textures
        public CUInt32 ResidentmipSize;
        public CBytes Residentmip;


        public CBitmapTexture(CR2WFile cr2w) : base(cr2w)
        {

            unk = new CUInt32(cr2w) { Name = "unk" };
            MipsCount = new CUInt32(cr2w) { Name = "MipsCount" };
            Mipdata = new CCompressedBuffer<SMipData>(cr2w, _ => new SMipData(_)) { Name = "Mipdata" };
            unk2 = new CUInt32(cr2w) { Name = "unk2" };
            Mips = new CCompressedBuffer<CByteArray>(cr2w, _ => new CByteArray(_)) { Name = "mips" };
            ResidentmipSize = new CUInt32(cr2w) { Name = "filesize" };
            Residentmip = new CBytes(cr2w) { Name = "Image" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            unk.Read(file, 4);
            MipsCount.Read(file, 4);

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

            //if (MipsCount.val > 0)
            //    mips.Read(file, size, (int)MipsCount.val);
            //else
            //    mips.Read(file, size, 1);

            //ResidentmipSize.Read(file, 4);
            //unk2.Read(file, 4);

            //Residentmip.Bytes = file.ReadBytes((int)ResidentmipSize.val);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            unk.Write(file);
            MipsCount.Write(file);

            Mips.Write(file);

            ResidentmipSize.Write(file);
            unk2.Write(file);

            Residentmip.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBitmapTexture(cr2w);
        }
    }
}

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
    public class CTextureArray : CResource
    {
        [RED("bitmaps", 2, 0)] public CArray<CTextureArrayEntry> Bitmaps { get; set; }

        [RED("textureGroup")] public CName TextureGroup { get; set; }

        // 24 bytes header
        [REDBuffer] public CUInt32 texturecachekey { get; set; }

        [REDBuffer] public CUInt16 encodedformat { get; set; }
        [REDBuffer] public CUInt16 width { get; set; }

        [REDBuffer] public CUInt16 height { get; set; }
        [REDBuffer] public CUInt16 slices { get; set; }

        [REDBuffer] public CUInt16 mipmapscount { get; set; }
        [REDBuffer] public CUInt16 residentmip { get; set; }

        [REDBuffer] public CUInt32 filesize { get; set; }
        [REDBuffer] public CInt32 ffffffff { get; set; }

        [REDBuffer(true)] public CBytes rawfile { get; set; }


        public CTextureArray(CR2WFile cr2w) : base(cr2w)
        {
            texturecachekey = new CUInt32(cr2w)
            {
                Name = "texturecachekey"
            };
            encodedformat = new CUInt16(cr2w)
            {
                Name = "encodedformat"
            };
            width = new CUInt16(cr2w) // or width
            {
                Name = "width"
            };
            height = new CUInt16(cr2w) // or height
            {
                Name = "height"
            };
            slices = new CUInt16(cr2w) // ?
            {
                Name = "slices"
            };
            mipmapscount = new CUInt16(cr2w)
            {
                Name = "mipmapscount"
            };
            residentmip = new CUInt16(cr2w) //?
            {
                Name = "residentmip"
            };

            filesize = new CUInt32(cr2w) { Name = "filesize" };
            ffffffff = new CInt32(cr2w) { Name = "ffffffff" };

            rawfile = new CBytes(cr2w) { Name = "rawfile" };
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            texturecachekey.Read(file, 4);
            encodedformat.Read(file, 2);
            width.Read(file, 2);
            height.Read(file, 2);
            slices.Read(file, 2);
            mipmapscount.Read(file, 2);
            residentmip.Read(file, 2);

            filesize.Read(file, 4);
            ffffffff.Read(file, 4);

            rawfile.Read(file, filesize.val);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            texturecachekey.Write(file);
            encodedformat.Write(file);
            width.Write(file);
            height.Write(file);
            slices.Write(file);
            mipmapscount.Write(file);
            residentmip.Write(file);

            filesize.Write(file);
            ffffffff.Write(file);

            rawfile.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CTextureArray(cr2w);
        }
    }
}
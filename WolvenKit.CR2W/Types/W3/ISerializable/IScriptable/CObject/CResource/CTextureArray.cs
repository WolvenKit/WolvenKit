using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{




    [DataContract(Namespace = "")]
    public class CTextureArray : CVector
    {
        // 24 bytes header
        public CUInt32 texturecachekey;

        public CUInt16 encodedformat;
        public CUInt16 width;

        public CUInt16 height;
        public CUInt16 slices;

        public CUInt16 mipmapscount;
        public CUInt16 residentmip;

        public CUInt32 filesize;
        public CInt32 ffffffff;

        public CBytes rawfile;


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

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CTextureArray)base.Copy(context);

            var.texturecachekey = (CUInt32)texturecachekey.Copy(context);
            var.encodedformat = (CUInt16)encodedformat.Copy(context);
            var.width = (CUInt16)width.Copy(context);
            var.height = (CUInt16)height.Copy(context);
            var.slices = (CUInt16)slices.Copy(context);
            var.mipmapscount = (CUInt16)mipmapscount.Copy(context);
            var.residentmip = (CUInt16)residentmip.Copy(context);

            var.filesize = (CUInt32)filesize.Copy(context);
            var.ffffffff = (CInt32)ffffffff.Copy(context);

            var.rawfile = (CBytes)rawfile.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                texturecachekey,
                encodedformat,
                width,
                height,
                slices,
                mipmapscount,
                filesize,
                ffffffff,
                rawfile
            };
        }
    }
}
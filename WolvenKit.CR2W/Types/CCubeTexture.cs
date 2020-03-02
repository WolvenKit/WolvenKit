using System.Collections.Generic;
using System.IO;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{




    public class CCubeTexture : CVector
    {
        public CUInt32 texturecachekey;

        public CUInt16 residentmip;
        public CUInt16 encodedformat;

        public CUInt16 dimensions;
        public CUInt16 mipmapscount;

        public CUInt32 filesize;
        public CInt32 ffffffff;

        public CBytes left;
        public CBytes right;
        public CBytes front;
        public CBytes back;
        public CBytes top;
        public CBytes bottom;


        public CCubeTexture(CR2WFile cr2w) : base(cr2w)
        {
            texturecachekey = new CUInt32(cr2w)
            {
                Name = "texturecachekey"
            };
            residentmip = new CUInt16(cr2w)
            {
                Name = "residentmip"
            };
            encodedformat = new CUInt16(cr2w)
            {
                Name = "encodedformat"
            };
            dimensions = new CUInt16(cr2w)
            {
                Name = "dimensions"
            };
            mipmapscount = new CUInt16(cr2w)
            {
                Name = "mipmapscount"
            };

            filesize = new CUInt32(cr2w) { Name = "filesize" };
            ffffffff = new CInt32(cr2w) { Name = "ffffffff" };

            left = new CBytes(cr2w) { Name = "left" };
            right = new CBytes(cr2w) { Name = "right" };
            front = new CBytes(cr2w) { Name = "front" };
            back = new CBytes(cr2w) { Name = "back" };
            top = new CBytes(cr2w) { Name = "top" };
            bottom = new CBytes(cr2w) { Name = "bottom" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            texturecachekey.Read(file, 4);
            residentmip.Read(file, 2);
            encodedformat.Read(file, 2);
            dimensions.Read(file, 2);
            mipmapscount.Read(file, 2);

            filesize.Read(file, 4);
            ffffffff.Read(file, 4);

            left.Bytes = file.ReadBytes((int)(filesize.val / 6));
            right.Bytes = file.ReadBytes((int)(filesize.val / 6));
            front.Bytes = file.ReadBytes((int)(filesize.val / 6));
            back.Bytes = file.ReadBytes((int)(filesize.val / 6));
            top.Bytes = file.ReadBytes((int)(filesize.val / 6));
            bottom.Bytes = file.ReadBytes((int)(filesize.val / 6));
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            texturecachekey.Write(file);
            residentmip.Write(file);
            encodedformat.Write(file);
            dimensions.Write(file);
            mipmapscount.Write(file);

            filesize.Write(file);
            ffffffff.Write(file);

            left.Write(file);
            right.Write(file);
            front.Write(file);
            back.Write(file);
            top.Write(file);
            bottom.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CCubeTexture(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CCubeTexture)base.Copy(context);

            var.texturecachekey = (CUInt32)texturecachekey.Copy(context);
            var.residentmip = (CUInt16)residentmip.Copy(context);
            var.encodedformat = (CUInt16)encodedformat.Copy(context);
            var.dimensions = (CUInt16)dimensions.Copy(context);
            var.mipmapscount = (CUInt16)mipmapscount.Copy(context);

            var.filesize = (CUInt32)filesize.Copy(context);
            var.ffffffff = (CInt32)ffffffff.Copy(context);

            var.left = (CBytes) left.Copy(context);
            var.right = (CBytes) right.Copy(context);
            var.front = (CBytes) front.Copy(context);
            var.back = (CBytes) back.Copy(context);
            var.top = (CBytes) top.Copy(context);
            var.bottom = (CBytes) bottom.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                texturecachekey,
                residentmip,
                encodedformat,
                dimensions,
                mipmapscount,
                filesize,
                ffffffff,
                left,
                right,
                front,
                back,
                top,
                bottom
            };
        }
    }
}
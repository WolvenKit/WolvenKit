using System.Collections.Generic;
using System.IO;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{




    [DataContract(Namespace = "")]
    public class CCubeTexture : CVector
    {
        // 20 bytes header
        public CUInt32 texturecachekey;

        public CUInt16 residentmip;
        public CUInt16 encodedformat;

        public CUInt16 edge;
        public CUInt16 mipmapscount;

        public CUInt32 filesize;
        public CInt32 ffffffff;

        public CBytes rawfile;


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
            edge = new CUInt16(cr2w)
            {
                Name = "edge"
            };
            mipmapscount = new CUInt16(cr2w)
            {
                Name = "mipmapscount"
            };

            filesize = new CUInt32(cr2w) { Name = "filesize" };
            ffffffff = new CInt32(cr2w) { Name = "ffffffff" };

            rawfile = new CBytes(cr2w) { Name = "rawfile" };
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            texturecachekey.Read(file, 4);
            residentmip.Read(file, 2);
            encodedformat.Read(file, 2);
            edge.Read(file, 2);
            mipmapscount.Read(file, 2);

            filesize.Read(file, 4);
            ffffffff.Read(file, 4);

            rawfile.Read(file, filesize.val);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            texturecachekey.Write(file);
            residentmip.Write(file);
            encodedformat.Write(file);
            edge.Write(file);
            mipmapscount.Write(file);

            filesize.Write(file);
            ffffffff.Write(file);

            rawfile.Write(file);
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
            var.edge = (CUInt16)edge.Copy(context);
            var.mipmapscount = (CUInt16)mipmapscount.Copy(context);

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
                residentmip,
                encodedformat,
                edge,
                mipmapscount,
                filesize,
                ffffffff,
                rawfile
            };
        }
    }
}
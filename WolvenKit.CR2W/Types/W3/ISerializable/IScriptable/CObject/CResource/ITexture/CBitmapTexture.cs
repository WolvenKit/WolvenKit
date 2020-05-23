using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{

    public class CBitmapTexture : CVector
    {
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
            var SourceData = this.GetVariableByName("SourceData");

            if (SourceData != null)
            {
                //dbg
                var ResidentMipIndex = this.GetVariableByName("ResidentMipIndex");
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

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBitmapTexture(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CBitmapTexture)base.Copy(context);
            var.unk = (CUInt32)unk.Copy(context);
            var.Mips = (CCompressedBuffer<CByteArray>)Mips.Copy(context);
            var.ResidentmipSize = (CUInt32)ResidentmipSize.Copy(context);
            var.unk2 = (CUInt32)unk2.Copy(context);
            var.Residentmip = (CBytes)Residentmip.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                unk,
                Mips,
                ResidentmipSize,
                unk2,
                Residentmip
            };
            return list;
        }
    }
}

using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{

    public class CBitmapTexture : CVector
    {
        public CBytes Image;
        public CUInt32 unk;
        public CUInt32 MipsCount;
        public CCompressedBuffer<CVector3<CUInt32>> mips;
        public CUInt32 filesize;
        public CUInt32 unk2;

        public CBitmapTexture(CR2WFile cr2w) : base(cr2w)
        {

            unk = new CUInt32(cr2w) { Name = "unk" };
            MipsCount = new CUInt32(cr2w) { Name = "MipsCount" };
            mips = new CCompressedBuffer<CVector3<CUInt32>>(cr2w, _ => new CVector3<CUInt32>(_, x => new CUInt32(x))) { Name = "mips" };
            filesize = new CUInt32(cr2w) { Name = "filesize" };
            unk2 = new CUInt32(cr2w) { Name = "unk2" };

            Image = new CBytes(cr2w) { Name = "Image" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            unk.Read(file, 4);
            MipsCount.Read(file, 4);

            if (MipsCount.val > 0)
                mips.Read(file, size, (int)MipsCount.val);
            else
                mips.Read(file, size, 1);

            filesize.Read(file, 4);
            unk2.Read(file, 4);


            Image.Bytes = file.ReadBytes((int)filesize.val);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            unk.Write(file);
            mips.Write(file);
            filesize.Write(file);
            unk2.Write(file);

            Image.Write(file);
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
            var.mips = (CCompressedBuffer<CVector3<CUInt32>>)mips.Copy(context);
            var.filesize = (CUInt32)filesize.Copy(context);
            var.unk2 = (CUInt32)unk2.Copy(context);
            var.Image = (CBytes)Image.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                unk,
                mips,
                filesize,
                unk2,
                Image
            };
            return list;
        }
    }
}

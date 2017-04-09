using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{

    public class CBitmapTexture : CVector
    {
        public CByteArray Image;

        public CBitmapTexture(CR2WFile cr2w) : base(cr2w)
        {
            Image = new CByteArray(cr2w) {Name = "Image"};
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            Image.Bytes = file.ReadBytes((int)(file.BaseStream.Length - file.BaseStream.Position));
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            file.Write(Image.Bytes);
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
            var var = (CBitmapTexture) base.Copy(context);
            var.Image = (CByteArray) Image.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables) {Image};
            return list;
        }
    }
}

using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class SAppearanceAttachment : CVector
    {
        public CBytes bytes;

        public SAppearanceAttachment(CR2WFile cr2w)
            : base(cr2w)
        {
            bytes = new CBytes(cr2w);
            bytes.Name = "unknownBytes";
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var bytecount = file.ReadUInt32();
            bytes.Bytes = file.ReadBytes((int) bytecount - 4);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            file.Write((uint) (bytes.Bytes.Length + 4));
            file.Write(bytes.Bytes);
        }

        public override CVariable SetValue(object val)
        {
            if (val is byte[])
            {
                bytes.Bytes = (byte[]) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SAppearanceAttachment(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SAppearanceAttachment) base.Copy(context);
            var.bytes = (CBytes) bytes.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);
            list.Add(bytes);
            return list;
        }
    }
}
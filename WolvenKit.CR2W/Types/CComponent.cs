using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CComponent : CVector
    {
        public CArray attachments;
        public CUInt32 tail;

        public CComponent(CR2WFile cr2w) :
            base(cr2w)
        {
            tail = new CUInt32(cr2w)
            {
                Name = "tail",
            };

            attachments = new CArray("[]handle:attachment", "handle:attachment", true, cr2w);
            attachments.Name = "attachments";
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            attachments.Read(file, size);

            tail.val = file.ReadUInt32();
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            attachments.Write(file);

            file.Write(tail.val);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CComponent(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CComponent) base.Copy(context);
            var.attachments = (CArray) attachments.Copy(context);
            var.tail = tail;
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);
            list.Add(attachments);
            list.Add(tail);
            return list;
        }
    }
}
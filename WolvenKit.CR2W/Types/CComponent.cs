using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CComponent : CVector
    {
        public CArray attachments;
        public CBytes tail;

        public CComponent(CR2WFile cr2w) :
            base(cr2w)
        {
            tail = new CBytes(cr2w)
            {
                Name = "tail",
            };

            attachments = new CArray("[]handle:attachment", "handle:attachment", true, cr2w);
            attachments.Name = "attachments";
        }

        public override void Read(BinaryReader file, uint size)
        {
            var startPos = file.BaseStream.Position;

            base.Read(file, size);

            var endPos = file.BaseStream.Position;
            var bytesleft = size - (endPos - startPos);


            if (bytesleft > 0)
            {
                attachments.Read(file, size);
                tail.Bytes = file.ReadBytes(4);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            //if (attachments.array.Count > 0)
                attachments.Write(file);

            if (tail.Bytes.Length > 0)
                tail.Write(file);
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
            if (tail.Bytes != null)
                list.Add(tail);
            return list;
        }
    }
}
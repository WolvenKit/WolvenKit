using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CComponent : CVector
    {
        public CArray attachmentsReference;
        public CArray attachmentsChild;

        public CComponent(CR2WFile cr2w) :
            base(cr2w)
        {

            attachmentsReference = new CArray("[]handle:attachment", "handle:attachment", true, cr2w)
            {
                Name = "attachments reference"
            };
            attachmentsChild = new CArray("[]handle:attachment", "handle:attachment", true, cr2w)
            {
                Name = "child attachments"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            attachmentsReference.Read(file, size);
            attachmentsChild.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            attachmentsReference.Write(file);
            attachmentsChild.Write(file);
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
            var.attachmentsReference = (CArray) attachmentsReference.Copy(context);
            var.attachmentsChild = (CArray) attachmentsChild.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);
            list.Add(attachmentsReference);
            list.Add(attachmentsChild);
            return list;
        }
    }
}
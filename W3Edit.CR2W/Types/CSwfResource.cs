using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Edit.CR2W.Editors;

namespace W3Edit.CR2W.Types
{
    public class CSwfResource : CVector
    {
        public CByteArray swfResource;

        public CSwfResource(CR2WFile cr2w) :
            base(cr2w)
        {
            swfResource = new CByteArray(cr2w);
            swfResource.Name = "swfResource";
        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            base.Read(file, size);
            swfResource.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            swfResource.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSwfResource(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CSwfResource)base.Copy(context);

            var.swfResource = (CByteArray)swfResource.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);
            list.Add(swfResource);
            return list;
        }
    }
}

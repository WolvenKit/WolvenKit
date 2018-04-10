using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class CRagdoll : CVector
    {
        public CXml Ragdolldata;

        public CRagdoll(CR2WFile cr2w) : base(cr2w)
        {
            Ragdolldata = new CXml(cr2w){Name = "XMLData"};
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            Ragdolldata.Read(file,size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            Ragdolldata.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            if (val is CXml)
            {
                Ragdolldata = (CXml) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CRagdoll(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CRagdoll) base.Copy(context);
            var.Ragdolldata = (CXml)Ragdolldata.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables) {Ragdolldata};
            return list;
        }
    }
}

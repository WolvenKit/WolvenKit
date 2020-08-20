using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CPhysicsDestructionResource : CMesh
    {
        public CArray block5;

        public CPhysicsDestructionResource(CR2WFile cr2w) :
            base(cr2w)
        {
            block5 = new CArray("[]SMeshBlock5", "SMeshBlock5", true, cr2w)
            {
                Name = "block5"
            };

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            block5.Read(file, 46);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            block5.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CPhysicsDestructionResource(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CPhysicsDestructionResource) base.Copy(context);

            var.block5 = (CArray)block5.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(base.GetEditableVariables())
            {
                block5
            };
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    class CLayerInfo : CVector
    {
        public CHandle ParentGroup;

        public CLayerInfo(CR2WFile cr2w) : base(cr2w)
        {
            ParentGroup = new CHandle(cr2w) { Name = "ParentGroup" };

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            ParentGroup.ChunkHandle = true;
            ParentGroup.Read(file, 4);

            //base.AddVariable(ParentGroup);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            ParentGroup.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CLayerInfo(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CLayerInfo)base.Copy(context);

            var.ParentGroup = (CHandle)ParentGroup.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                ParentGroup
            };
            return list;
        }
    }
}

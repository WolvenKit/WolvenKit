using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    class CGenericGrassMask : CVector
    {
        public CBytes grassmask;

        public CGenericGrassMask(CR2WFile cr2w) : base(cr2w)
        {
            grassmask = new CBytes(cr2w)
            {
                Name = "Grass mask data",
                Bytes = new byte[0]
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            if (cr2w.GetChunkByType("CGenericGrassMask").GetVariableByName("maskRes") != null)
            {
                var res = ((CUInt32)cr2w.GetChunkByType("CGenericGrassMask").GetVariableByName("maskRes")).val;
                grassmask.Bytes = file.ReadBytes((int)(res * res >> 3));
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            if (grassmask.Bytes.Length > 0)
                grassmask.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CGenericGrassMask(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CGenericGrassMask) base.Copy(context);
            var.grassmask = (CBytes)grassmask;           
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var vars = new List<IEditableVariable>(base.GetEditableVariables())
            {
                grassmask
            };
            return vars;
        }
    }
}

using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CSkeleton : CVector
    {
        public CCompressedBuffer<SSkeletonRigData> rigdata;
            
        public CSkeleton(CR2WFile cr2w) : base(cr2w)
        {
            rigdata = new CCompressedBuffer<SSkeletonRigData>(cr2w, _ => new SSkeletonRigData(_)) { Name = "rigdata" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            // get bonecount for compressed buffers
            CArray bones = variables.FirstOrDefault(_ => _.Name == "bones") as CArray;
            int bonecount = bones.array.Count;

            rigdata.Read(file, (uint)bonecount * 48, bonecount);
            
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            rigdata.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSkeleton(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CSkeleton) base.Copy(context);

            var.rigdata = (CCompressedBuffer<SSkeletonRigData>)rigdata.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                rigdata,
            };
        }
    }
}
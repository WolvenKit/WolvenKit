using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CBehaviorGraph : CVector
    {
        public CHandle Toplevelnode;

        public CUInt32 unk2;
        public CBufferUInt32<IdHandle> variables1;

        public CUInt32 unk3;
        public CBufferVLQ<CHandle> descriptions;

        public CUInt32 unk4;
        public CBufferUInt32<IdHandle> vectorvariables1;

        public CUInt32 unk5;
        public CBufferUInt32<IdHandle> variables2;

        public CUInt32 unk6;
        public CBufferUInt32<IdHandle> vectorvariables2;

        public CBehaviorGraph(CR2WFile cr2w) :
            base(cr2w)
        {
            Toplevelnode = new CHandle(cr2w) { Name = "Toplevelnode" };
            unk2 = new CUInt32(cr2w) { Name = "unk2" };
            variables1 = new CBufferUInt32<IdHandle>(cr2w, _ => new IdHandle(_)) { Name = "variables1" };

            unk3 = new CUInt32(cr2w) { Name = "unk3" };
            descriptions = new CBufferVLQ<CHandle>(cr2w, _ => new CHandle(_)) { Name = "descriptions" };

            unk4 = new CUInt32(cr2w) { Name = "unk4" };
            vectorvariables1 = new CBufferUInt32<IdHandle>(cr2w, _ => new IdHandle(_)) { Name = "vectorvariables1" };

            unk5 = new CUInt32(cr2w) { Name = "unk5" };
            variables2 = new CBufferUInt32<IdHandle>(cr2w, _ => new IdHandle(_)) { Name = "variables2" };

            unk6 = new CUInt32(cr2w) { Name = "unk6" };
            vectorvariables2 = new CBufferUInt32<IdHandle>(cr2w, _ => new IdHandle(_)) { Name = "vectorvariables2" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            Toplevelnode.Read(file, 0);

            unk2.Read(file, 0);
            variables1.Read(file, 0);

            unk3.Read(file, 0);
            descriptions.Read(file, 0);

            unk4.Read(file, 0);
            vectorvariables1.Read(file, 0);

            unk5.Read(file, 0);
            variables2.Read(file, 0);

            unk6.Read(file, 0);
            vectorvariables2.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Toplevelnode.Write(file);

            unk2.Write(file);
            variables1.Write(file);

            unk3.Write(file);
            descriptions.Write(file);

            unk4.Write(file);
            vectorvariables1.Write(file);

            unk5.Write(file);
            variables2.Write(file);

            unk6.Write(file);
            vectorvariables2.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBehaviorGraph(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CBehaviorGraph) base.Copy(context);

            var.Toplevelnode = (CHandle) Toplevelnode.Copy(context);
            var.unk2 = (CUInt32) unk2.Copy(context);
            var.variables1 = (CBufferUInt32<IdHandle>)variables1.Copy(context);

            var.unk3 = (CUInt32) unk3.Copy(context);
            var.descriptions = (CBufferVLQ<CHandle>)descriptions.Copy(context);

            var.unk4 = (CUInt32) unk4.Copy(context);
            var.vectorvariables1 = (CBufferUInt32<IdHandle>)vectorvariables1.Copy(context);

            var.unk5 = (CUInt32)unk5.Copy(context);
            var.variables2 = (CBufferUInt32<IdHandle>)variables2.Copy(context);

            var.unk6 = (CUInt32)unk6.Copy(context);
            var.vectorvariables2 = (CBufferUInt32<IdHandle>)vectorvariables2.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                Toplevelnode,
                unk2,
                variables1,
                unk3,
                descriptions,
                unk4,
                vectorvariables1,
                unk5,
                variables2,
                unk6,
                vectorvariables2
            };
        }
    }
}
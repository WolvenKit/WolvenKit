using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CBehaviorGraphStateMachineNode : CVector
    {
        public CBufferVLQ<CHandle> inputnodes;
        public CBufferVLQ<CName> unk1;
        public CBufferVLQ<CName> unk2;

        public CBufferVLQ<CHandle> unk3;
        public CBufferVLQ<CHandle> unk4;
        public CHandle handle1;
        public CHandle outputnode;
            
        public CBehaviorGraphStateMachineNode(CR2WFile cr2w) :
            base(cr2w)
        {
            inputnodes = new CBufferVLQ<CHandle>(cr2w, _ => new CHandle(_) { ChunkHandle = true, }) { Name = "inputnodes" };
            unk1 = new CBufferVLQ<CName>(cr2w, _ => new CName(_) ) { Name = "unk1" };
            unk2 = new CBufferVLQ<CName>(cr2w, _ => new CName(_) ) { Name = "unk2" };
            unk3 = new CBufferVLQ<CHandle>(cr2w, _ => new CHandle(_) ) { Name = "unk3" };
            unk4 = new CBufferVLQ<CHandle>(cr2w, _ => new CHandle(_) ) { Name = "unk4" };
            handle1 = new CHandle(cr2w) { Name = "handle1", ChunkHandle = true };
            outputnode = new CHandle(cr2w) { Name = "outputnode", ChunkHandle = true };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            inputnodes.Read(file, 0);
            unk1.Read(file, 0);
            unk2.Read(file, 0);
            unk3.Read(file, 0);
            unk4.Read(file, 0);
            handle1.Read(file, 0);
            outputnode.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            inputnodes.Write(file);
            unk1.Write(file);
            unk2.Write(file);
            unk3.Write(file);
            unk4.Write(file);
            handle1.Write(file);
            outputnode.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBehaviorGraphStateMachineNode(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CBehaviorGraphStateMachineNode) base.Copy(context);

            var.inputnodes = (CBufferVLQ<CHandle>)inputnodes.Copy(context);
            var.unk1 = (CBufferVLQ<CName>) unk1.Copy(context);
            var.unk2 = (CBufferVLQ<CName>) unk2.Copy(context);
            var.unk3 = (CBufferVLQ<CHandle>) unk3.Copy(context);
            var.unk4 = (CBufferVLQ<CHandle>) unk4.Copy(context);
            var.handle1 = (CHandle)handle1.Copy(context);
            var.outputnode = (CHandle)outputnode.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                inputnodes,
                unk1,
                unk2,
                unk3,
                unk4,
                handle1,
                outputnode,
            };
        }
    }
}
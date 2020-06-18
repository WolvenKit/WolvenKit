using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CBehaviorGraphStateMachineNode : CBehaviorGraphContainerNode
    {
        [RED("globalTransitions", 2, 0)] public CArray<CPtr<CBehaviorGraphStateTransitionGlobalBlendNode>> GlobalTransitions { get; set; }

        [RED("resetStateOnExit")] public CBool ResetStateOnExit { get; set; }

        [RED("applySyncTags")] public CBool ApplySyncTags { get; set; }

        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> _inputnodes { get; set; } //FIXME
        [REDBuffer] public CBufferVLQ<CName> _unk1 { get; set; }
        [REDBuffer] public CBufferVLQ<CName> _unk2 { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> unk3 { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> unk4 { get; set; }
        [REDBuffer] public CHandle<CBehaviorVariable> handle1 { get; set; }
        [REDBuffer] public CHandle<CBehaviorVariable> _outputnode { get; set; }

        public CBehaviorGraphStateMachineNode(CR2WFile cr2w) :
            base(cr2w)
        {
            
        }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBehaviorGraphStateMachineNode(cr2w);
        }

        
    }
}
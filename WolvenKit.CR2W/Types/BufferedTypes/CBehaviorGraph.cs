using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
    [REDMeta]
    public class CBehaviorGraph : CResource
    {
        [RED("defaultStateMachine")] public CPtr<CBehaviorGraphStateMachineNode> DefaultStateMachine { get; set; }

        [RED("stateMachines", 2, 0)] public CArray<CPtr<CBehaviorGraphStateMachineNode>> StateMachines { get; set; }

        [RED("sourceDataRemoved")] public CBool SourceDataRemoved { get; set; }

        [RED("customTrackNames", 2, 0)] public CArray<CName> CustomTrackNames { get; set; }

        [RED("generateEditorFragments")] public CBool GenerateEditorFragments { get; set; }

        [RED("poseSlots", 2, 0)] public CArray<CPtr<CBehaviorGraphPoseSlotNode>> PoseSlots { get; set; }

        [RED("animSlots", 2, 0)] public CArray<CPtr<CBehaviorGraphAnimationBaseSlotNode>> AnimSlots { get; set; }

        [REDBuffer] public CHandle<CBehaviorVariable> Toplevelnode { get; set; }

        [REDBuffer] public CUInt32 Unk2 { get; set; }
        [REDBuffer] public CArray<IdHandle> Variables1 { get; set; }

        [REDBuffer] public CUInt32 Unk3 { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> Descriptions { get; set; } //FIXME

        [REDBuffer] public CUInt32 Unk4 { get; set; }
        [REDBuffer] public CArray<IdHandle> Vectorvariables1 { get; set; }

        [REDBuffer] public CUInt32 Unk5 { get; set; }
        [REDBuffer] public CArray<IdHandle> Variables2 { get; set; }

        [REDBuffer] public CUInt32 Unk6 { get; set; }
        [REDBuffer] public CArray<IdHandle> Vectorvariables2 { get; set; }

        public CBehaviorGraph(CR2WFile cr2w) :
            base(cr2w)
        {

        }

        

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBehaviorGraph(cr2w);
        }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);
    }
}
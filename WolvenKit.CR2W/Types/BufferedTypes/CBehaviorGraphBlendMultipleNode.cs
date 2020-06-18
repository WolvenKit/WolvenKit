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
    public class ShBlendMultipleNodeData : CVariable
    {
        [REDBuffer] public CUInt32 index { get; set; }
        [REDBuffer] public CFloat blendvalue { get; set; }


        public ShBlendMultipleNodeData(CR2WFile cr2w) :
            base(cr2w)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {


        }

        public override void Write(BinaryWriter file)
        {


        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new ShBlendMultipleNodeData(cr2w);
        }
    }




    [DataContract(Namespace = "")]
    public class CBehaviorGraphBlendMultipleNode : CBehaviorGraphNode
    {
        [RED("synchronize")] public CBool Synchronize { get; set; }

        [RED("syncMethod")] public CPtr<IBehaviorSyncMethod> SyncMethod { get; set; }

        [RED("inputValues", 2, 0)] public CArray<CFloat> InputValues { get; set; }

        [RED("minControlValue")] public CFloat MinControlValue { get; set; }

        [RED("maxControlValue")] public CFloat MaxControlValue { get; set; }

        [RED("radialBlending")] public CBool RadialBlending { get; set; }

        [RED("takeEventsFromMoreImportantInput")] public CBool TakeEventsFromMoreImportantInput { get; set; }

        [RED("cachedInputNodes", 2, 0)] public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set; }

        [RED("cachedControlValueNode")] public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set; }

        [RED("cachedMinControlValue")] public CPtr<CBehaviorGraphValueNode> CachedMinControlValue { get; set; }

        [RED("cachedMaxControlValue")] public CPtr<CBehaviorGraphValueNode> CachedMaxControlValue { get; set; }

        [REDBuffer] public CBufferVLQ<ShBlendMultipleNodeData> bufferinputvalues { get; set; }
        
            
        public CBehaviorGraphBlendMultipleNode(CR2WFile cr2w) :
            base(cr2w)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBehaviorGraphBlendMultipleNode(cr2w);
        }
    }
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlendOverrideNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("synchronize")] 		public CBool Synchronize { get; set;}

		[Ordinal(2)] [RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[Ordinal(3)] [RED("synchronizeInputFromParent")] 		public CBool SynchronizeInputFromParent { get; set;}

		[Ordinal(4)] [RED("synchronizeOverrideFromParent")] 		public CBool SynchronizeOverrideFromParent { get; set;}

		[Ordinal(5)] [RED("syncMethodFromParent")] 		public CPtr<IBehaviorSyncMethod> SyncMethodFromParent { get; set;}

		[Ordinal(6)] [RED("lodAtOrAboveLevel")] 		public CEnum<EBehaviorLod> LodAtOrAboveLevel { get; set;}

		[Ordinal(7)] [RED("Bones with weights", 2,0)] 		public CArray<SBehaviorGraphBoneInfo> Bones_with_weights { get; set;}

		[Ordinal(8)] [RED("alwaysActiveOverrideInput")] 		public CBool AlwaysActiveOverrideInput { get; set;}

		[Ordinal(9)] [RED("getDeltaMotionFromOverride")] 		public CBool GetDeltaMotionFromOverride { get; set;}

		[Ordinal(10)] [RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[Ordinal(11)] [RED("cachedOverrideInputNode")] 		public CPtr<CBehaviorGraphNode> CachedOverrideInputNode { get; set;}

		[Ordinal(12)] [RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		public CBehaviorGraphBlendOverrideNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
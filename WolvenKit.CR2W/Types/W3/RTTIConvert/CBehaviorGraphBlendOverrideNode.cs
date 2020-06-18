using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlendOverrideNode : CBehaviorGraphNode
	{
		[RED("synchronize")] 		public CBool Synchronize { get; set;}

		[RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[RED("synchronizeInputFromParent")] 		public CBool SynchronizeInputFromParent { get; set;}

		[RED("synchronizeOverrideFromParent")] 		public CBool SynchronizeOverrideFromParent { get; set;}

		[RED("syncMethodFromParent")] 		public CPtr<IBehaviorSyncMethod> SyncMethodFromParent { get; set;}

		[RED("lodAtOrAboveLevel")] 		public CEnum<EBehaviorLod> LodAtOrAboveLevel { get; set;}

		[RED("Bones with weights", 2,0)] 		public CArray<SBehaviorGraphBoneInfo> Bones_with_weights { get; set;}

		[RED("alwaysActiveOverrideInput")] 		public CBool AlwaysActiveOverrideInput { get; set;}

		[RED("getDeltaMotionFromOverride")] 		public CBool GetDeltaMotionFromOverride { get; set;}

		[RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[RED("cachedOverrideInputNode")] 		public CPtr<CBehaviorGraphNode> CachedOverrideInputNode { get; set;}

		[RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		public CBehaviorGraphBlendOverrideNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphBlendOverrideNode(cr2w);

	}
}
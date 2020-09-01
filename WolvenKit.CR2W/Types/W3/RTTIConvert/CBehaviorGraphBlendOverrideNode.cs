using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlendOverrideNode : CBehaviorGraphNode
	{
		[Ordinal(0)] [RED("("synchronize")] 		public CBool Synchronize { get; set;}

		[Ordinal(0)] [RED("("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[Ordinal(0)] [RED("("synchronizeInputFromParent")] 		public CBool SynchronizeInputFromParent { get; set;}

		[Ordinal(0)] [RED("("synchronizeOverrideFromParent")] 		public CBool SynchronizeOverrideFromParent { get; set;}

		[Ordinal(0)] [RED("("syncMethodFromParent")] 		public CPtr<IBehaviorSyncMethod> SyncMethodFromParent { get; set;}

		[Ordinal(0)] [RED("("lodAtOrAboveLevel")] 		public CEnum<EBehaviorLod> LodAtOrAboveLevel { get; set;}

		[Ordinal(0)] [RED("("Bones with weights", 2,0)] 		public CArray<SBehaviorGraphBoneInfo> Bones_with_weights { get; set;}

		[Ordinal(0)] [RED("("alwaysActiveOverrideInput")] 		public CBool AlwaysActiveOverrideInput { get; set;}

		[Ordinal(0)] [RED("("getDeltaMotionFromOverride")] 		public CBool GetDeltaMotionFromOverride { get; set;}

		[Ordinal(0)] [RED("("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[Ordinal(0)] [RED("("cachedOverrideInputNode")] 		public CPtr<CBehaviorGraphNode> CachedOverrideInputNode { get; set;}

		[Ordinal(0)] [RED("("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		public CBehaviorGraphBlendOverrideNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphBlendOverrideNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
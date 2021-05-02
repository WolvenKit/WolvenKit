using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAnimationMixerSlotNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("bodyOrMimicMode")] 		public CBool BodyOrMimicMode { get; set;}

		[Ordinal(2)] [RED("canUseIdles")] 		public CBool CanUseIdles { get; set;}

		[Ordinal(3)] [RED("postIdleAdditiveType")] 		public CEnum<EAdditiveType> PostIdleAdditiveType { get; set;}

		[Ordinal(4)] [RED("postAllAdditiveType")] 		public CEnum<EAdditiveType> PostAllAdditiveType { get; set;}

		[Ordinal(5)] [RED("fullEyesWeightMimicsTracks", 2,0)] 		public CArray<CName> FullEyesWeightMimicsTracks { get; set;}

		[Ordinal(6)] [RED("cachedPostIdleNodeA")] 		public CPtr<CBehaviorGraphNode> CachedPostIdleNodeA { get; set;}

		[Ordinal(7)] [RED("cachedPostIdleNodeB")] 		public CPtr<CBehaviorGraphNode> CachedPostIdleNodeB { get; set;}

		[Ordinal(8)] [RED("cachedPostAllNodeA")] 		public CPtr<CBehaviorGraphNode> CachedPostAllNodeA { get; set;}

		[Ordinal(9)] [RED("cachedPostAllNodeB")] 		public CPtr<CBehaviorGraphNode> CachedPostAllNodeB { get; set;}

		[Ordinal(10)] [RED("debugOverride")] 		public CBool DebugOverride { get; set;}

		public CBehaviorGraphAnimationMixerSlotNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAnimationMixerSlotNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
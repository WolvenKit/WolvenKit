using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAnimationMixerSlotNode : CBehaviorGraphBaseNode
	{
		[Ordinal(0)] [RED("bodyOrMimicMode")] 		public CBool BodyOrMimicMode { get; set;}

		[Ordinal(0)] [RED("canUseIdles")] 		public CBool CanUseIdles { get; set;}

		[Ordinal(0)] [RED("postIdleAdditiveType")] 		public CEnum<EAdditiveType> PostIdleAdditiveType { get; set;}

		[Ordinal(0)] [RED("postAllAdditiveType")] 		public CEnum<EAdditiveType> PostAllAdditiveType { get; set;}

		[Ordinal(0)] [RED("fullEyesWeightMimicsTracks", 2,0)] 		public CArray<CName> FullEyesWeightMimicsTracks { get; set;}

		[Ordinal(0)] [RED("cachedPostIdleNodeA")] 		public CPtr<CBehaviorGraphNode> CachedPostIdleNodeA { get; set;}

		[Ordinal(0)] [RED("cachedPostIdleNodeB")] 		public CPtr<CBehaviorGraphNode> CachedPostIdleNodeB { get; set;}

		[Ordinal(0)] [RED("cachedPostAllNodeA")] 		public CPtr<CBehaviorGraphNode> CachedPostAllNodeA { get; set;}

		[Ordinal(0)] [RED("cachedPostAllNodeB")] 		public CPtr<CBehaviorGraphNode> CachedPostAllNodeB { get; set;}

		[Ordinal(0)] [RED("debugOverride")] 		public CBool DebugOverride { get; set;}

		public CBehaviorGraphAnimationMixerSlotNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAnimationMixerSlotNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
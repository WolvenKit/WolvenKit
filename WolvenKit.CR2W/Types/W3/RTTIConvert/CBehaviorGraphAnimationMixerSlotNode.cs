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
		[RED("bodyOrMimicMode")] 		public CBool BodyOrMimicMode { get; set;}

		[RED("canUseIdles")] 		public CBool CanUseIdles { get; set;}

		[RED("postIdleAdditiveType")] 		public CEnum<EAdditiveType> PostIdleAdditiveType { get; set;}

		[RED("postAllAdditiveType")] 		public CEnum<EAdditiveType> PostAllAdditiveType { get; set;}

		[RED("fullEyesWeightMimicsTracks", 2,0)] 		public CArray<CName> FullEyesWeightMimicsTracks { get; set;}

		[RED("cachedPostIdleNodeA")] 		public CPtr<CBehaviorGraphNode> CachedPostIdleNodeA { get; set;}

		[RED("cachedPostIdleNodeB")] 		public CPtr<CBehaviorGraphNode> CachedPostIdleNodeB { get; set;}

		[RED("cachedPostAllNodeA")] 		public CPtr<CBehaviorGraphNode> CachedPostAllNodeA { get; set;}

		[RED("cachedPostAllNodeB")] 		public CPtr<CBehaviorGraphNode> CachedPostAllNodeB { get; set;}

		public CBehaviorGraphAnimationMixerSlotNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAnimationMixerSlotNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
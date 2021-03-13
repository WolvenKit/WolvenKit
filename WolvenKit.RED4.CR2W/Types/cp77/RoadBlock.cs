using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoadBlock : InteractiveDevice
	{
		[Ordinal(93)] [RED("openingSpeed")] public CFloat OpeningSpeed { get; set; }
		[Ordinal(94)] [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }
		[Ordinal(95)] [RED("offMeshConnection")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnection { get; set; }
		[Ordinal(96)] [RED("animFeature")] public CHandle<AnimFeature_RoadBlock> AnimFeature { get; set; }
		[Ordinal(97)] [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }
		[Ordinal(98)] [RED("forceEnableLink")] public CBool ForceEnableLink { get; set; }

		public RoadBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

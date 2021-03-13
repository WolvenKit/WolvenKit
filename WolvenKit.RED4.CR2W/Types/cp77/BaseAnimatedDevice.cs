using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseAnimatedDevice : InteractiveDevice
	{
		[Ordinal(93)] [RED("openingSpeed")] public CFloat OpeningSpeed { get; set; }
		[Ordinal(94)] [RED("closingSpeed")] public CFloat ClosingSpeed { get; set; }
		[Ordinal(95)] [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }
		[Ordinal(96)] [RED("animFeature")] public CHandle<AnimFeature_RoadBlock> AnimFeature { get; set; }
		[Ordinal(97)] [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }

		public BaseAnimatedDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

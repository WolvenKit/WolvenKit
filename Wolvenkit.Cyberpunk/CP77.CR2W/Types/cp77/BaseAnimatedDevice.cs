using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseAnimatedDevice : InteractiveDevice
	{
		[Ordinal(0)]  [RED("animFeature")] public CHandle<AnimFeature_RoadBlock> AnimFeature { get; set; }
		[Ordinal(1)]  [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }
		[Ordinal(2)]  [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }
		[Ordinal(3)]  [RED("closingSpeed")] public CFloat ClosingSpeed { get; set; }
		[Ordinal(4)]  [RED("openingSpeed")] public CFloat OpeningSpeed { get; set; }

		public BaseAnimatedDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

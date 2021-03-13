using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsFacingTowardsSource : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)] [RED("applyForPlayer")] public CBool ApplyForPlayer { get; set; }
		[Ordinal(1)] [RED("applyForNPCs")] public CBool ApplyForNPCs { get; set; }
		[Ordinal(2)] [RED("invert")] public CBool Invert { get; set; }
		[Ordinal(3)] [RED("maxAllowedAngleYaw")] public CFloat MaxAllowedAngleYaw { get; set; }
		[Ordinal(4)] [RED("maxAllowedAnglePitch")] public CFloat MaxAllowedAnglePitch { get; set; }

		public IsFacingTowardsSource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

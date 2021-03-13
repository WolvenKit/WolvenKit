using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CycleRoundEvents : WeaponEventsTransition
	{
		[Ordinal(0)] [RED("hasBlockedAiming")] public CBool HasBlockedAiming { get; set; }
		[Ordinal(1)] [RED("blockAimStart")] public CFloat BlockAimStart { get; set; }
		[Ordinal(2)] [RED("blockAimDuration")] public CFloat BlockAimDuration { get; set; }

		public CycleRoundEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CycleRoundEvents : WeaponEventsTransition
	{
		[Ordinal(0)]  [RED("blockAimDuration")] public CFloat BlockAimDuration { get; set; }
		[Ordinal(1)]  [RED("blockAimStart")] public CFloat BlockAimStart { get; set; }
		[Ordinal(2)]  [RED("hasBlockedAiming")] public CBool HasBlockedAiming { get; set; }

		public CycleRoundEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

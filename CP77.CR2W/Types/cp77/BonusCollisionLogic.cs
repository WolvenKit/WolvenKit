using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BonusCollisionLogic : gameuiSideScrollerMiniGameCollisionLogic
	{
		[Ordinal(3)] [RED("hasTriggered")] public CBool HasTriggered { get; set; }

		public BonusCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

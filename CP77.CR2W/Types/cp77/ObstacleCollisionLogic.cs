using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ObstacleCollisionLogic : gameuiSideScrollerMiniGameCollisionLogic
	{
		[Ordinal(3)] [RED("hasTriggered")] public CBool HasTriggered { get; set; }
		[Ordinal(4)] [RED("invincibityBonusTime")] public CFloat InvincibityBonusTime { get; set; }

		public ObstacleCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

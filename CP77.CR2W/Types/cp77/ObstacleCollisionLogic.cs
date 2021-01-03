using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ObstacleCollisionLogic : gameuiSideScrollerMiniGameCollisionLogic
	{
		[Ordinal(0)]  [RED("hasTriggered")] public CBool HasTriggered { get; set; }
		[Ordinal(1)]  [RED("invincibityBonusTime")] public CFloat InvincibityBonusTime { get; set; }

		public ObstacleCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuadRacerBonusCollisionLogic : gameuiSideScrollerMiniGameCollisionLogic
	{
		[Ordinal(0)]  [RED("hasTriggered")] public CBool HasTriggered { get; set; }

		public QuadRacerBonusCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

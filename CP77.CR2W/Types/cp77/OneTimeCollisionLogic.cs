using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OneTimeCollisionLogic : QuadRacerBonusCollisionLogic
	{
		[Ordinal(0)]  [RED("hasTriggered")] public CBool HasTriggered { get; set; }

		public OneTimeCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

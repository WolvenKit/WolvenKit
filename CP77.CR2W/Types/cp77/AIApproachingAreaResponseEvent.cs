using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIApproachingAreaResponseEvent : redEvent
	{
		[Ordinal(0)]  [RED("sender")] public wCHandle<entEntity> Sender { get; set; }
		[Ordinal(1)]  [RED("areaComponent")] public wCHandle<gameStaticAreaShapeComponent> AreaComponent { get; set; }
		[Ordinal(2)]  [RED("isPassingThrough")] public CBool IsPassingThrough { get; set; }

		public AIApproachingAreaResponseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

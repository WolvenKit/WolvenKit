using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIApproachingAreaResponseEvent : redEvent
	{
		[Ordinal(0)]  [RED("areaComponent")] public wCHandle<gameStaticAreaShapeComponent> AreaComponent { get; set; }
		[Ordinal(1)]  [RED("isPassingThrough")] public CBool IsPassingThrough { get; set; }
		[Ordinal(2)]  [RED("sender")] public wCHandle<entEntity> Sender { get; set; }

		public AIApproachingAreaResponseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

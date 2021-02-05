using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiQuestMappinController : gameuiInteractionMappinController
	{
		[Ordinal(0)]  [RED("animPlayerTrackedWidget")] public inkWidgetReference AnimPlayerTrackedWidget { get; set; }
		[Ordinal(1)]  [RED("animPlayerAboveBelowWidget")] public inkWidgetReference AnimPlayerAboveBelowWidget { get; set; }
		[Ordinal(2)]  [RED("taggedWidgets")] public CArray<inkWidgetReference> TaggedWidgets { get; set; }
		[Ordinal(3)]  [RED("nameplateVisible")] public CBool NameplateVisible { get; set; }
		[Ordinal(4)]  [RED("distanceText")] public inkTextWidgetReference DistanceText { get; set; }
		[Ordinal(5)]  [RED("displayName")] public inkTextWidgetReference DisplayName { get; set; }

		public gameuiQuestMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

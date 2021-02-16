using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMappinBaseController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("iconWidget")] public inkImageWidgetReference IconWidget { get; set; }
		[Ordinal(2)] [RED("playerTrackedWidget")] public inkWidgetReference PlayerTrackedWidget { get; set; }
		[Ordinal(3)] [RED("scaleWidget")] public inkWidgetReference ScaleWidget { get; set; }
		[Ordinal(4)] [RED("animPlayerTrackedWidget")] public inkWidgetReference AnimPlayerTrackedWidget { get; set; }
		[Ordinal(5)] [RED("animPlayerAboveBelowWidget")] public inkWidgetReference AnimPlayerAboveBelowWidget { get; set; }
		[Ordinal(6)] [RED("taggedWidgets")] public CArray<inkWidgetReference> TaggedWidgets { get; set; }

		public gameuiMappinBaseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

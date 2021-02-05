using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexEntryViewController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("titleText")] public inkTextWidgetReference TitleText { get; set; }
		[Ordinal(1)]  [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(2)]  [RED("imageWidget")] public inkImageWidgetReference ImageWidget { get; set; }
		[Ordinal(3)]  [RED("imageWidgetFallback")] public inkWidgetReference ImageWidgetFallback { get; set; }
		[Ordinal(4)]  [RED("imageWidgetWrapper")] public inkWidgetReference ImageWidgetWrapper { get; set; }
		[Ordinal(5)]  [RED("scrollWidget")] public inkWidgetReference ScrollWidget { get; set; }
		[Ordinal(6)]  [RED("contentWrapper")] public inkWidgetReference ContentWrapper { get; set; }
		[Ordinal(7)]  [RED("noEntrySelectedWidget")] public inkWidgetReference NoEntrySelectedWidget { get; set; }
		[Ordinal(8)]  [RED("data")] public CHandle<GenericCodexEntryData> Data { get; set; }
		[Ordinal(9)]  [RED("scroll")] public wCHandle<inkScrollController> Scroll { get; set; }

		public CodexEntryViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

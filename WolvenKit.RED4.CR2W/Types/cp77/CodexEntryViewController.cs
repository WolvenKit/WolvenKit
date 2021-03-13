using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexEntryViewController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("titleText")] public inkTextWidgetReference TitleText { get; set; }
		[Ordinal(2)] [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(3)] [RED("imageWidget")] public inkImageWidgetReference ImageWidget { get; set; }
		[Ordinal(4)] [RED("imageWidgetFallback")] public inkWidgetReference ImageWidgetFallback { get; set; }
		[Ordinal(5)] [RED("imageWidgetWrapper")] public inkWidgetReference ImageWidgetWrapper { get; set; }
		[Ordinal(6)] [RED("scrollWidget")] public inkWidgetReference ScrollWidget { get; set; }
		[Ordinal(7)] [RED("contentWrapper")] public inkWidgetReference ContentWrapper { get; set; }
		[Ordinal(8)] [RED("noEntrySelectedWidget")] public inkWidgetReference NoEntrySelectedWidget { get; set; }
		[Ordinal(9)] [RED("data")] public CHandle<GenericCodexEntryData> Data { get; set; }
		[Ordinal(10)] [RED("scroll")] public wCHandle<inkScrollController> Scroll { get; set; }

		public CodexEntryViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HubMenuLabelContentContainer : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("border")] public inkBorderWidgetReference Border { get; set; }
		[Ordinal(1)]  [RED("carouselPosition")] public CInt32 CarouselPosition { get; set; }
		[Ordinal(2)]  [RED("data")] public MenuData Data { get; set; }
		[Ordinal(3)]  [RED("desiredSizeWrapper")] public inkWidgetReference DesiredSizeWrapper { get; set; }
		[Ordinal(4)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(5)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(6)]  [RED("labelName")] public CString LabelName { get; set; }

		public HubMenuLabelContentContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

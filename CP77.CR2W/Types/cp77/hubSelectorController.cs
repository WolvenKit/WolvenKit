using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hubSelectorController : inkSelectorController
	{
		[Ordinal(10)]  [RED("leftArrowWidget")] public inkWidgetReference LeftArrowWidget { get; set; }
		[Ordinal(11)]  [RED("rightArrowWidget")] public inkWidgetReference RightArrowWidget { get; set; }
		[Ordinal(12)]  [RED("menuLabelHolder")] public inkHorizontalPanelWidgetReference MenuLabelHolder { get; set; }
		[Ordinal(13)]  [RED("selectedMenuLabel")] public wCHandle<HubMenuLabelController> SelectedMenuLabel { get; set; }
		[Ordinal(14)]  [RED("previouslySelectedMenuLabel")] public wCHandle<HubMenuLabelController> PreviouslySelectedMenuLabel { get; set; }
		[Ordinal(15)]  [RED("hubElementsData")] public CArray<MenuData> HubElementsData { get; set; }
		[Ordinal(16)]  [RED("previousIndex")] public CInt32 PreviousIndex { get; set; }

		public hubSelectorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

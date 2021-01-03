using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class hubSelectorController : inkSelectorController
	{
		[Ordinal(0)]  [RED("hubElementsData")] public CArray<MenuData> HubElementsData { get; set; }
		[Ordinal(1)]  [RED("leftArrowWidget")] public inkWidgetReference LeftArrowWidget { get; set; }
		[Ordinal(2)]  [RED("menuLabelHolder")] public inkHorizontalPanelWidgetReference MenuLabelHolder { get; set; }
		[Ordinal(3)]  [RED("previousIndex")] public CInt32 PreviousIndex { get; set; }
		[Ordinal(4)]  [RED("previouslySelectedMenuLabel")] public wCHandle<HubMenuLabelController> PreviouslySelectedMenuLabel { get; set; }
		[Ordinal(5)]  [RED("rightArrowWidget")] public inkWidgetReference RightArrowWidget { get; set; }
		[Ordinal(6)]  [RED("selectedMenuLabel")] public wCHandle<HubMenuLabelController> SelectedMenuLabel { get; set; }

		public hubSelectorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CraftingPopupController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("tooltipContainer")] public inkWidgetReference TooltipContainer { get; set; }
		[Ordinal(3)] [RED("craftIcon")] public inkImageWidgetReference CraftIcon { get; set; }
		[Ordinal(4)] [RED("itemName")] public inkTextWidgetReference ItemName { get; set; }
		[Ordinal(5)] [RED("itemTopName")] public inkTextWidgetReference ItemTopName { get; set; }
		[Ordinal(6)] [RED("itemQuality")] public inkTextWidgetReference ItemQuality { get; set; }
		[Ordinal(7)] [RED("headerText")] public inkTextWidgetReference HeaderText { get; set; }
		[Ordinal(8)] [RED("closeButton")] public inkWidgetReference CloseButton { get; set; }
		[Ordinal(9)] [RED("buttonHintsRoot")] public inkWidgetReference ButtonHintsRoot { get; set; }
		[Ordinal(10)] [RED("libraryPath")] public inkWidgetLibraryReference LibraryPath { get; set; }
		[Ordinal(11)] [RED("itemTooltip")] public wCHandle<AGenericTooltipController> ItemTooltip { get; set; }
		[Ordinal(12)] [RED("closeButtonController")] public wCHandle<inkButtonController> CloseButtonController { get; set; }
		[Ordinal(13)] [RED("data")] public CHandle<CraftingPopupData> Data { get; set; }

		public CraftingPopupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

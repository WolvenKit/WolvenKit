using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CraftingPopupController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("buttonHintsRoot")] public inkWidgetReference ButtonHintsRoot { get; set; }
		[Ordinal(1)]  [RED("closeButton")] public inkWidgetReference CloseButton { get; set; }
		[Ordinal(2)]  [RED("closeButtonController")] public wCHandle<inkButtonController> CloseButtonController { get; set; }
		[Ordinal(3)]  [RED("craftIcon")] public inkImageWidgetReference CraftIcon { get; set; }
		[Ordinal(4)]  [RED("data")] public CHandle<CraftingPopupData> Data { get; set; }
		[Ordinal(5)]  [RED("headerText")] public inkTextWidgetReference HeaderText { get; set; }
		[Ordinal(6)]  [RED("itemName")] public inkTextWidgetReference ItemName { get; set; }
		[Ordinal(7)]  [RED("itemQuality")] public inkTextWidgetReference ItemQuality { get; set; }
		[Ordinal(8)]  [RED("itemTooltip")] public wCHandle<AGenericTooltipController> ItemTooltip { get; set; }
		[Ordinal(9)]  [RED("itemTopName")] public inkTextWidgetReference ItemTopName { get; set; }
		[Ordinal(10)]  [RED("libraryPath")] public inkWidgetLibraryReference LibraryPath { get; set; }
		[Ordinal(11)]  [RED("tooltipContainer")] public inkWidgetReference TooltipContainer { get; set; }

		public CraftingPopupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BackpackEquipSlotChooserPopup : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(1)]  [RED("buttonCancel")] public inkWidgetReference ButtonCancel { get; set; }
		[Ordinal(2)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(3)]  [RED("buttonHintsRoot")] public inkWidgetReference ButtonHintsRoot { get; set; }
		[Ordinal(4)]  [RED("buttonOk")] public inkWidgetReference ButtonOk { get; set; }
		[Ordinal(5)]  [RED("closeData")] public CHandle<BackpackEquipSlotChooserCloseData> CloseData { get; set; }
		[Ordinal(6)]  [RED("comparisonResolver")] public CHandle<ItemPreferredComparisonResolver> ComparisonResolver { get; set; }
		[Ordinal(7)]  [RED("data")] public CHandle<BackpackEquipSlotChooserData> Data { get; set; }
		[Ordinal(8)]  [RED("gameData")] public CHandle<gameItemData> GameData { get; set; }
		[Ordinal(9)]  [RED("libraryPath")] public inkWidgetLibraryReference LibraryPath { get; set; }
		[Ordinal(10)]  [RED("rairtyBar")] public inkWidgetReference RairtyBar { get; set; }
		[Ordinal(11)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(12)]  [RED("selectedSlotIndex")] public CInt32 SelectedSlotIndex { get; set; }
		[Ordinal(13)]  [RED("titleText")] public inkTextWidgetReference TitleText { get; set; }
		[Ordinal(14)]  [RED("tooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(15)]  [RED("tooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(16)]  [RED("weaponSlotsContainer")] public inkCompoundWidgetReference WeaponSlotsContainer { get; set; }

		public BackpackEquipSlotChooserPopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

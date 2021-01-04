using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorConfirmationPopup : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(1)]  [RED("buttonCancel")] public inkWidgetReference ButtonCancel { get; set; }
		[Ordinal(2)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(3)]  [RED("buttonHintsRoot")] public inkWidgetReference ButtonHintsRoot { get; set; }
		[Ordinal(4)]  [RED("buttonOk")] public inkWidgetReference ButtonOk { get; set; }
		[Ordinal(5)]  [RED("closeData")] public CHandle<VendorConfirmationPopupCloseData> CloseData { get; set; }
		[Ordinal(6)]  [RED("data")] public CHandle<VendorConfirmationPopupData> Data { get; set; }
		[Ordinal(7)]  [RED("eqippedItemContainer")] public inkWidgetReference EqippedItemContainer { get; set; }
		[Ordinal(8)]  [RED("gameData")] public CHandle<gameItemData> GameData { get; set; }
		[Ordinal(9)]  [RED("itemDisplayController")] public CHandle<InventoryItemDisplayController> ItemDisplayController { get; set; }
		[Ordinal(10)]  [RED("itemDisplayRef")] public inkWidgetReference ItemDisplayRef { get; set; }
		[Ordinal(11)]  [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(12)]  [RED("itemPriceContainer")] public inkWidgetReference ItemPriceContainer { get; set; }
		[Ordinal(13)]  [RED("itemPriceText")] public inkTextWidgetReference ItemPriceText { get; set; }
		[Ordinal(14)]  [RED("libraryPath")] public inkWidgetLibraryReference LibraryPath { get; set; }
		[Ordinal(15)]  [RED("rairtyBar")] public inkWidgetReference RairtyBar { get; set; }
		[Ordinal(16)]  [RED("root")] public inkWidgetReference Root { get; set; }

		public VendorConfirmationPopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

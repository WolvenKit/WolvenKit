using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemQuantityPickerController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("actionType")] public CEnum<QuantityPickerActionType> ActionType { get; set; }
		[Ordinal(1)]  [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(2)]  [RED("buttonCancel")] public inkWidgetReference ButtonCancel { get; set; }
		[Ordinal(3)]  [RED("buttonHintsRoot")] public inkWidgetReference ButtonHintsRoot { get; set; }
		[Ordinal(4)]  [RED("buttonLess")] public inkWidgetReference ButtonLess { get; set; }
		[Ordinal(5)]  [RED("buttonMore")] public inkWidgetReference ButtonMore { get; set; }
		[Ordinal(6)]  [RED("buttonOk")] public inkWidgetReference ButtonOk { get; set; }
		[Ordinal(7)]  [RED("buttonOkText")] public inkTextWidgetReference ButtonOkText { get; set; }
		[Ordinal(8)]  [RED("choosenQuantity")] public CInt32 ChoosenQuantity { get; set; }
		[Ordinal(9)]  [RED("closeData")] public CHandle<QuantityPickerPopupCloseData> CloseData { get; set; }
		[Ordinal(10)]  [RED("data")] public CHandle<QuantityPickerPopupData> Data { get; set; }
		[Ordinal(11)]  [RED("gameData")] public InventoryItemData GameData { get; set; }
		[Ordinal(12)]  [RED("isBuyback")] public CBool IsBuyback { get; set; }
		[Ordinal(13)]  [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(14)]  [RED("itemPrice")] public CInt32 ItemPrice { get; set; }
		[Ordinal(15)]  [RED("itemQuantityText")] public inkTextWidgetReference ItemQuantityText { get; set; }
		[Ordinal(16)]  [RED("itemWeight")] public CFloat ItemWeight { get; set; }
		[Ordinal(17)]  [RED("libraryPath")] public inkWidgetLibraryReference LibraryPath { get; set; }
		[Ordinal(18)]  [RED("maxValue")] public CInt32 MaxValue { get; set; }
		[Ordinal(19)]  [RED("priceText")] public inkTextWidgetReference PriceText { get; set; }
		[Ordinal(20)]  [RED("priceWrapper")] public inkWidgetReference PriceWrapper { get; set; }
		[Ordinal(21)]  [RED("quantityTextChoosen")] public inkTextWidgetReference QuantityTextChoosen { get; set; }
		[Ordinal(22)]  [RED("quantityTextMax")] public inkTextWidgetReference QuantityTextMax { get; set; }
		[Ordinal(23)]  [RED("quantityTextMin")] public inkTextWidgetReference QuantityTextMin { get; set; }
		[Ordinal(24)]  [RED("rairtyBar")] public inkWidgetReference RairtyBar { get; set; }
		[Ordinal(25)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(26)]  [RED("slider")] public inkWidgetReference Slider { get; set; }
		[Ordinal(27)]  [RED("sliderController")] public CHandle<inkSliderController> SliderController { get; set; }
		[Ordinal(28)]  [RED("weightText")] public inkTextWidgetReference WeightText { get; set; }

		public ItemQuantityPickerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

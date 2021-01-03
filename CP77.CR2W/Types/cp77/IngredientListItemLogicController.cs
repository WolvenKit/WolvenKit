using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IngredientListItemLogicController : inkButtonController
	{
		[Ordinal(0)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(1)]  [RED("availability")] public inkTextWidgetReference Availability { get; set; }
		[Ordinal(2)]  [RED("availableBgElements")] public CArray<inkWidgetReference> AvailableBgElements { get; set; }
		[Ordinal(3)]  [RED("buyButton")] public inkWidgetReference BuyButton { get; set; }
		[Ordinal(4)]  [RED("countWrapper")] public inkWidgetReference CountWrapper { get; set; }
		[Ordinal(5)]  [RED("data")] public IngredientData Data { get; set; }
		[Ordinal(6)]  [RED("emptyIcon")] public inkImageWidgetReference EmptyIcon { get; set; }
		[Ordinal(7)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(8)]  [RED("ingredientQuantity")] public inkTextWidgetReference IngredientQuantity { get; set; }
		[Ordinal(9)]  [RED("inventoryQuantity")] public inkTextWidgetReference InventoryQuantity { get; set; }
		[Ordinal(10)]  [RED("itemName")] public inkTextWidgetReference ItemName { get; set; }
		[Ordinal(11)]  [RED("itemRarity")] public inkWidgetReference ItemRarity { get; set; }
		[Ordinal(12)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(13)]  [RED("unavailableBgElements")] public CArray<inkWidgetReference> UnavailableBgElements { get; set; }

		public IngredientListItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

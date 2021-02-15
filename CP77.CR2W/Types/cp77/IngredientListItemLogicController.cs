using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IngredientListItemLogicController : inkButtonController
	{
		[Ordinal(10)] [RED("itemName")] public inkTextWidgetReference ItemName { get; set; }
		[Ordinal(11)] [RED("inventoryQuantity")] public inkTextWidgetReference InventoryQuantity { get; set; }
		[Ordinal(12)] [RED("ingredientQuantity")] public inkTextWidgetReference IngredientQuantity { get; set; }
		[Ordinal(13)] [RED("availability")] public inkTextWidgetReference Availability { get; set; }
		[Ordinal(14)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(15)] [RED("emptyIcon")] public inkImageWidgetReference EmptyIcon { get; set; }
		[Ordinal(16)] [RED("availableBgElements")] public CArray<inkWidgetReference> AvailableBgElements { get; set; }
		[Ordinal(17)] [RED("unavailableBgElements")] public CArray<inkWidgetReference> UnavailableBgElements { get; set; }
		[Ordinal(18)] [RED("buyButton")] public inkWidgetReference BuyButton { get; set; }
		[Ordinal(19)] [RED("countWrapper")] public inkWidgetReference CountWrapper { get; set; }
		[Ordinal(20)] [RED("itemRarity")] public inkWidgetReference ItemRarity { get; set; }
		[Ordinal(21)] [RED("data")] public IngredientData Data { get; set; }
		[Ordinal(22)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(23)] [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }

		public IngredientListItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

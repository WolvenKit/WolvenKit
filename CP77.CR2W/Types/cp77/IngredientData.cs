using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IngredientData : CVariable
	{
		[Ordinal(0)]  [RED("baseQuantity")] public CInt32 BaseQuantity { get; set; }
		[Ordinal(1)]  [RED("buyableIngredient")] public CBool BuyableIngredient { get; set; }
		[Ordinal(2)]  [RED("hasEnoughQuantity")] public CBool HasEnoughQuantity { get; set; }
		[Ordinal(3)]  [RED("icon")] public CString Icon { get; set; }
		[Ordinal(4)]  [RED("iconGender")] public CEnum<gameItemIconGender> IconGender { get; set; }
		[Ordinal(5)]  [RED("id")] public CHandle<gamedataItem_Record> Id { get; set; }
		[Ordinal(6)]  [RED("inventoryQuantity")] public CInt32 InventoryQuantity { get; set; }
		[Ordinal(7)]  [RED("label")] public CString Label { get; set; }
		[Ordinal(8)]  [RED("playerSelectableIngredient")] public CBool PlayerSelectableIngredient { get; set; }
		[Ordinal(9)]  [RED("quantity")] public CInt32 Quantity { get; set; }

		public IngredientData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

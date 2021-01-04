using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RecipeData : IScriptable
	{
		[Ordinal(0)]  [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(1)]  [RED("description")] public CString Description { get; set; }
		[Ordinal(2)]  [RED("gameItemData")] public CHandle<gameItemData> GameItemData { get; set; }
		[Ordinal(3)]  [RED("icon")] public CString Icon { get; set; }
		[Ordinal(4)]  [RED("iconGender")] public CEnum<gameItemIconGender> IconGender { get; set; }
		[Ordinal(5)]  [RED("id")] public CHandle<gamedataItem_Record> Id { get; set; }
		[Ordinal(6)]  [RED("ingredients")] public CArray<IngredientData> Ingredients { get; set; }
		[Ordinal(7)]  [RED("inventoryItem")] public InventoryItemData InventoryItem { get; set; }
		[Ordinal(8)]  [RED("isCraftable")] public CBool IsCraftable { get; set; }
		[Ordinal(9)]  [RED("label")] public CString Label { get; set; }
		[Ordinal(10)]  [RED("type")] public CString Type { get; set; }

		public RecipeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

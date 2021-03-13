using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCraftingData : IScriptable
	{
		[Ordinal(0)] [RED("inventoryItem")] public InventoryItemData InventoryItem { get; set; }
		[Ordinal(1)] [RED("isCraftable")] public CBool IsCraftable { get; set; }

		public ItemCraftingData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

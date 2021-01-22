using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CraftingSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("callback")] public CHandle<CraftingSystemInventoryCallback> Callback { get; set; }
		[Ordinal(1)]  [RED("inventoryListener")] public CHandle<gameInventoryScriptListener> InventoryListener { get; set; }
		[Ordinal(2)]  [RED("itemIconGender")] public CEnum<gameItemIconGender> ItemIconGender { get; set; }
		[Ordinal(3)]  [RED("lastActionStatus")] public CBool LastActionStatus { get; set; }
		[Ordinal(4)]  [RED("playerCraftBook")] public CHandle<CraftBook> PlayerCraftBook { get; set; }

		public CraftingSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

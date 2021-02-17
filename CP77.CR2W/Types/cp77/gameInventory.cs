using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameInventory : gameComponent
	{
		[Ordinal(4)] [RED("saveInventory")] public CBool SaveInventory { get; set; }
		[Ordinal(5)] [RED("inventoryTag")] public CEnum<gameSharedInventoryTag> InventoryTag { get; set; }
		[Ordinal(6)] [RED("noInitialization")] public CBool NoInitialization { get; set; }

		public gameInventory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

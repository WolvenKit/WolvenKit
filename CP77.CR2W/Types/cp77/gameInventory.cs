using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameInventory : gameComponent
	{
		[Ordinal(0)]  [RED("saveInventory")] public CBool SaveInventory { get; set; }
		[Ordinal(1)]  [RED("inventoryTag")] public CEnum<gameSharedInventoryTag> InventoryTag { get; set; }
		[Ordinal(2)]  [RED("noInitialization")] public CBool NoInitialization { get; set; }

		public gameInventory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

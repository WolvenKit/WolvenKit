using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SlotUserData : IScriptable
	{
		[Ordinal(0)]  [RED("area")] public CEnum<gamedataEquipmentArea> Area { get; set; }
		[Ordinal(1)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(2)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }

		public SlotUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

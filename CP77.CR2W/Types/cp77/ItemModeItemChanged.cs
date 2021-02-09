using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemModeItemChanged : redEvent
	{
		[Ordinal(0)]  [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(1)]  [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(2)]  [RED("hotkey")] public CEnum<gameEHotkey> Hotkey { get; set; }

		public ItemModeItemChanged(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

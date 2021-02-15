using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayClickEvent : redEvent
	{
		[Ordinal(0)] [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(1)] [RED("actionName")] public CHandle<inkActionName> ActionName { get; set; }
		[Ordinal(2)] [RED("displayContext")] public CEnum<gameItemDisplayContext> DisplayContext { get; set; }
		[Ordinal(3)] [RED("isBuybackStack")] public CBool IsBuybackStack { get; set; }
		[Ordinal(4)] [RED("evt")] public CHandle<inkPointerEvent> Evt { get; set; }

		public ItemDisplayClickEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

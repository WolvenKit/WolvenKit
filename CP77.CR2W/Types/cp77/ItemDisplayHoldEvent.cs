using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayHoldEvent : redEvent
	{
		[Ordinal(0)]  [RED("actionName")] public CHandle<inkActionName> ActionName { get; set; }
		[Ordinal(1)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }

		public ItemDisplayHoldEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

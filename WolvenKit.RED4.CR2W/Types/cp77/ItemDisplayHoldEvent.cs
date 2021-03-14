using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayHoldEvent : redEvent
	{
		[Ordinal(0)] [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(1)] [RED("actionName")] public CHandle<inkActionName> ActionName { get; set; }

		public ItemDisplayHoldEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

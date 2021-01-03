using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EventInventorySlotSelectDelayedInventoryEvent : redEvent
	{
		[Ordinal(0)]  [RED("controller")] public InventoryItemData Controller { get; set; }
		[Ordinal(1)]  [RED("target")] public wCHandle<inkWidget> Target { get; set; }

		public EventInventorySlotSelectDelayedInventoryEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

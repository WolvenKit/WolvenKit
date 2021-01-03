using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CyberwareItemLogicController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("slot")] public wCHandle<InventoryItemDisplayController> Slot { get; set; }
		[Ordinal(1)]  [RED("slotRoot")] public inkCompoundWidgetReference SlotRoot { get; set; }

		public CyberwareItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareItemLogicController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] [RED("slotRoot")] public inkCompoundWidgetReference SlotRoot { get; set; }
		[Ordinal(16)] [RED("slot")] public wCHandle<InventoryItemDisplayController> Slot { get; set; }

		public CyberwareItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

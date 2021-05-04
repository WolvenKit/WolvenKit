using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareItemLogicController : inkVirtualCompoundItemController
	{
		private inkCompoundWidgetReference _slotRoot;
		private wCHandle<InventoryItemDisplayController> _slot;

		[Ordinal(15)] 
		[RED("slotRoot")] 
		public inkCompoundWidgetReference SlotRoot
		{
			get => GetProperty(ref _slotRoot);
			set => SetProperty(ref _slotRoot, value);
		}

		[Ordinal(16)] 
		[RED("slot")] 
		public wCHandle<InventoryItemDisplayController> Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}

		public CyberwareItemLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

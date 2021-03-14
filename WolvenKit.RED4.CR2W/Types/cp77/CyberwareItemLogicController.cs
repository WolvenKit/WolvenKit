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
			get
			{
				if (_slotRoot == null)
				{
					_slotRoot = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "slotRoot", cr2w, this);
				}
				return _slotRoot;
			}
			set
			{
				if (_slotRoot == value)
				{
					return;
				}
				_slotRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("slot")] 
		public wCHandle<InventoryItemDisplayController> Slot
		{
			get
			{
				if (_slot == null)
				{
					_slot = (wCHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("whandle:InventoryItemDisplayController", "slot", cr2w, this);
				}
				return _slot;
			}
			set
			{
				if (_slot == value)
				{
					return;
				}
				_slot = value;
				PropertySet(this);
			}
		}

		public CyberwareItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

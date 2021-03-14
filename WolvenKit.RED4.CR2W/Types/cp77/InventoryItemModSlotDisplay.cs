using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemModSlotDisplay : inkWidgetLogicController
	{
		private inkWidgetReference _slotBorder;
		private inkWidgetReference _slotBackground;

		[Ordinal(1)] 
		[RED("slotBorder")] 
		public inkWidgetReference SlotBorder
		{
			get
			{
				if (_slotBorder == null)
				{
					_slotBorder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "slotBorder", cr2w, this);
				}
				return _slotBorder;
			}
			set
			{
				if (_slotBorder == value)
				{
					return;
				}
				_slotBorder = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slotBackground")] 
		public inkWidgetReference SlotBackground
		{
			get
			{
				if (_slotBackground == null)
				{
					_slotBackground = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "slotBackground", cr2w, this);
				}
				return _slotBackground;
			}
			set
			{
				if (_slotBackground == value)
				{
					return;
				}
				_slotBackground = value;
				PropertySet(this);
			}
		}

		public InventoryItemModSlotDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

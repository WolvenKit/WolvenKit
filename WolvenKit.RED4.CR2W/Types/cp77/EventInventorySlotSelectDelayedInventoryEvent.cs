using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EventInventorySlotSelectDelayedInventoryEvent : redEvent
	{
		private InventoryItemData _controller;
		private wCHandle<inkWidget> _target;

		[Ordinal(0)] 
		[RED("controller")] 
		public InventoryItemData Controller
		{
			get
			{
				if (_controller == null)
				{
					_controller = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "controller", cr2w, this);
				}
				return _controller;
			}
			set
			{
				if (_controller == value)
				{
					return;
				}
				_controller = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<inkWidget> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		public EventInventorySlotSelectDelayedInventoryEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

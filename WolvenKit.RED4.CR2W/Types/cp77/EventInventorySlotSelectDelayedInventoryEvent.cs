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
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<inkWidget> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		public EventInventorySlotSelectDelayedInventoryEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

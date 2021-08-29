using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EventInventorySlotSelectDelayedInventoryEvent : redEvent
	{
		private InventoryItemData _controller;
		private CWeakHandle<inkWidget> _target;

		[Ordinal(0)] 
		[RED("controller")] 
		public InventoryItemData Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CWeakHandle<inkWidget> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}
	}
}

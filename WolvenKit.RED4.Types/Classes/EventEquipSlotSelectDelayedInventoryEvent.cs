using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EventEquipSlotSelectDelayedInventoryEvent : redEvent
	{
		private CWeakHandle<InventoryItemDisplayController> _controller;

		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<InventoryItemDisplayController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}
	}
}

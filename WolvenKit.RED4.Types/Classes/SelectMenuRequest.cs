using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SelectMenuRequest : redEvent
	{
		private CWeakHandle<MenuItemController> _eventData;

		[Ordinal(0)] 
		[RED("eventData")] 
		public CWeakHandle<MenuItemController> EventData
		{
			get => GetProperty(ref _eventData);
			set => SetProperty(ref _eventData, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MessengerContactsVirtualNestedListController : VirtualNestedListController
	{
		private CWeakHandle<MessengerContactDataView> _currentDataView;

		[Ordinal(14)] 
		[RED("currentDataView")] 
		public CWeakHandle<MessengerContactDataView> CurrentDataView
		{
			get => GetProperty(ref _currentDataView);
			set => SetProperty(ref _currentDataView, value);
		}
	}
}

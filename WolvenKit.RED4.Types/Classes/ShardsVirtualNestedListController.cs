using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardsVirtualNestedListController : VirtualNestedListController
	{
		private CWeakHandle<ShardsNestedListDataView> _currentDataView;

		[Ordinal(14)] 
		[RED("currentDataView")] 
		public CWeakHandle<ShardsNestedListDataView> CurrentDataView
		{
			get => GetProperty(ref _currentDataView);
			set => SetProperty(ref _currentDataView, value);
		}
	}
}

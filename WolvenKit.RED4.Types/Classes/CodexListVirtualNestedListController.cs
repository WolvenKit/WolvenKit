using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexListVirtualNestedListController : VirtualNestedListController
	{
		private CWeakHandle<CodexListVirtualNestedDataView> _currentDataView;

		[Ordinal(14)] 
		[RED("currentDataView")] 
		public CWeakHandle<CodexListVirtualNestedDataView> CurrentDataView
		{
			get => GetProperty(ref _currentDataView);
			set => SetProperty(ref _currentDataView, value);
		}
	}
}

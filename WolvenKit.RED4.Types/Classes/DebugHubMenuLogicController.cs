using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DebugHubMenuLogicController : inkWidgetLogicController
	{
		private CWeakHandle<inkWidget> _selectorWidget;
		private CWeakHandle<hubSelectorController> _selectorCtrl;
		private CArray<CName> _menusList;
		private CArray<CName> _eventsList;
		private CName _defailtMenuName;

		[Ordinal(1)] 
		[RED("selectorWidget")] 
		public CWeakHandle<inkWidget> SelectorWidget
		{
			get => GetProperty(ref _selectorWidget);
			set => SetProperty(ref _selectorWidget, value);
		}

		[Ordinal(2)] 
		[RED("selectorCtrl")] 
		public CWeakHandle<hubSelectorController> SelectorCtrl
		{
			get => GetProperty(ref _selectorCtrl);
			set => SetProperty(ref _selectorCtrl, value);
		}

		[Ordinal(3)] 
		[RED("menusList")] 
		public CArray<CName> MenusList
		{
			get => GetProperty(ref _menusList);
			set => SetProperty(ref _menusList, value);
		}

		[Ordinal(4)] 
		[RED("eventsList")] 
		public CArray<CName> EventsList
		{
			get => GetProperty(ref _eventsList);
			set => SetProperty(ref _eventsList, value);
		}

		[Ordinal(5)] 
		[RED("defailtMenuName")] 
		public CName DefailtMenuName
		{
			get => GetProperty(ref _defailtMenuName);
			set => SetProperty(ref _defailtMenuName, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DebugHubMenuLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("selectorWidget")] 
		public CWeakHandle<inkWidget> SelectorWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("selectorCtrl")] 
		public CWeakHandle<hubSelectorController> SelectorCtrl
		{
			get => GetPropertyValue<CWeakHandle<hubSelectorController>>();
			set => SetPropertyValue<CWeakHandle<hubSelectorController>>(value);
		}

		[Ordinal(3)] 
		[RED("menusList")] 
		public CArray<CName> MenusList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("eventsList")] 
		public CArray<CName> EventsList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("defailtMenuName")] 
		public CName DefailtMenuName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public DebugHubMenuLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class buffListGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("buffsList")] 
		public inkHorizontalPanelWidgetReference BuffsList
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("bbBuffList")] 
		public CHandle<redCallbackObject> BbBuffList
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("bbDeBuffList")] 
		public CHandle<redCallbackObject> BbDeBuffList
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("uiBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(13)] 
		[RED("buffDataList")] 
		public CArray<gameuiBuffInfo> BuffDataList
		{
			get => GetPropertyValue<CArray<gameuiBuffInfo>>();
			set => SetPropertyValue<CArray<gameuiBuffInfo>>(value);
		}

		[Ordinal(14)] 
		[RED("debuffDataList")] 
		public CArray<gameuiBuffInfo> DebuffDataList
		{
			get => GetPropertyValue<CArray<gameuiBuffInfo>>();
			set => SetPropertyValue<CArray<gameuiBuffInfo>>(value);
		}

		[Ordinal(15)] 
		[RED("buffWidgets")] 
		public CArray<CWeakHandle<inkWidget>> BuffWidgets
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(16)] 
		[RED("UISystem")] 
		public CWeakHandle<gameuiGameSystemUI> UISystem
		{
			get => GetPropertyValue<CWeakHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CWeakHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(17)] 
		[RED("pendingRequests")] 
		public CInt32 PendingRequests
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public buffListGameController()
		{
			BuffsList = new inkHorizontalPanelWidgetReference();
			BuffDataList = new();
			DebuffDataList = new();
			BuffWidgets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

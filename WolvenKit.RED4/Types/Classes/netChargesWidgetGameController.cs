using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class netChargesWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("bbPlayerStats")] 
		public CWeakHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(10)] 
		[RED("bbPlayerEventId1")] 
		public CHandle<redCallbackObject> BbPlayerEventId1
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("bbPlayerEventId2")] 
		public CHandle<redCallbackObject> BbPlayerEventId2
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("bbPlayerEventId3")] 
		public CHandle<redCallbackObject> BbPlayerEventId3
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("networkName")] 
		public CWeakHandle<inkTextWidget> NetworkName
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(14)] 
		[RED("networkStatus")] 
		public CWeakHandle<inkTextWidget> NetworkStatus
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("chargesList")] 
		public CArray<CWeakHandle<inkCompoundWidget>> ChargesList
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkCompoundWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkCompoundWidget>>>(value);
		}

		[Ordinal(16)] 
		[RED("chargesCurrent")] 
		public CInt32 ChargesCurrent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("chargesMax")] 
		public CInt32 ChargesMax
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("networkNameText")] 
		public CString NetworkNameText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(19)] 
		[RED("networkStatusText")] 
		public CString NetworkStatusText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(20)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("chargeList")] 
		public CWeakHandle<inkHorizontalPanelWidget> ChargeList
		{
			get => GetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>(value);
		}

		public netChargesWidgetGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

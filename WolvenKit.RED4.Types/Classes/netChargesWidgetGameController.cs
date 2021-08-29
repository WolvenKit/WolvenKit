using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netChargesWidgetGameController : gameuiHUDGameController
	{
		private CWeakHandle<gameIBlackboard> _bbPlayerStats;
		private CHandle<redCallbackObject> _bbPlayerEventId1;
		private CHandle<redCallbackObject> _bbPlayerEventId2;
		private CHandle<redCallbackObject> _bbPlayerEventId3;
		private CWeakHandle<inkTextWidget> _networkName;
		private CWeakHandle<inkTextWidget> _networkStatus;
		private CArray<CWeakHandle<inkCompoundWidget>> _chargesList;
		private CInt32 _chargesCurrent;
		private CInt32 _chargesMax;
		private CString _networkNameText;
		private CString _networkStatusText;
		private CWeakHandle<inkWidget> _rootWidget;
		private CWeakHandle<inkHorizontalPanelWidget> _chargeList;

		[Ordinal(9)] 
		[RED("bbPlayerStats")] 
		public CWeakHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetProperty(ref _bbPlayerStats);
			set => SetProperty(ref _bbPlayerStats, value);
		}

		[Ordinal(10)] 
		[RED("bbPlayerEventId1")] 
		public CHandle<redCallbackObject> BbPlayerEventId1
		{
			get => GetProperty(ref _bbPlayerEventId1);
			set => SetProperty(ref _bbPlayerEventId1, value);
		}

		[Ordinal(11)] 
		[RED("bbPlayerEventId2")] 
		public CHandle<redCallbackObject> BbPlayerEventId2
		{
			get => GetProperty(ref _bbPlayerEventId2);
			set => SetProperty(ref _bbPlayerEventId2, value);
		}

		[Ordinal(12)] 
		[RED("bbPlayerEventId3")] 
		public CHandle<redCallbackObject> BbPlayerEventId3
		{
			get => GetProperty(ref _bbPlayerEventId3);
			set => SetProperty(ref _bbPlayerEventId3, value);
		}

		[Ordinal(13)] 
		[RED("networkName")] 
		public CWeakHandle<inkTextWidget> NetworkName
		{
			get => GetProperty(ref _networkName);
			set => SetProperty(ref _networkName, value);
		}

		[Ordinal(14)] 
		[RED("networkStatus")] 
		public CWeakHandle<inkTextWidget> NetworkStatus
		{
			get => GetProperty(ref _networkStatus);
			set => SetProperty(ref _networkStatus, value);
		}

		[Ordinal(15)] 
		[RED("chargesList")] 
		public CArray<CWeakHandle<inkCompoundWidget>> ChargesList
		{
			get => GetProperty(ref _chargesList);
			set => SetProperty(ref _chargesList, value);
		}

		[Ordinal(16)] 
		[RED("chargesCurrent")] 
		public CInt32 ChargesCurrent
		{
			get => GetProperty(ref _chargesCurrent);
			set => SetProperty(ref _chargesCurrent, value);
		}

		[Ordinal(17)] 
		[RED("chargesMax")] 
		public CInt32 ChargesMax
		{
			get => GetProperty(ref _chargesMax);
			set => SetProperty(ref _chargesMax, value);
		}

		[Ordinal(18)] 
		[RED("networkNameText")] 
		public CString NetworkNameText
		{
			get => GetProperty(ref _networkNameText);
			set => SetProperty(ref _networkNameText, value);
		}

		[Ordinal(19)] 
		[RED("networkStatusText")] 
		public CString NetworkStatusText
		{
			get => GetProperty(ref _networkStatusText);
			set => SetProperty(ref _networkStatusText, value);
		}

		[Ordinal(20)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(21)] 
		[RED("chargeList")] 
		public CWeakHandle<inkHorizontalPanelWidget> ChargeList
		{
			get => GetProperty(ref _chargeList);
			set => SetProperty(ref _chargeList, value);
		}
	}
}

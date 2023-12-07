using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scannerDetailsGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("scannerCountainer")] 
		public inkCompoundWidgetReference ScannerCountainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("quickhackContainer")] 
		public inkCompoundWidgetReference QuickhackContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("cluesContainer")] 
		public inkCompoundWidgetReference CluesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("toggleDescirptionHackPart")] 
		public inkWidgetReference ToggleDescirptionHackPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("kiroshiLogo")] 
		public inkWidgetReference KiroshiLogo
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(15)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get => GetPropertyValue<CEnum<gameScanningState>>();
			set => SetPropertyValue<CEnum<gameScanningState>>(value);
		}

		[Ordinal(16)] 
		[RED("scannedObjectType")] 
		public CEnum<ScannerObjectType> ScannedObjectType
		{
			get => GetPropertyValue<CEnum<ScannerObjectType>>();
			set => SetPropertyValue<CEnum<ScannerObjectType>>(value);
		}

		[Ordinal(17)] 
		[RED("currentTab")] 
		public CEnum<ScannerDetailTab> CurrentTab
		{
			get => GetPropertyValue<CEnum<ScannerDetailTab>>();
			set => SetPropertyValue<CEnum<ScannerDetailTab>>(value);
		}

		[Ordinal(18)] 
		[RED("isQuickHackAble")] 
		public CBool IsQuickHackAble
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("isQuickHackPanelOpened")] 
		public CBool IsQuickHackPanelOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("asyncSpawnRequests")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> AsyncSpawnRequests
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		[Ordinal(21)] 
		[RED("uiScannedObjectTypeChangedCallbackID")] 
		public CHandle<redCallbackObject> UiScannedObjectTypeChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(22)] 
		[RED("uiScanningStateChangedCallbackID")] 
		public CHandle<redCallbackObject> UiScanningStateChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(23)] 
		[RED("uiScannedObjectChangedCallbackID")] 
		public CHandle<redCallbackObject> UiScannedObjectChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("uiQHDescriptionChangedCallbackID")] 
		public CHandle<redCallbackObject> UiQHDescriptionChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("uiQHPanelOpenedCallbackID")] 
		public CHandle<redCallbackObject> UiQHPanelOpenedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(26)] 
		[RED("uiSystemIsInMenuCallbackID")] 
		public CHandle<redCallbackObject> UiSystemIsInMenuCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(28)] 
		[RED("outroAnimProxy")] 
		public CHandle<inkanimProxy> OutroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(29)] 
		[RED("scannerToggleTabAnimProxy")] 
		public CHandle<inkanimProxy> ScannerToggleTabAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public scannerDetailsGameController()
		{
			ScannerCountainer = new inkCompoundWidgetReference();
			QuickhackContainer = new inkCompoundWidgetReference();
			CluesContainer = new inkCompoundWidgetReference();
			ToggleDescirptionHackPart = new inkWidgetReference();
			KiroshiLogo = new inkWidgetReference();
			AsyncSpawnRequests = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

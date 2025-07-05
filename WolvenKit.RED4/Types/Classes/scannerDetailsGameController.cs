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
		[RED("cluesContainer")] 
		public inkCompoundWidgetReference CluesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("quickhackContainer")] 
		public inkCompoundWidgetReference QuickhackContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("twintoneContainer")] 
		public inkCompoundWidgetReference TwintoneContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("toggleDescirptionHackPart")] 
		public inkWidgetReference ToggleDescirptionHackPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("toggleDescriptionTwintonePart")] 
		public inkWidgetReference ToggleDescriptionTwintonePart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("kiroshiLogo")] 
		public inkWidgetReference KiroshiLogo
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("bottomFluff")] 
		public inkWidgetReference BottomFluff
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("twintoneNoModelAvailable")] 
		public inkWidgetReference TwintoneNoModelAvailable
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("twintoneSaveButtonHints")] 
		public inkWidgetReference TwintoneSaveButtonHints
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("twintoneApplyButtonHints")] 
		public inkWidgetReference TwintoneApplyButtonHints
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("changeTabButtonHints")] 
		public inkWidgetReference ChangeTabButtonHints
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("changeTabInlineHint")] 
		public inkWidgetReference ChangeTabInlineHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("spaceTab01")] 
		public inkWidgetReference SpaceTab01
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("spaceTab02")] 
		public inkWidgetReference SpaceTab02
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("twotabs01BottomLine")] 
		public inkWidgetReference Twotabs01BottomLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("twotabs02BottomLine")] 
		public inkWidgetReference Twotabs02BottomLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("threetabs01BottomLine")] 
		public inkWidgetReference Threetabs01BottomLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("threetabs02BottomLine")] 
		public inkWidgetReference Threetabs02BottomLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("threetabs03BottomLine")] 
		public inkWidgetReference Threetabs03BottomLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("lastOpenTab")] 
		public CEnum<ScannerDetailTab> LastOpenTab
		{
			get => GetPropertyValue<CEnum<ScannerDetailTab>>();
			set => SetPropertyValue<CEnum<ScannerDetailTab>>(value);
		}

		[Ordinal(30)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(31)] 
		[RED("scannedObject")] 
		public CWeakHandle<gameObject> ScannedObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(32)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get => GetPropertyValue<CEnum<gameScanningState>>();
			set => SetPropertyValue<CEnum<gameScanningState>>(value);
		}

		[Ordinal(33)] 
		[RED("scannedObjectType")] 
		public CEnum<ScannerObjectType> ScannedObjectType
		{
			get => GetPropertyValue<CEnum<ScannerObjectType>>();
			set => SetPropertyValue<CEnum<ScannerObjectType>>(value);
		}

		[Ordinal(34)] 
		[RED("currentTab")] 
		public CEnum<ScannerDetailTab> CurrentTab
		{
			get => GetPropertyValue<CEnum<ScannerDetailTab>>();
			set => SetPropertyValue<CEnum<ScannerDetailTab>>(value);
		}

		[Ordinal(35)] 
		[RED("isQuickHackAble")] 
		public CBool IsQuickHackAble
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("isQuickHackPanelOpenedOrBlocked")] 
		public CBool IsQuickHackPanelOpenedOrBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("isQuickHackPanelOpened")] 
		public CBool IsQuickHackPanelOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("isQuickHackPanelBlocked")] 
		public CBool IsQuickHackPanelBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("twintoneAvailable")] 
		public CBool TwintoneAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("twintoneApplyAvailable")] 
		public CBool TwintoneApplyAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("twintoneNoModelApplicable")] 
		public CBool TwintoneNoModelApplicable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("asyncSpawnRequests")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> AsyncSpawnRequests
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		[Ordinal(43)] 
		[RED("uiScannedObjectTypeChangedCallbackID")] 
		public CHandle<redCallbackObject> UiScannedObjectTypeChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(44)] 
		[RED("uiScanningStateChangedCallbackID")] 
		public CHandle<redCallbackObject> UiScanningStateChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(45)] 
		[RED("uiScannedObjectChangedCallbackID")] 
		public CHandle<redCallbackObject> UiScannedObjectChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(46)] 
		[RED("twintoneAvailableCallbackID")] 
		public CHandle<redCallbackObject> TwintoneAvailableCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(47)] 
		[RED("twintoneApplyAvailableCallbackID")] 
		public CHandle<redCallbackObject> TwintoneApplyAvailableCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(48)] 
		[RED("twintoneNoModelAvailableCallbackID")] 
		public CHandle<redCallbackObject> TwintoneNoModelAvailableCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(49)] 
		[RED("uiQHPanelOpenedCallbackID")] 
		public CHandle<redCallbackObject> UiQHPanelOpenedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(50)] 
		[RED("uiQHPanelBlockedCallbackID")] 
		public CHandle<redCallbackObject> UiQHPanelBlockedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(51)] 
		[RED("uiSystemIsInMenuCallbackID")] 
		public CHandle<redCallbackObject> UiSystemIsInMenuCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(52)] 
		[RED("twintoneFactListenerId")] 
		public CUInt32 TwintoneFactListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(53)] 
		[RED("possessedByJohnnyFactListenerId")] 
		public CUInt32 PossessedByJohnnyFactListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(54)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(55)] 
		[RED("outroAnimProxy")] 
		public CHandle<inkanimProxy> OutroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(56)] 
		[RED("scannerToggleTabOpenAnimProxy")] 
		public CHandle<inkanimProxy> ScannerToggleTabOpenAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(57)] 
		[RED("scannerToggleTabCloseAnimProxy")] 
		public CHandle<inkanimProxy> ScannerToggleTabCloseAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public scannerDetailsGameController()
		{
			ScannerCountainer = new inkCompoundWidgetReference();
			CluesContainer = new inkCompoundWidgetReference();
			QuickhackContainer = new inkCompoundWidgetReference();
			TwintoneContainer = new inkCompoundWidgetReference();
			ToggleDescirptionHackPart = new inkWidgetReference();
			ToggleDescriptionTwintonePart = new inkWidgetReference();
			KiroshiLogo = new inkWidgetReference();
			BottomFluff = new inkWidgetReference();
			TwintoneNoModelAvailable = new inkWidgetReference();
			TwintoneSaveButtonHints = new inkWidgetReference();
			TwintoneApplyButtonHints = new inkWidgetReference();
			ChangeTabButtonHints = new inkWidgetReference();
			ChangeTabInlineHint = new inkWidgetReference();
			SpaceTab01 = new inkWidgetReference();
			SpaceTab02 = new inkWidgetReference();
			Twotabs01BottomLine = new inkWidgetReference();
			Twotabs02BottomLine = new inkWidgetReference();
			Threetabs01BottomLine = new inkWidgetReference();
			Threetabs02BottomLine = new inkWidgetReference();
			Threetabs03BottomLine = new inkWidgetReference();
			AsyncSpawnRequests = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

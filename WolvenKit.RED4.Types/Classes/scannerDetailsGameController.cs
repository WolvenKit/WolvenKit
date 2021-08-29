using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scannerDetailsGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _scannerCountainer;
		private inkCompoundWidgetReference _quickhackContainer;
		private inkCompoundWidgetReference _cluesContainer;
		private inkWidgetReference _bg;
		private inkWidgetReference _toggleDescirptionHackPart;
		private inkWidgetReference _toggleDescriptionScanIcon;
		private inkWidgetReference _fitToContentBackground;
		private inkWidgetReference _kiroshiLogo;
		private CWeakHandle<gameObject> _player;
		private ScriptGameInstance _gameInstance;
		private CHandle<redCallbackObject> _objectTypeCallbackID;
		private CWeakHandle<gameIBlackboard> _uiScannerChunkBlackboard;
		private CEnum<gameScanningState> _scanningState;
		private CHandle<redCallbackObject> _scanStatusCallbackID;
		private CHandle<redCallbackObject> _scanObjectCallbackID;
		private CWeakHandle<gameIBlackboard> _uiBlackboard;
		private CWeakHandle<gameIBlackboard> _quickSlotsBoard;
		private CHandle<redCallbackObject> _quickSlotsCallbackID;
		private CHandle<redCallbackObject> _quickhackStartedCallbackID;
		private CEnum<ScannerObjectType> _scannedObjectType;
		private CHandle<inkanimProxy> _showScanAnimProxy;
		private CHandle<inkanimProxy> _hideScanAnimProxy;
		private CHandle<inkanimProxy> _toggleScanDescriptionAnimProxy;
		private CName _previousToggleAnimName;
		private CBool _hasHacks;
		private entEntityID _lastScannedObject;
		private CBool _isDescriptionVisible;
		private CArray<CWeakHandle<inkAsyncSpawnRequest>> _asyncSpawnRequests;

		[Ordinal(9)] 
		[RED("scannerCountainer")] 
		public inkCompoundWidgetReference ScannerCountainer
		{
			get => GetProperty(ref _scannerCountainer);
			set => SetProperty(ref _scannerCountainer, value);
		}

		[Ordinal(10)] 
		[RED("quickhackContainer")] 
		public inkCompoundWidgetReference QuickhackContainer
		{
			get => GetProperty(ref _quickhackContainer);
			set => SetProperty(ref _quickhackContainer, value);
		}

		[Ordinal(11)] 
		[RED("cluesContainer")] 
		public inkCompoundWidgetReference CluesContainer
		{
			get => GetProperty(ref _cluesContainer);
			set => SetProperty(ref _cluesContainer, value);
		}

		[Ordinal(12)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get => GetProperty(ref _bg);
			set => SetProperty(ref _bg, value);
		}

		[Ordinal(13)] 
		[RED("toggleDescirptionHackPart")] 
		public inkWidgetReference ToggleDescirptionHackPart
		{
			get => GetProperty(ref _toggleDescirptionHackPart);
			set => SetProperty(ref _toggleDescirptionHackPart, value);
		}

		[Ordinal(14)] 
		[RED("toggleDescriptionScanIcon")] 
		public inkWidgetReference ToggleDescriptionScanIcon
		{
			get => GetProperty(ref _toggleDescriptionScanIcon);
			set => SetProperty(ref _toggleDescriptionScanIcon, value);
		}

		[Ordinal(15)] 
		[RED("fitToContentBackground")] 
		public inkWidgetReference FitToContentBackground
		{
			get => GetProperty(ref _fitToContentBackground);
			set => SetProperty(ref _fitToContentBackground, value);
		}

		[Ordinal(16)] 
		[RED("kiroshiLogo")] 
		public inkWidgetReference KiroshiLogo
		{
			get => GetProperty(ref _kiroshiLogo);
			set => SetProperty(ref _kiroshiLogo, value);
		}

		[Ordinal(17)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(18)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(19)] 
		[RED("objectTypeCallbackID")] 
		public CHandle<redCallbackObject> ObjectTypeCallbackID
		{
			get => GetProperty(ref _objectTypeCallbackID);
			set => SetProperty(ref _objectTypeCallbackID, value);
		}

		[Ordinal(20)] 
		[RED("uiScannerChunkBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiScannerChunkBlackboard
		{
			get => GetProperty(ref _uiScannerChunkBlackboard);
			set => SetProperty(ref _uiScannerChunkBlackboard, value);
		}

		[Ordinal(21)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get => GetProperty(ref _scanningState);
			set => SetProperty(ref _scanningState, value);
		}

		[Ordinal(22)] 
		[RED("scanStatusCallbackID")] 
		public CHandle<redCallbackObject> ScanStatusCallbackID
		{
			get => GetProperty(ref _scanStatusCallbackID);
			set => SetProperty(ref _scanStatusCallbackID, value);
		}

		[Ordinal(23)] 
		[RED("scanObjectCallbackID")] 
		public CHandle<redCallbackObject> ScanObjectCallbackID
		{
			get => GetProperty(ref _scanObjectCallbackID);
			set => SetProperty(ref _scanObjectCallbackID, value);
		}

		[Ordinal(24)] 
		[RED("uiBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiBlackboard
		{
			get => GetProperty(ref _uiBlackboard);
			set => SetProperty(ref _uiBlackboard, value);
		}

		[Ordinal(25)] 
		[RED("quickSlotsBoard")] 
		public CWeakHandle<gameIBlackboard> QuickSlotsBoard
		{
			get => GetProperty(ref _quickSlotsBoard);
			set => SetProperty(ref _quickSlotsBoard, value);
		}

		[Ordinal(26)] 
		[RED("quickSlotsCallbackID")] 
		public CHandle<redCallbackObject> QuickSlotsCallbackID
		{
			get => GetProperty(ref _quickSlotsCallbackID);
			set => SetProperty(ref _quickSlotsCallbackID, value);
		}

		[Ordinal(27)] 
		[RED("quickhackStartedCallbackID")] 
		public CHandle<redCallbackObject> QuickhackStartedCallbackID
		{
			get => GetProperty(ref _quickhackStartedCallbackID);
			set => SetProperty(ref _quickhackStartedCallbackID, value);
		}

		[Ordinal(28)] 
		[RED("scannedObjectType")] 
		public CEnum<ScannerObjectType> ScannedObjectType
		{
			get => GetProperty(ref _scannedObjectType);
			set => SetProperty(ref _scannedObjectType, value);
		}

		[Ordinal(29)] 
		[RED("showScanAnimProxy")] 
		public CHandle<inkanimProxy> ShowScanAnimProxy
		{
			get => GetProperty(ref _showScanAnimProxy);
			set => SetProperty(ref _showScanAnimProxy, value);
		}

		[Ordinal(30)] 
		[RED("hideScanAnimProxy")] 
		public CHandle<inkanimProxy> HideScanAnimProxy
		{
			get => GetProperty(ref _hideScanAnimProxy);
			set => SetProperty(ref _hideScanAnimProxy, value);
		}

		[Ordinal(31)] 
		[RED("toggleScanDescriptionAnimProxy")] 
		public CHandle<inkanimProxy> ToggleScanDescriptionAnimProxy
		{
			get => GetProperty(ref _toggleScanDescriptionAnimProxy);
			set => SetProperty(ref _toggleScanDescriptionAnimProxy, value);
		}

		[Ordinal(32)] 
		[RED("previousToggleAnimName")] 
		public CName PreviousToggleAnimName
		{
			get => GetProperty(ref _previousToggleAnimName);
			set => SetProperty(ref _previousToggleAnimName, value);
		}

		[Ordinal(33)] 
		[RED("hasHacks")] 
		public CBool HasHacks
		{
			get => GetProperty(ref _hasHacks);
			set => SetProperty(ref _hasHacks, value);
		}

		[Ordinal(34)] 
		[RED("lastScannedObject")] 
		public entEntityID LastScannedObject
		{
			get => GetProperty(ref _lastScannedObject);
			set => SetProperty(ref _lastScannedObject, value);
		}

		[Ordinal(35)] 
		[RED("isDescriptionVisible")] 
		public CBool IsDescriptionVisible
		{
			get => GetProperty(ref _isDescriptionVisible);
			set => SetProperty(ref _isDescriptionVisible, value);
		}

		[Ordinal(36)] 
		[RED("asyncSpawnRequests")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> AsyncSpawnRequests
		{
			get => GetProperty(ref _asyncSpawnRequests);
			set => SetProperty(ref _asyncSpawnRequests, value);
		}
	}
}

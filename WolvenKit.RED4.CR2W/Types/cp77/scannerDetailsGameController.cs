using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scannerDetailsGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _scannerCountainer;
		private inkCompoundWidgetReference _quickhackContainer;
		private inkCompoundWidgetReference _cluesContainer;
		private inkCompoundWidgetReference _fllufContainer;
		private inkWidgetReference _bg;
		private inkWidgetReference _toggleDescirptionHackPart;
		private inkWidgetReference _toggleDescriptionScanIcon;
		private inkWidgetReference _fitToContentBackground;
		private inkWidgetReference _kiroshiLogo;
		private wCHandle<gameObject> _player;
		private ScriptGameInstance _gameInstance;
		private CUInt32 _objectTypeCallbackID;
		private CHandle<gameIBlackboard> _uiScannerChunkBlackboard;
		private CEnum<gameScanningState> _scanningState;
		private CUInt32 _scanStatusCallbackID;
		private CUInt32 _scanObjectCallbackID;
		private CHandle<gameIBlackboard> _uiBlackboard;
		private CHandle<gameIBlackboard> _quickSlotsBoard;
		private CUInt32 _quickSlotsCallbackID;
		private CUInt32 _quickhackStartedCallbackID;
		private CEnum<ScannerObjectType> _scannedObjectType;
		private CHandle<inkanimProxy> _showScanAnimProxy;
		private CHandle<inkanimProxy> _hideScanAnimProxy;
		private CHandle<inkanimProxy> _toggleScanDescriptionAnimProxy;
		private CName _previousToggleAnimName;
		private CBool _hasHacks;
		private entEntityID _lastScannedObject;
		private CBool _isDescriptionVisible;

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
		[RED("fllufContainer")] 
		public inkCompoundWidgetReference FllufContainer
		{
			get => GetProperty(ref _fllufContainer);
			set => SetProperty(ref _fllufContainer, value);
		}

		[Ordinal(13)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get => GetProperty(ref _bg);
			set => SetProperty(ref _bg, value);
		}

		[Ordinal(14)] 
		[RED("toggleDescirptionHackPart")] 
		public inkWidgetReference ToggleDescirptionHackPart
		{
			get => GetProperty(ref _toggleDescirptionHackPart);
			set => SetProperty(ref _toggleDescirptionHackPart, value);
		}

		[Ordinal(15)] 
		[RED("toggleDescriptionScanIcon")] 
		public inkWidgetReference ToggleDescriptionScanIcon
		{
			get => GetProperty(ref _toggleDescriptionScanIcon);
			set => SetProperty(ref _toggleDescriptionScanIcon, value);
		}

		[Ordinal(16)] 
		[RED("fitToContentBackground")] 
		public inkWidgetReference FitToContentBackground
		{
			get => GetProperty(ref _fitToContentBackground);
			set => SetProperty(ref _fitToContentBackground, value);
		}

		[Ordinal(17)] 
		[RED("kiroshiLogo")] 
		public inkWidgetReference KiroshiLogo
		{
			get => GetProperty(ref _kiroshiLogo);
			set => SetProperty(ref _kiroshiLogo, value);
		}

		[Ordinal(18)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(19)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(20)] 
		[RED("objectTypeCallbackID")] 
		public CUInt32 ObjectTypeCallbackID
		{
			get => GetProperty(ref _objectTypeCallbackID);
			set => SetProperty(ref _objectTypeCallbackID, value);
		}

		[Ordinal(21)] 
		[RED("uiScannerChunkBlackboard")] 
		public CHandle<gameIBlackboard> UiScannerChunkBlackboard
		{
			get => GetProperty(ref _uiScannerChunkBlackboard);
			set => SetProperty(ref _uiScannerChunkBlackboard, value);
		}

		[Ordinal(22)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get => GetProperty(ref _scanningState);
			set => SetProperty(ref _scanningState, value);
		}

		[Ordinal(23)] 
		[RED("scanStatusCallbackID")] 
		public CUInt32 ScanStatusCallbackID
		{
			get => GetProperty(ref _scanStatusCallbackID);
			set => SetProperty(ref _scanStatusCallbackID, value);
		}

		[Ordinal(24)] 
		[RED("scanObjectCallbackID")] 
		public CUInt32 ScanObjectCallbackID
		{
			get => GetProperty(ref _scanObjectCallbackID);
			set => SetProperty(ref _scanObjectCallbackID, value);
		}

		[Ordinal(25)] 
		[RED("uiBlackboard")] 
		public CHandle<gameIBlackboard> UiBlackboard
		{
			get => GetProperty(ref _uiBlackboard);
			set => SetProperty(ref _uiBlackboard, value);
		}

		[Ordinal(26)] 
		[RED("quickSlotsBoard")] 
		public CHandle<gameIBlackboard> QuickSlotsBoard
		{
			get => GetProperty(ref _quickSlotsBoard);
			set => SetProperty(ref _quickSlotsBoard, value);
		}

		[Ordinal(27)] 
		[RED("quickSlotsCallbackID")] 
		public CUInt32 QuickSlotsCallbackID
		{
			get => GetProperty(ref _quickSlotsCallbackID);
			set => SetProperty(ref _quickSlotsCallbackID, value);
		}

		[Ordinal(28)] 
		[RED("quickhackStartedCallbackID")] 
		public CUInt32 QuickhackStartedCallbackID
		{
			get => GetProperty(ref _quickhackStartedCallbackID);
			set => SetProperty(ref _quickhackStartedCallbackID, value);
		}

		[Ordinal(29)] 
		[RED("scannedObjectType")] 
		public CEnum<ScannerObjectType> ScannedObjectType
		{
			get => GetProperty(ref _scannedObjectType);
			set => SetProperty(ref _scannedObjectType, value);
		}

		[Ordinal(30)] 
		[RED("showScanAnimProxy")] 
		public CHandle<inkanimProxy> ShowScanAnimProxy
		{
			get => GetProperty(ref _showScanAnimProxy);
			set => SetProperty(ref _showScanAnimProxy, value);
		}

		[Ordinal(31)] 
		[RED("hideScanAnimProxy")] 
		public CHandle<inkanimProxy> HideScanAnimProxy
		{
			get => GetProperty(ref _hideScanAnimProxy);
			set => SetProperty(ref _hideScanAnimProxy, value);
		}

		[Ordinal(32)] 
		[RED("toggleScanDescriptionAnimProxy")] 
		public CHandle<inkanimProxy> ToggleScanDescriptionAnimProxy
		{
			get => GetProperty(ref _toggleScanDescriptionAnimProxy);
			set => SetProperty(ref _toggleScanDescriptionAnimProxy, value);
		}

		[Ordinal(33)] 
		[RED("previousToggleAnimName")] 
		public CName PreviousToggleAnimName
		{
			get => GetProperty(ref _previousToggleAnimName);
			set => SetProperty(ref _previousToggleAnimName, value);
		}

		[Ordinal(34)] 
		[RED("hasHacks")] 
		public CBool HasHacks
		{
			get => GetProperty(ref _hasHacks);
			set => SetProperty(ref _hasHacks, value);
		}

		[Ordinal(35)] 
		[RED("lastScannedObject")] 
		public entEntityID LastScannedObject
		{
			get => GetProperty(ref _lastScannedObject);
			set => SetProperty(ref _lastScannedObject, value);
		}

		[Ordinal(36)] 
		[RED("isDescriptionVisible")] 
		public CBool IsDescriptionVisible
		{
			get => GetProperty(ref _isDescriptionVisible);
			set => SetProperty(ref _isDescriptionVisible, value);
		}

		public scannerDetailsGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

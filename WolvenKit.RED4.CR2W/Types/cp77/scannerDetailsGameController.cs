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
			get
			{
				if (_scannerCountainer == null)
				{
					_scannerCountainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "scannerCountainer", cr2w, this);
				}
				return _scannerCountainer;
			}
			set
			{
				if (_scannerCountainer == value)
				{
					return;
				}
				_scannerCountainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("quickhackContainer")] 
		public inkCompoundWidgetReference QuickhackContainer
		{
			get
			{
				if (_quickhackContainer == null)
				{
					_quickhackContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "quickhackContainer", cr2w, this);
				}
				return _quickhackContainer;
			}
			set
			{
				if (_quickhackContainer == value)
				{
					return;
				}
				_quickhackContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("cluesContainer")] 
		public inkCompoundWidgetReference CluesContainer
		{
			get
			{
				if (_cluesContainer == null)
				{
					_cluesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "cluesContainer", cr2w, this);
				}
				return _cluesContainer;
			}
			set
			{
				if (_cluesContainer == value)
				{
					return;
				}
				_cluesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("fllufContainer")] 
		public inkCompoundWidgetReference FllufContainer
		{
			get
			{
				if (_fllufContainer == null)
				{
					_fllufContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "fllufContainer", cr2w, this);
				}
				return _fllufContainer;
			}
			set
			{
				if (_fllufContainer == value)
				{
					return;
				}
				_fllufContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get
			{
				if (_bg == null)
				{
					_bg = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bg", cr2w, this);
				}
				return _bg;
			}
			set
			{
				if (_bg == value)
				{
					return;
				}
				_bg = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("toggleDescirptionHackPart")] 
		public inkWidgetReference ToggleDescirptionHackPart
		{
			get
			{
				if (_toggleDescirptionHackPart == null)
				{
					_toggleDescirptionHackPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "toggleDescirptionHackPart", cr2w, this);
				}
				return _toggleDescirptionHackPart;
			}
			set
			{
				if (_toggleDescirptionHackPart == value)
				{
					return;
				}
				_toggleDescirptionHackPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("toggleDescriptionScanIcon")] 
		public inkWidgetReference ToggleDescriptionScanIcon
		{
			get
			{
				if (_toggleDescriptionScanIcon == null)
				{
					_toggleDescriptionScanIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "toggleDescriptionScanIcon", cr2w, this);
				}
				return _toggleDescriptionScanIcon;
			}
			set
			{
				if (_toggleDescriptionScanIcon == value)
				{
					return;
				}
				_toggleDescriptionScanIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("fitToContentBackground")] 
		public inkWidgetReference FitToContentBackground
		{
			get
			{
				if (_fitToContentBackground == null)
				{
					_fitToContentBackground = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "fitToContentBackground", cr2w, this);
				}
				return _fitToContentBackground;
			}
			set
			{
				if (_fitToContentBackground == value)
				{
					return;
				}
				_fitToContentBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("kiroshiLogo")] 
		public inkWidgetReference KiroshiLogo
		{
			get
			{
				if (_kiroshiLogo == null)
				{
					_kiroshiLogo = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "kiroshiLogo", cr2w, this);
				}
				return _kiroshiLogo;
			}
			set
			{
				if (_kiroshiLogo == value)
				{
					return;
				}
				_kiroshiLogo = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("objectTypeCallbackID")] 
		public CUInt32 ObjectTypeCallbackID
		{
			get
			{
				if (_objectTypeCallbackID == null)
				{
					_objectTypeCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "objectTypeCallbackID", cr2w, this);
				}
				return _objectTypeCallbackID;
			}
			set
			{
				if (_objectTypeCallbackID == value)
				{
					return;
				}
				_objectTypeCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("uiScannerChunkBlackboard")] 
		public CHandle<gameIBlackboard> UiScannerChunkBlackboard
		{
			get
			{
				if (_uiScannerChunkBlackboard == null)
				{
					_uiScannerChunkBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiScannerChunkBlackboard", cr2w, this);
				}
				return _uiScannerChunkBlackboard;
			}
			set
			{
				if (_uiScannerChunkBlackboard == value)
				{
					return;
				}
				_uiScannerChunkBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get
			{
				if (_scanningState == null)
				{
					_scanningState = (CEnum<gameScanningState>) CR2WTypeManager.Create("gameScanningState", "scanningState", cr2w, this);
				}
				return _scanningState;
			}
			set
			{
				if (_scanningState == value)
				{
					return;
				}
				_scanningState = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("scanStatusCallbackID")] 
		public CUInt32 ScanStatusCallbackID
		{
			get
			{
				if (_scanStatusCallbackID == null)
				{
					_scanStatusCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "scanStatusCallbackID", cr2w, this);
				}
				return _scanStatusCallbackID;
			}
			set
			{
				if (_scanStatusCallbackID == value)
				{
					return;
				}
				_scanStatusCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("scanObjectCallbackID")] 
		public CUInt32 ScanObjectCallbackID
		{
			get
			{
				if (_scanObjectCallbackID == null)
				{
					_scanObjectCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "scanObjectCallbackID", cr2w, this);
				}
				return _scanObjectCallbackID;
			}
			set
			{
				if (_scanObjectCallbackID == value)
				{
					return;
				}
				_scanObjectCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("uiBlackboard")] 
		public CHandle<gameIBlackboard> UiBlackboard
		{
			get
			{
				if (_uiBlackboard == null)
				{
					_uiBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiBlackboard", cr2w, this);
				}
				return _uiBlackboard;
			}
			set
			{
				if (_uiBlackboard == value)
				{
					return;
				}
				_uiBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("quickSlotsBoard")] 
		public CHandle<gameIBlackboard> QuickSlotsBoard
		{
			get
			{
				if (_quickSlotsBoard == null)
				{
					_quickSlotsBoard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "quickSlotsBoard", cr2w, this);
				}
				return _quickSlotsBoard;
			}
			set
			{
				if (_quickSlotsBoard == value)
				{
					return;
				}
				_quickSlotsBoard = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("quickSlotsCallbackID")] 
		public CUInt32 QuickSlotsCallbackID
		{
			get
			{
				if (_quickSlotsCallbackID == null)
				{
					_quickSlotsCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "quickSlotsCallbackID", cr2w, this);
				}
				return _quickSlotsCallbackID;
			}
			set
			{
				if (_quickSlotsCallbackID == value)
				{
					return;
				}
				_quickSlotsCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("quickhackStartedCallbackID")] 
		public CUInt32 QuickhackStartedCallbackID
		{
			get
			{
				if (_quickhackStartedCallbackID == null)
				{
					_quickhackStartedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "quickhackStartedCallbackID", cr2w, this);
				}
				return _quickhackStartedCallbackID;
			}
			set
			{
				if (_quickhackStartedCallbackID == value)
				{
					return;
				}
				_quickhackStartedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("scannedObjectType")] 
		public CEnum<ScannerObjectType> ScannedObjectType
		{
			get
			{
				if (_scannedObjectType == null)
				{
					_scannedObjectType = (CEnum<ScannerObjectType>) CR2WTypeManager.Create("ScannerObjectType", "scannedObjectType", cr2w, this);
				}
				return _scannedObjectType;
			}
			set
			{
				if (_scannedObjectType == value)
				{
					return;
				}
				_scannedObjectType = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("showScanAnimProxy")] 
		public CHandle<inkanimProxy> ShowScanAnimProxy
		{
			get
			{
				if (_showScanAnimProxy == null)
				{
					_showScanAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "showScanAnimProxy", cr2w, this);
				}
				return _showScanAnimProxy;
			}
			set
			{
				if (_showScanAnimProxy == value)
				{
					return;
				}
				_showScanAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("hideScanAnimProxy")] 
		public CHandle<inkanimProxy> HideScanAnimProxy
		{
			get
			{
				if (_hideScanAnimProxy == null)
				{
					_hideScanAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "hideScanAnimProxy", cr2w, this);
				}
				return _hideScanAnimProxy;
			}
			set
			{
				if (_hideScanAnimProxy == value)
				{
					return;
				}
				_hideScanAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("toggleScanDescriptionAnimProxy")] 
		public CHandle<inkanimProxy> ToggleScanDescriptionAnimProxy
		{
			get
			{
				if (_toggleScanDescriptionAnimProxy == null)
				{
					_toggleScanDescriptionAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "toggleScanDescriptionAnimProxy", cr2w, this);
				}
				return _toggleScanDescriptionAnimProxy;
			}
			set
			{
				if (_toggleScanDescriptionAnimProxy == value)
				{
					return;
				}
				_toggleScanDescriptionAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("previousToggleAnimName")] 
		public CName PreviousToggleAnimName
		{
			get
			{
				if (_previousToggleAnimName == null)
				{
					_previousToggleAnimName = (CName) CR2WTypeManager.Create("CName", "previousToggleAnimName", cr2w, this);
				}
				return _previousToggleAnimName;
			}
			set
			{
				if (_previousToggleAnimName == value)
				{
					return;
				}
				_previousToggleAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("hasHacks")] 
		public CBool HasHacks
		{
			get
			{
				if (_hasHacks == null)
				{
					_hasHacks = (CBool) CR2WTypeManager.Create("Bool", "hasHacks", cr2w, this);
				}
				return _hasHacks;
			}
			set
			{
				if (_hasHacks == value)
				{
					return;
				}
				_hasHacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("lastScannedObject")] 
		public entEntityID LastScannedObject
		{
			get
			{
				if (_lastScannedObject == null)
				{
					_lastScannedObject = (entEntityID) CR2WTypeManager.Create("entEntityID", "lastScannedObject", cr2w, this);
				}
				return _lastScannedObject;
			}
			set
			{
				if (_lastScannedObject == value)
				{
					return;
				}
				_lastScannedObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("isDescriptionVisible")] 
		public CBool IsDescriptionVisible
		{
			get
			{
				if (_isDescriptionVisible == null)
				{
					_isDescriptionVisible = (CBool) CR2WTypeManager.Create("Bool", "isDescriptionVisible", cr2w, this);
				}
				return _isDescriptionVisible;
			}
			set
			{
				if (_isDescriptionVisible == value)
				{
					return;
				}
				_isDescriptionVisible = value;
				PropertySet(this);
			}
		}

		public scannerDetailsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

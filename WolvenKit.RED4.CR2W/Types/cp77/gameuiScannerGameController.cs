using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiScannerGameController : gameuiHUDGameController
	{
		private entEntityID _currentTarget;
		private CBool _scanLock;
		private CFloat _percentValue;
		private CFloat _oldPercentValue;
		private wCHandle<gameIBlackboard> _bbWeaponInfo;
		private wCHandle<gameIBlackboard> _braindanceBB;
		private CUInt32 _bbWeaponEventId;
		private CUInt32 _bBID_BraindanceActive;
		private scannerDataStructure _scannerData;
		private GameObjectScanStats _curObj;
		private wCHandle<inkCompoundWidget> _scannerBorderMain;
		private wCHandle<scannerBorderLogicController> _scannerBorderController;
		private wCHandle<inkCompoundWidget> _scannerProgressMain;
		private wCHandle<inkWidget> _scannerFullScreenOverlay;
		private wCHandle<inkImageWidget> _center_frame;
		private CArray<wCHandle<inkImageWidget>> _squares;
		private CArray<wCHandle<inkImageWidget>> _squaresFilled;
		private CBool _isUnarmed;
		private CBool _isEnabled;
		private CBool _isFinish;
		private CBool _isScanned;
		private CBool _isBraindanceActive;
		private CHandle<inkanimDefinition> _border_show;
		private CHandle<inkanimDefinition> _center_show;
		private CHandle<inkanimDefinition> _center_hide;
		private CHandle<inkanimDefinition> _dots_show;
		private CHandle<inkanimDefinition> _dots_hide;
		private CHandle<inkanimProxy> _borderAnimProxy;
		private CName _soundFinishedOn;
		private CName _soundFinishedOff;
		private CUInt32 _playerSpawnedCallbackID;
		private CUInt32 _bBID_IsEnabledChange;
		private ScriptGameInstance _gameInstance;
		private CBool _isShown;
		private wCHandle<gameObject> _playerPuppet;

		[Ordinal(9)] 
		[RED("currentTarget")] 
		public entEntityID CurrentTarget
		{
			get
			{
				if (_currentTarget == null)
				{
					_currentTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "currentTarget", cr2w, this);
				}
				return _currentTarget;
			}
			set
			{
				if (_currentTarget == value)
				{
					return;
				}
				_currentTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("scanLock")] 
		public CBool ScanLock
		{
			get
			{
				if (_scanLock == null)
				{
					_scanLock = (CBool) CR2WTypeManager.Create("Bool", "scanLock", cr2w, this);
				}
				return _scanLock;
			}
			set
			{
				if (_scanLock == value)
				{
					return;
				}
				_scanLock = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("percentValue")] 
		public CFloat PercentValue
		{
			get
			{
				if (_percentValue == null)
				{
					_percentValue = (CFloat) CR2WTypeManager.Create("Float", "percentValue", cr2w, this);
				}
				return _percentValue;
			}
			set
			{
				if (_percentValue == value)
				{
					return;
				}
				_percentValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("oldPercentValue")] 
		public CFloat OldPercentValue
		{
			get
			{
				if (_oldPercentValue == null)
				{
					_oldPercentValue = (CFloat) CR2WTypeManager.Create("Float", "oldPercentValue", cr2w, this);
				}
				return _oldPercentValue;
			}
			set
			{
				if (_oldPercentValue == value)
				{
					return;
				}
				_oldPercentValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bbWeaponInfo")] 
		public wCHandle<gameIBlackboard> BbWeaponInfo
		{
			get
			{
				if (_bbWeaponInfo == null)
				{
					_bbWeaponInfo = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "bbWeaponInfo", cr2w, this);
				}
				return _bbWeaponInfo;
			}
			set
			{
				if (_bbWeaponInfo == value)
				{
					return;
				}
				_bbWeaponInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("BraindanceBB")] 
		public wCHandle<gameIBlackboard> BraindanceBB
		{
			get
			{
				if (_braindanceBB == null)
				{
					_braindanceBB = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "BraindanceBB", cr2w, this);
				}
				return _braindanceBB;
			}
			set
			{
				if (_braindanceBB == value)
				{
					return;
				}
				_braindanceBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bbWeaponEventId")] 
		public CUInt32 BbWeaponEventId
		{
			get
			{
				if (_bbWeaponEventId == null)
				{
					_bbWeaponEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbWeaponEventId", cr2w, this);
				}
				return _bbWeaponEventId;
			}
			set
			{
				if (_bbWeaponEventId == value)
				{
					return;
				}
				_bbWeaponEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("BBID_BraindanceActive")] 
		public CUInt32 BBID_BraindanceActive
		{
			get
			{
				if (_bBID_BraindanceActive == null)
				{
					_bBID_BraindanceActive = (CUInt32) CR2WTypeManager.Create("Uint32", "BBID_BraindanceActive", cr2w, this);
				}
				return _bBID_BraindanceActive;
			}
			set
			{
				if (_bBID_BraindanceActive == value)
				{
					return;
				}
				_bBID_BraindanceActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("scannerData")] 
		public scannerDataStructure ScannerData
		{
			get
			{
				if (_scannerData == null)
				{
					_scannerData = (scannerDataStructure) CR2WTypeManager.Create("scannerDataStructure", "scannerData", cr2w, this);
				}
				return _scannerData;
			}
			set
			{
				if (_scannerData == value)
				{
					return;
				}
				_scannerData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("curObj")] 
		public GameObjectScanStats CurObj
		{
			get
			{
				if (_curObj == null)
				{
					_curObj = (GameObjectScanStats) CR2WTypeManager.Create("GameObjectScanStats", "curObj", cr2w, this);
				}
				return _curObj;
			}
			set
			{
				if (_curObj == value)
				{
					return;
				}
				_curObj = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("scannerBorderMain")] 
		public wCHandle<inkCompoundWidget> ScannerBorderMain
		{
			get
			{
				if (_scannerBorderMain == null)
				{
					_scannerBorderMain = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "scannerBorderMain", cr2w, this);
				}
				return _scannerBorderMain;
			}
			set
			{
				if (_scannerBorderMain == value)
				{
					return;
				}
				_scannerBorderMain = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("scannerBorderController")] 
		public wCHandle<scannerBorderLogicController> ScannerBorderController
		{
			get
			{
				if (_scannerBorderController == null)
				{
					_scannerBorderController = (wCHandle<scannerBorderLogicController>) CR2WTypeManager.Create("whandle:scannerBorderLogicController", "scannerBorderController", cr2w, this);
				}
				return _scannerBorderController;
			}
			set
			{
				if (_scannerBorderController == value)
				{
					return;
				}
				_scannerBorderController = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("scannerProgressMain")] 
		public wCHandle<inkCompoundWidget> ScannerProgressMain
		{
			get
			{
				if (_scannerProgressMain == null)
				{
					_scannerProgressMain = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "scannerProgressMain", cr2w, this);
				}
				return _scannerProgressMain;
			}
			set
			{
				if (_scannerProgressMain == value)
				{
					return;
				}
				_scannerProgressMain = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("scannerFullScreenOverlay")] 
		public wCHandle<inkWidget> ScannerFullScreenOverlay
		{
			get
			{
				if (_scannerFullScreenOverlay == null)
				{
					_scannerFullScreenOverlay = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "scannerFullScreenOverlay", cr2w, this);
				}
				return _scannerFullScreenOverlay;
			}
			set
			{
				if (_scannerFullScreenOverlay == value)
				{
					return;
				}
				_scannerFullScreenOverlay = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("center_frame")] 
		public wCHandle<inkImageWidget> Center_frame
		{
			get
			{
				if (_center_frame == null)
				{
					_center_frame = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "center_frame", cr2w, this);
				}
				return _center_frame;
			}
			set
			{
				if (_center_frame == value)
				{
					return;
				}
				_center_frame = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("squares")] 
		public CArray<wCHandle<inkImageWidget>> Squares
		{
			get
			{
				if (_squares == null)
				{
					_squares = (CArray<wCHandle<inkImageWidget>>) CR2WTypeManager.Create("array:whandle:inkImageWidget", "squares", cr2w, this);
				}
				return _squares;
			}
			set
			{
				if (_squares == value)
				{
					return;
				}
				_squares = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("squaresFilled")] 
		public CArray<wCHandle<inkImageWidget>> SquaresFilled
		{
			get
			{
				if (_squaresFilled == null)
				{
					_squaresFilled = (CArray<wCHandle<inkImageWidget>>) CR2WTypeManager.Create("array:whandle:inkImageWidget", "squaresFilled", cr2w, this);
				}
				return _squaresFilled;
			}
			set
			{
				if (_squaresFilled == value)
				{
					return;
				}
				_squaresFilled = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("isUnarmed")] 
		public CBool IsUnarmed
		{
			get
			{
				if (_isUnarmed == null)
				{
					_isUnarmed = (CBool) CR2WTypeManager.Create("Bool", "isUnarmed", cr2w, this);
				}
				return _isUnarmed;
			}
			set
			{
				if (_isUnarmed == value)
				{
					return;
				}
				_isUnarmed = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("isFinish")] 
		public CBool IsFinish
		{
			get
			{
				if (_isFinish == null)
				{
					_isFinish = (CBool) CR2WTypeManager.Create("Bool", "isFinish", cr2w, this);
				}
				return _isFinish;
			}
			set
			{
				if (_isFinish == value)
				{
					return;
				}
				_isFinish = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get
			{
				if (_isScanned == null)
				{
					_isScanned = (CBool) CR2WTypeManager.Create("Bool", "isScanned", cr2w, this);
				}
				return _isScanned;
			}
			set
			{
				if (_isScanned == value)
				{
					return;
				}
				_isScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("isBraindanceActive")] 
		public CBool IsBraindanceActive
		{
			get
			{
				if (_isBraindanceActive == null)
				{
					_isBraindanceActive = (CBool) CR2WTypeManager.Create("Bool", "isBraindanceActive", cr2w, this);
				}
				return _isBraindanceActive;
			}
			set
			{
				if (_isBraindanceActive == value)
				{
					return;
				}
				_isBraindanceActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("border_show")] 
		public CHandle<inkanimDefinition> Border_show
		{
			get
			{
				if (_border_show == null)
				{
					_border_show = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "border_show", cr2w, this);
				}
				return _border_show;
			}
			set
			{
				if (_border_show == value)
				{
					return;
				}
				_border_show = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("center_show")] 
		public CHandle<inkanimDefinition> Center_show
		{
			get
			{
				if (_center_show == null)
				{
					_center_show = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "center_show", cr2w, this);
				}
				return _center_show;
			}
			set
			{
				if (_center_show == value)
				{
					return;
				}
				_center_show = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("center_hide")] 
		public CHandle<inkanimDefinition> Center_hide
		{
			get
			{
				if (_center_hide == null)
				{
					_center_hide = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "center_hide", cr2w, this);
				}
				return _center_hide;
			}
			set
			{
				if (_center_hide == value)
				{
					return;
				}
				_center_hide = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("dots_show")] 
		public CHandle<inkanimDefinition> Dots_show
		{
			get
			{
				if (_dots_show == null)
				{
					_dots_show = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "dots_show", cr2w, this);
				}
				return _dots_show;
			}
			set
			{
				if (_dots_show == value)
				{
					return;
				}
				_dots_show = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("dots_hide")] 
		public CHandle<inkanimDefinition> Dots_hide
		{
			get
			{
				if (_dots_hide == null)
				{
					_dots_hide = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "dots_hide", cr2w, this);
				}
				return _dots_hide;
			}
			set
			{
				if (_dots_hide == value)
				{
					return;
				}
				_dots_hide = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("BorderAnimProxy")] 
		public CHandle<inkanimProxy> BorderAnimProxy
		{
			get
			{
				if (_borderAnimProxy == null)
				{
					_borderAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "BorderAnimProxy", cr2w, this);
				}
				return _borderAnimProxy;
			}
			set
			{
				if (_borderAnimProxy == value)
				{
					return;
				}
				_borderAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("soundFinishedOn")] 
		public CName SoundFinishedOn
		{
			get
			{
				if (_soundFinishedOn == null)
				{
					_soundFinishedOn = (CName) CR2WTypeManager.Create("CName", "soundFinishedOn", cr2w, this);
				}
				return _soundFinishedOn;
			}
			set
			{
				if (_soundFinishedOn == value)
				{
					return;
				}
				_soundFinishedOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("soundFinishedOff")] 
		public CName SoundFinishedOff
		{
			get
			{
				if (_soundFinishedOff == null)
				{
					_soundFinishedOff = (CName) CR2WTypeManager.Create("CName", "soundFinishedOff", cr2w, this);
				}
				return _soundFinishedOff;
			}
			set
			{
				if (_soundFinishedOff == value)
				{
					return;
				}
				_soundFinishedOff = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("playerSpawnedCallbackID")] 
		public CUInt32 PlayerSpawnedCallbackID
		{
			get
			{
				if (_playerSpawnedCallbackID == null)
				{
					_playerSpawnedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerSpawnedCallbackID", cr2w, this);
				}
				return _playerSpawnedCallbackID;
			}
			set
			{
				if (_playerSpawnedCallbackID == value)
				{
					return;
				}
				_playerSpawnedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("BBID_IsEnabledChange")] 
		public CUInt32 BBID_IsEnabledChange
		{
			get
			{
				if (_bBID_IsEnabledChange == null)
				{
					_bBID_IsEnabledChange = (CUInt32) CR2WTypeManager.Create("Uint32", "BBID_IsEnabledChange", cr2w, this);
				}
				return _bBID_IsEnabledChange;
			}
			set
			{
				if (_bBID_IsEnabledChange == value)
				{
					return;
				}
				_bBID_IsEnabledChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
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

		[Ordinal(42)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get
			{
				if (_isShown == null)
				{
					_isShown = (CBool) CR2WTypeManager.Create("Bool", "isShown", cr2w, this);
				}
				return _isShown;
			}
			set
			{
				if (_isShown == value)
				{
					return;
				}
				_isShown = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		public gameuiScannerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

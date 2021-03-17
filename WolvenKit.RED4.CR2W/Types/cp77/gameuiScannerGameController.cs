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
			get => GetProperty(ref _currentTarget);
			set => SetProperty(ref _currentTarget, value);
		}

		[Ordinal(10)] 
		[RED("scanLock")] 
		public CBool ScanLock
		{
			get => GetProperty(ref _scanLock);
			set => SetProperty(ref _scanLock, value);
		}

		[Ordinal(11)] 
		[RED("percentValue")] 
		public CFloat PercentValue
		{
			get => GetProperty(ref _percentValue);
			set => SetProperty(ref _percentValue, value);
		}

		[Ordinal(12)] 
		[RED("oldPercentValue")] 
		public CFloat OldPercentValue
		{
			get => GetProperty(ref _oldPercentValue);
			set => SetProperty(ref _oldPercentValue, value);
		}

		[Ordinal(13)] 
		[RED("bbWeaponInfo")] 
		public wCHandle<gameIBlackboard> BbWeaponInfo
		{
			get => GetProperty(ref _bbWeaponInfo);
			set => SetProperty(ref _bbWeaponInfo, value);
		}

		[Ordinal(14)] 
		[RED("BraindanceBB")] 
		public wCHandle<gameIBlackboard> BraindanceBB
		{
			get => GetProperty(ref _braindanceBB);
			set => SetProperty(ref _braindanceBB, value);
		}

		[Ordinal(15)] 
		[RED("bbWeaponEventId")] 
		public CUInt32 BbWeaponEventId
		{
			get => GetProperty(ref _bbWeaponEventId);
			set => SetProperty(ref _bbWeaponEventId, value);
		}

		[Ordinal(16)] 
		[RED("BBID_BraindanceActive")] 
		public CUInt32 BBID_BraindanceActive
		{
			get => GetProperty(ref _bBID_BraindanceActive);
			set => SetProperty(ref _bBID_BraindanceActive, value);
		}

		[Ordinal(17)] 
		[RED("scannerData")] 
		public scannerDataStructure ScannerData
		{
			get => GetProperty(ref _scannerData);
			set => SetProperty(ref _scannerData, value);
		}

		[Ordinal(18)] 
		[RED("curObj")] 
		public GameObjectScanStats CurObj
		{
			get => GetProperty(ref _curObj);
			set => SetProperty(ref _curObj, value);
		}

		[Ordinal(19)] 
		[RED("scannerBorderMain")] 
		public wCHandle<inkCompoundWidget> ScannerBorderMain
		{
			get => GetProperty(ref _scannerBorderMain);
			set => SetProperty(ref _scannerBorderMain, value);
		}

		[Ordinal(20)] 
		[RED("scannerBorderController")] 
		public wCHandle<scannerBorderLogicController> ScannerBorderController
		{
			get => GetProperty(ref _scannerBorderController);
			set => SetProperty(ref _scannerBorderController, value);
		}

		[Ordinal(21)] 
		[RED("scannerProgressMain")] 
		public wCHandle<inkCompoundWidget> ScannerProgressMain
		{
			get => GetProperty(ref _scannerProgressMain);
			set => SetProperty(ref _scannerProgressMain, value);
		}

		[Ordinal(22)] 
		[RED("scannerFullScreenOverlay")] 
		public wCHandle<inkWidget> ScannerFullScreenOverlay
		{
			get => GetProperty(ref _scannerFullScreenOverlay);
			set => SetProperty(ref _scannerFullScreenOverlay, value);
		}

		[Ordinal(23)] 
		[RED("center_frame")] 
		public wCHandle<inkImageWidget> Center_frame
		{
			get => GetProperty(ref _center_frame);
			set => SetProperty(ref _center_frame, value);
		}

		[Ordinal(24)] 
		[RED("squares")] 
		public CArray<wCHandle<inkImageWidget>> Squares
		{
			get => GetProperty(ref _squares);
			set => SetProperty(ref _squares, value);
		}

		[Ordinal(25)] 
		[RED("squaresFilled")] 
		public CArray<wCHandle<inkImageWidget>> SquaresFilled
		{
			get => GetProperty(ref _squaresFilled);
			set => SetProperty(ref _squaresFilled, value);
		}

		[Ordinal(26)] 
		[RED("isUnarmed")] 
		public CBool IsUnarmed
		{
			get => GetProperty(ref _isUnarmed);
			set => SetProperty(ref _isUnarmed, value);
		}

		[Ordinal(27)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(28)] 
		[RED("isFinish")] 
		public CBool IsFinish
		{
			get => GetProperty(ref _isFinish);
			set => SetProperty(ref _isFinish, value);
		}

		[Ordinal(29)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetProperty(ref _isScanned);
			set => SetProperty(ref _isScanned, value);
		}

		[Ordinal(30)] 
		[RED("isBraindanceActive")] 
		public CBool IsBraindanceActive
		{
			get => GetProperty(ref _isBraindanceActive);
			set => SetProperty(ref _isBraindanceActive, value);
		}

		[Ordinal(31)] 
		[RED("border_show")] 
		public CHandle<inkanimDefinition> Border_show
		{
			get => GetProperty(ref _border_show);
			set => SetProperty(ref _border_show, value);
		}

		[Ordinal(32)] 
		[RED("center_show")] 
		public CHandle<inkanimDefinition> Center_show
		{
			get => GetProperty(ref _center_show);
			set => SetProperty(ref _center_show, value);
		}

		[Ordinal(33)] 
		[RED("center_hide")] 
		public CHandle<inkanimDefinition> Center_hide
		{
			get => GetProperty(ref _center_hide);
			set => SetProperty(ref _center_hide, value);
		}

		[Ordinal(34)] 
		[RED("dots_show")] 
		public CHandle<inkanimDefinition> Dots_show
		{
			get => GetProperty(ref _dots_show);
			set => SetProperty(ref _dots_show, value);
		}

		[Ordinal(35)] 
		[RED("dots_hide")] 
		public CHandle<inkanimDefinition> Dots_hide
		{
			get => GetProperty(ref _dots_hide);
			set => SetProperty(ref _dots_hide, value);
		}

		[Ordinal(36)] 
		[RED("BorderAnimProxy")] 
		public CHandle<inkanimProxy> BorderAnimProxy
		{
			get => GetProperty(ref _borderAnimProxy);
			set => SetProperty(ref _borderAnimProxy, value);
		}

		[Ordinal(37)] 
		[RED("soundFinishedOn")] 
		public CName SoundFinishedOn
		{
			get => GetProperty(ref _soundFinishedOn);
			set => SetProperty(ref _soundFinishedOn, value);
		}

		[Ordinal(38)] 
		[RED("soundFinishedOff")] 
		public CName SoundFinishedOff
		{
			get => GetProperty(ref _soundFinishedOff);
			set => SetProperty(ref _soundFinishedOff, value);
		}

		[Ordinal(39)] 
		[RED("playerSpawnedCallbackID")] 
		public CUInt32 PlayerSpawnedCallbackID
		{
			get => GetProperty(ref _playerSpawnedCallbackID);
			set => SetProperty(ref _playerSpawnedCallbackID, value);
		}

		[Ordinal(40)] 
		[RED("BBID_IsEnabledChange")] 
		public CUInt32 BBID_IsEnabledChange
		{
			get => GetProperty(ref _bBID_IsEnabledChange);
			set => SetProperty(ref _bBID_IsEnabledChange, value);
		}

		[Ordinal(41)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(42)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetProperty(ref _isShown);
			set => SetProperty(ref _isShown, value);
		}

		[Ordinal(43)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		public gameuiScannerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiScannerGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("currentTarget")] 
		public entEntityID CurrentTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(10)] 
		[RED("scanLock")] 
		public CBool ScanLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("percentValue")] 
		public CFloat PercentValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("oldPercentValue")] 
		public CFloat OldPercentValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("bbWeaponInfo")] 
		public CWeakHandle<gameIBlackboard> BbWeaponInfo
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(14)] 
		[RED("BraindanceBB")] 
		public CWeakHandle<gameIBlackboard> BraindanceBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(15)] 
		[RED("bbWeaponEventId")] 
		public CHandle<redCallbackObject> BbWeaponEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("BBID_BraindanceActive")] 
		public CHandle<redCallbackObject> BBID_BraindanceActive
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("scannerscannerObjectStatsId")] 
		public CHandle<redCallbackObject> ScannerscannerObjectStatsId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("scannerScannablesId")] 
		public CHandle<redCallbackObject> ScannerScannablesId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("scannerCurrentProgressId")] 
		public CHandle<redCallbackObject> ScannerCurrentProgressId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("scannerCurrentStateId")] 
		public CHandle<redCallbackObject> ScannerCurrentStateId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("scannerScannedObjectId")] 
		public CHandle<redCallbackObject> ScannerScannedObjectId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(22)] 
		[RED("scannerData")] 
		public scannerDataStructure ScannerData
		{
			get => GetPropertyValue<scannerDataStructure>();
			set => SetPropertyValue<scannerDataStructure>(value);
		}

		[Ordinal(23)] 
		[RED("curObj")] 
		public GameObjectScanStats CurObj
		{
			get => GetPropertyValue<GameObjectScanStats>();
			set => SetPropertyValue<GameObjectScanStats>(value);
		}

		[Ordinal(24)] 
		[RED("scannerBorderMain")] 
		public CWeakHandle<inkCompoundWidget> ScannerBorderMain
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(25)] 
		[RED("scannerBorderController")] 
		public CWeakHandle<scannerBorderLogicController> ScannerBorderController
		{
			get => GetPropertyValue<CWeakHandle<scannerBorderLogicController>>();
			set => SetPropertyValue<CWeakHandle<scannerBorderLogicController>>(value);
		}

		[Ordinal(26)] 
		[RED("scannerProgressMain")] 
		public CWeakHandle<inkCompoundWidget> ScannerProgressMain
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("scannerFullScreenOverlay")] 
		public CWeakHandle<inkWidget> ScannerFullScreenOverlay
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(28)] 
		[RED("center_frame")] 
		public CWeakHandle<inkImageWidget> Center_frame
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(29)] 
		[RED("squares")] 
		public CArray<CWeakHandle<inkImageWidget>> Squares
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkImageWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkImageWidget>>>(value);
		}

		[Ordinal(30)] 
		[RED("squaresFilled")] 
		public CArray<CWeakHandle<inkImageWidget>> SquaresFilled
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkImageWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkImageWidget>>>(value);
		}

		[Ordinal(31)] 
		[RED("isUnarmed")] 
		public CBool IsUnarmed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("isFinish")] 
		public CBool IsFinish
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("isBraindanceActive")] 
		public CBool IsBraindanceActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("border_show")] 
		public CHandle<inkanimDefinition> Border_show
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(37)] 
		[RED("center_show")] 
		public CHandle<inkanimDefinition> Center_show
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(38)] 
		[RED("center_hide")] 
		public CHandle<inkanimDefinition> Center_hide
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(39)] 
		[RED("dots_show")] 
		public CHandle<inkanimDefinition> Dots_show
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(40)] 
		[RED("dots_hide")] 
		public CHandle<inkanimDefinition> Dots_hide
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(41)] 
		[RED("BorderAnimProxy")] 
		public CHandle<inkanimProxy> BorderAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(42)] 
		[RED("soundFinishedOn")] 
		public CName SoundFinishedOn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(43)] 
		[RED("soundFinishedOff")] 
		public CName SoundFinishedOff
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(44)] 
		[RED("playerSpawnedCallbackID")] 
		public CUInt32 PlayerSpawnedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(45)] 
		[RED("BBID_IsEnabledChange")] 
		public CHandle<redCallbackObject> BBID_IsEnabledChange
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(46)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(47)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public gameuiScannerGameController()
		{
			CurrentTarget = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

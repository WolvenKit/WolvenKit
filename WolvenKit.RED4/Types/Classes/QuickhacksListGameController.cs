using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickhacksListGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("timeBetweenIntroAndIntroDescription")] 
		public CFloat TimeBetweenIntroAndIntroDescription
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("timeBetweenIntroAndDescritpionDelayID")] 
		public gameDelayID TimeBetweenIntroAndDescritpionDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(11)] 
		[RED("timeBetweenIntroAndDescritpionCheck")] 
		public CBool TimeBetweenIntroAndDescritpionCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("introDescriptionAnimProxy")] 
		public CHandle<inkanimProxy> IntroDescriptionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(13)] 
		[RED("middleDots")] 
		public inkWidgetReference MiddleDots
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("memoryWidget")] 
		public inkWidgetReference MemoryWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("avaliableMemory")] 
		public inkTextWidgetReference AvaliableMemory
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("listWidget")] 
		public inkWidgetReference ListWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("noQuickhacks")] 
		public inkCompoundWidgetReference NoQuickhacks
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("openCyberdeckBtn")] 
		public inkWidgetReference OpenCyberdeckBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("executeBtn")] 
		public inkWidgetReference ExecuteBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("executeAndCloseBtn")] 
		public inkWidgetReference ExecuteAndCloseBtn
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("changeTarget")] 
		public inkWidgetReference ChangeTarget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("tutorialButton")] 
		public inkWidgetReference TutorialButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("rightPanel")] 
		public inkWidgetReference RightPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("networkBreach")] 
		public inkWidgetReference NetworkBreach
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("costReductionPanel")] 
		public inkWidgetReference CostReductionPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("costReductionText")] 
		public inkTextWidgetReference CostReductionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("costReductionValue")] 
		public inkTextWidgetReference CostReductionValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("targetName")] 
		public inkTextWidgetReference TargetName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("icePanel")] 
		public inkWidgetReference IcePanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("iceValue")] 
		public inkTextWidgetReference IceValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("vulnerabilitiesPanel")] 
		public inkWidgetReference VulnerabilitiesPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("vulnerabilityFields")] 
		public CArray<inkWidgetReference> VulnerabilityFields
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(33)] 
		[RED("subHeader")] 
		public inkTextWidgetReference SubHeader
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("tier")] 
		public inkTextWidgetReference Tier
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("recompileTimer")] 
		public inkTextWidgetReference RecompileTimer
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("damage")] 
		public inkTextWidgetReference Damage
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("duration")] 
		public inkTextWidgetReference Duration
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("cooldown")] 
		public inkTextWidgetReference Cooldown
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("uploadTime")] 
		public inkTextWidgetReference UploadTime
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("memoryCost")] 
		public inkTextWidgetReference MemoryCost
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("memoryRawCost")] 
		public inkTextWidgetReference MemoryRawCost
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("warningWidget")] 
		public inkWidgetReference WarningWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("warningText")] 
		public inkTextWidgetReference WarningText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("recompilePanel")] 
		public inkWidgetReference RecompilePanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("recompileText")] 
		public inkTextWidgetReference RecompileText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("isUILocked")] 
		public CBool IsUILocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(49)] 
		[RED("visionModeSystem")] 
		public CWeakHandle<gameVisionModeSystem> VisionModeSystem
		{
			get => GetPropertyValue<CWeakHandle<gameVisionModeSystem>>();
			set => SetPropertyValue<CWeakHandle<gameVisionModeSystem>>(value);
		}

		[Ordinal(50)] 
		[RED("scanningCtrl")] 
		public CWeakHandle<gameScanningController> ScanningCtrl
		{
			get => GetPropertyValue<CWeakHandle<gameScanningController>>();
			set => SetPropertyValue<CWeakHandle<gameScanningController>>(value);
		}

		[Ordinal(51)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(52)] 
		[RED("contextHelpOverlay")] 
		public CBool ContextHelpOverlay
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("quickHackDescriptionVisibility")] 
		public CUInt32 QuickHackDescriptionVisibility
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(54)] 
		[RED("buffListListener")] 
		public CHandle<redCallbackObject> BuffListListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(55)] 
		[RED("memoryBoard")] 
		public CWeakHandle<gameIBlackboard> MemoryBoard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(56)] 
		[RED("memoryBoardDef")] 
		public CHandle<UI_PlayerBioMonitorDef> MemoryBoardDef
		{
			get => GetPropertyValue<CHandle<UI_PlayerBioMonitorDef>>();
			set => SetPropertyValue<CHandle<UI_PlayerBioMonitorDef>>(value);
		}

		[Ordinal(57)] 
		[RED("memoryPercentListener")] 
		public CHandle<redCallbackObject> MemoryPercentListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(58)] 
		[RED("quickhackBarArray")] 
		public CArray<CWeakHandle<inkCompoundWidget>> QuickhackBarArray
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkCompoundWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkCompoundWidget>>>(value);
		}

		[Ordinal(59)] 
		[RED("maxQuickhackBars")] 
		public CInt32 MaxQuickhackBars
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(60)] 
		[RED("listController")] 
		public CWeakHandle<inkListController> ListController
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(61)] 
		[RED("data")] 
		public CArray<CHandle<QuickhackData>> Data
		{
			get => GetPropertyValue<CArray<CHandle<QuickhackData>>>();
			set => SetPropertyValue<CArray<CHandle<QuickhackData>>>(value);
		}

		[Ordinal(62)] 
		[RED("selectedData")] 
		public CHandle<QuickhackData> SelectedData
		{
			get => GetPropertyValue<CHandle<QuickhackData>>();
			set => SetPropertyValue<CHandle<QuickhackData>>(value);
		}

		[Ordinal(63)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("memorySpendAnimation")] 
		public CHandle<inkanimProxy> MemorySpendAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(65)] 
		[RED("memorySpendCounter")] 
		public CInt32 MemorySpendCounter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(66)] 
		[RED("memorySpendIndex")] 
		public CInt32 MemorySpendIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(67)] 
		[RED("selectedMemoryLoop")] 
		public CArray<CHandle<inkanimProxy>> SelectedMemoryLoop
		{
			get => GetPropertyValue<CArray<CHandle<inkanimProxy>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimProxy>>>(value);
		}

		[Ordinal(68)] 
		[RED("inkIntroAnimProxy")] 
		public CHandle<inkanimProxy> InkIntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(69)] 
		[RED("inkVulnerabilityAnimProxy")] 
		public CHandle<inkanimProxy> InkVulnerabilityAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(70)] 
		[RED("inkWarningAnimProxy")] 
		public CHandle<inkanimProxy> InkWarningAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(71)] 
		[RED("inkRecompileAnimProxy")] 
		public CHandle<inkanimProxy> InkRecompileAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(72)] 
		[RED("inkReductionAnimProxy")] 
		public CHandle<inkanimProxy> InkReductionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(73)] 
		[RED("HACK_wasPlayedOnTarget")] 
		public CBool HACK_wasPlayedOnTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(74)] 
		[RED("inkMemoryWarningTransitionAnimProxy")] 
		public CHandle<inkanimProxy> InkMemoryWarningTransitionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(75)] 
		[RED("lastMemoryWarningTransitionAnimName")] 
		public CName LastMemoryWarningTransitionAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(76)] 
		[RED("hasActiveUpload")] 
		public CBool HasActiveUpload
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(77)] 
		[RED("lastCompiledTarget")] 
		public entEntityID LastCompiledTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(78)] 
		[RED("statPoolListenersIndexes")] 
		public CArray<CInt32> StatPoolListenersIndexes
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(79)] 
		[RED("chunkBlackboard")] 
		public CWeakHandle<gameIBlackboard> ChunkBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(80)] 
		[RED("nameCallbackID")] 
		public CHandle<redCallbackObject> NameCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(81)] 
		[RED("uiScannerChangeTargetTooltipVisibilityCallback")] 
		public CHandle<redCallbackObject> UiScannerChangeTargetTooltipVisibilityCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(82)] 
		[RED("lastFillCells")] 
		public CInt32 LastFillCells
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(83)] 
		[RED("lastUsedCells")] 
		public CInt32 LastUsedCells
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(84)] 
		[RED("lastMaxCells")] 
		public CInt32 LastMaxCells
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(85)] 
		[RED("axisInputConsumed")] 
		public CBool AxisInputConsumed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(86)] 
		[RED("playerObject")] 
		public CWeakHandle<gameObject> PlayerObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public QuickhacksListGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

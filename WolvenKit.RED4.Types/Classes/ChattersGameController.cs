using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChattersGameController : BaseSubtitlesGameController
	{
		private CFloat _c_DisplayRange;
		private CFloat _c_CloseDisplayRange;
		private CFloat _c_TimeToUnblockSec;
		private CWeakHandle<inkCompoundWidget> _rootWidget;
		private CArray<ChatterKeyValuePair> _allControllers;
		private CHandle<gametargetingTargetingSystem> _targetingSystem;
		private CArray<CRUID> _broadcastBlockingLines;
		private CBool _playerInDialogChoice;
		private EngineTime _lastBroadcastBlockingLineTime;
		private EngineTime _lastChoiceTime;
		private CHandle<redCallbackObject> _bbPSceneTierEventId;
		private CInt32 _sceneTier;
		private CHandle<redCallbackObject> _onNameplateEntityChangedCallback;
		private CHandle<redCallbackObject> _onNameplateOffsetChangedCallback;
		private CHandle<redCallbackObject> _onNameplateVisibilityChangedCallback;
		private CHandle<redCallbackObject> _onScannerModeChangedCallback;
		private CHandle<redCallbackObject> _onOnDialogsDataCallback;

		[Ordinal(29)] 
		[RED("c_DisplayRange")] 
		public CFloat C_DisplayRange
		{
			get => GetProperty(ref _c_DisplayRange);
			set => SetProperty(ref _c_DisplayRange, value);
		}

		[Ordinal(30)] 
		[RED("c_CloseDisplayRange")] 
		public CFloat C_CloseDisplayRange
		{
			get => GetProperty(ref _c_CloseDisplayRange);
			set => SetProperty(ref _c_CloseDisplayRange, value);
		}

		[Ordinal(31)] 
		[RED("c_TimeToUnblockSec")] 
		public CFloat C_TimeToUnblockSec
		{
			get => GetProperty(ref _c_TimeToUnblockSec);
			set => SetProperty(ref _c_TimeToUnblockSec, value);
		}

		[Ordinal(32)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(33)] 
		[RED("AllControllers")] 
		public CArray<ChatterKeyValuePair> AllControllers
		{
			get => GetProperty(ref _allControllers);
			set => SetProperty(ref _allControllers, value);
		}

		[Ordinal(34)] 
		[RED("targetingSystem")] 
		public CHandle<gametargetingTargetingSystem> TargetingSystem
		{
			get => GetProperty(ref _targetingSystem);
			set => SetProperty(ref _targetingSystem, value);
		}

		[Ordinal(35)] 
		[RED("broadcastBlockingLines")] 
		public CArray<CRUID> BroadcastBlockingLines
		{
			get => GetProperty(ref _broadcastBlockingLines);
			set => SetProperty(ref _broadcastBlockingLines, value);
		}

		[Ordinal(36)] 
		[RED("playerInDialogChoice")] 
		public CBool PlayerInDialogChoice
		{
			get => GetProperty(ref _playerInDialogChoice);
			set => SetProperty(ref _playerInDialogChoice, value);
		}

		[Ordinal(37)] 
		[RED("lastBroadcastBlockingLineTime")] 
		public EngineTime LastBroadcastBlockingLineTime
		{
			get => GetProperty(ref _lastBroadcastBlockingLineTime);
			set => SetProperty(ref _lastBroadcastBlockingLineTime, value);
		}

		[Ordinal(38)] 
		[RED("lastChoiceTime")] 
		public EngineTime LastChoiceTime
		{
			get => GetProperty(ref _lastChoiceTime);
			set => SetProperty(ref _lastChoiceTime, value);
		}

		[Ordinal(39)] 
		[RED("bbPSceneTierEventId")] 
		public CHandle<redCallbackObject> BbPSceneTierEventId
		{
			get => GetProperty(ref _bbPSceneTierEventId);
			set => SetProperty(ref _bbPSceneTierEventId, value);
		}

		[Ordinal(40)] 
		[RED("sceneTier")] 
		public CInt32 SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(41)] 
		[RED("OnNameplateEntityChangedCallback")] 
		public CHandle<redCallbackObject> OnNameplateEntityChangedCallback
		{
			get => GetProperty(ref _onNameplateEntityChangedCallback);
			set => SetProperty(ref _onNameplateEntityChangedCallback, value);
		}

		[Ordinal(42)] 
		[RED("OnNameplateOffsetChangedCallback")] 
		public CHandle<redCallbackObject> OnNameplateOffsetChangedCallback
		{
			get => GetProperty(ref _onNameplateOffsetChangedCallback);
			set => SetProperty(ref _onNameplateOffsetChangedCallback, value);
		}

		[Ordinal(43)] 
		[RED("OnNameplateVisibilityChangedCallback")] 
		public CHandle<redCallbackObject> OnNameplateVisibilityChangedCallback
		{
			get => GetProperty(ref _onNameplateVisibilityChangedCallback);
			set => SetProperty(ref _onNameplateVisibilityChangedCallback, value);
		}

		[Ordinal(44)] 
		[RED("OnScannerModeChangedCallback")] 
		public CHandle<redCallbackObject> OnScannerModeChangedCallback
		{
			get => GetProperty(ref _onScannerModeChangedCallback);
			set => SetProperty(ref _onScannerModeChangedCallback, value);
		}

		[Ordinal(45)] 
		[RED("OnOnDialogsDataCallback")] 
		public CHandle<redCallbackObject> OnOnDialogsDataCallback
		{
			get => GetProperty(ref _onOnDialogsDataCallback);
			set => SetProperty(ref _onOnDialogsDataCallback, value);
		}
	}
}

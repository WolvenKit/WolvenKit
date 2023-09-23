using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChattersGameController : BaseSubtitlesGameController
	{
		[Ordinal(30)] 
		[RED("c_DisplayRange")] 
		public CFloat C_DisplayRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("c_CloseDisplayRange")] 
		public CFloat C_CloseDisplayRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("c_TimeToUnblockSec")] 
		public CFloat C_TimeToUnblockSec
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(34)] 
		[RED("AllControllers")] 
		public CArray<ChatterKeyValuePair> AllControllers
		{
			get => GetPropertyValue<CArray<ChatterKeyValuePair>>();
			set => SetPropertyValue<CArray<ChatterKeyValuePair>>(value);
		}

		[Ordinal(35)] 
		[RED("targetingSystem")] 
		public CHandle<gametargetingTargetingSystem> TargetingSystem
		{
			get => GetPropertyValue<CHandle<gametargetingTargetingSystem>>();
			set => SetPropertyValue<CHandle<gametargetingTargetingSystem>>(value);
		}

		[Ordinal(36)] 
		[RED("broadcastBlockingLines")] 
		public CArray<CRUID> BroadcastBlockingLines
		{
			get => GetPropertyValue<CArray<CRUID>>();
			set => SetPropertyValue<CArray<CRUID>>(value);
		}

		[Ordinal(37)] 
		[RED("playerInDialogChoice")] 
		public CBool PlayerInDialogChoice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("lastBroadcastBlockingLineTime")] 
		public EngineTime LastBroadcastBlockingLineTime
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		[Ordinal(39)] 
		[RED("lastChoiceTime")] 
		public EngineTime LastChoiceTime
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		[Ordinal(40)] 
		[RED("bbPSceneTierEventId")] 
		public CHandle<redCallbackObject> BbPSceneTierEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(41)] 
		[RED("sceneTier")] 
		public CInt32 SceneTier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(42)] 
		[RED("OnNameplateEntityChangedCallback")] 
		public CHandle<redCallbackObject> OnNameplateEntityChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(43)] 
		[RED("OnNameplateOffsetChangedCallback")] 
		public CHandle<redCallbackObject> OnNameplateOffsetChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(44)] 
		[RED("OnNameplateVisibilityChangedCallback")] 
		public CHandle<redCallbackObject> OnNameplateVisibilityChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(45)] 
		[RED("OnScannerModeChangedCallback")] 
		public CHandle<redCallbackObject> OnScannerModeChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(46)] 
		[RED("OnOnDialogsDataCallback")] 
		public CHandle<redCallbackObject> OnOnDialogsDataCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public ChattersGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

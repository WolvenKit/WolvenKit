using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDManager : gameNativeHudManager
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<HUDState> State
		{
			get => GetPropertyValue<CEnum<HUDState>>();
			set => SetPropertyValue<CEnum<HUDState>>(value);
		}

		[Ordinal(1)] 
		[RED("activeMode")] 
		public CEnum<ActiveMode> ActiveMode
		{
			get => GetPropertyValue<CEnum<ActiveMode>>();
			set => SetPropertyValue<CEnum<ActiveMode>>(value);
		}

		[Ordinal(2)] 
		[RED("instructionsDelayID")] 
		public gameDelayID InstructionsDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(3)] 
		[RED("isBraindanceActive")] 
		public CBool IsBraindanceActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("modulesArray")] 
		public CArray<CHandle<HUDModule>> ModulesArray
		{
			get => GetPropertyValue<CArray<CHandle<HUDModule>>>();
			set => SetPropertyValue<CArray<CHandle<HUDModule>>>(value);
		}

		[Ordinal(5)] 
		[RED("scanner")] 
		public CHandle<ScannerModule> Scanner
		{
			get => GetPropertyValue<CHandle<ScannerModule>>();
			set => SetPropertyValue<CHandle<ScannerModule>>(value);
		}

		[Ordinal(6)] 
		[RED("braindanceModule")] 
		public CHandle<BraindanceModule> BraindanceModule
		{
			get => GetPropertyValue<CHandle<BraindanceModule>>();
			set => SetPropertyValue<CHandle<BraindanceModule>>(value);
		}

		[Ordinal(7)] 
		[RED("highlightsModule")] 
		public CHandle<HighlightModule> HighlightsModule
		{
			get => GetPropertyValue<CHandle<HighlightModule>>();
			set => SetPropertyValue<CHandle<HighlightModule>>(value);
		}

		[Ordinal(8)] 
		[RED("iconsModule")] 
		public CHandle<IconsModule> IconsModule
		{
			get => GetPropertyValue<CHandle<IconsModule>>();
			set => SetPropertyValue<CHandle<IconsModule>>(value);
		}

		[Ordinal(9)] 
		[RED("crosshair")] 
		public CHandle<CrosshairModule> Crosshair
		{
			get => GetPropertyValue<CHandle<CrosshairModule>>();
			set => SetPropertyValue<CHandle<CrosshairModule>>(value);
		}

		[Ordinal(10)] 
		[RED("aimAssist")] 
		public CHandle<AimAssistModule> AimAssist
		{
			get => GetPropertyValue<CHandle<AimAssistModule>>();
			set => SetPropertyValue<CHandle<AimAssistModule>>(value);
		}

		[Ordinal(11)] 
		[RED("quickhackModule")] 
		public CHandle<QuickhackModule> QuickhackModule
		{
			get => GetPropertyValue<CHandle<QuickhackModule>>();
			set => SetPropertyValue<CHandle<QuickhackModule>>(value);
		}

		[Ordinal(12)] 
		[RED("lastTarget")] 
		public CWeakHandle<gameHudActor> LastTarget
		{
			get => GetPropertyValue<CWeakHandle<gameHudActor>>();
			set => SetPropertyValue<CWeakHandle<gameHudActor>>(value);
		}

		[Ordinal(13)] 
		[RED("currentTarget")] 
		public CWeakHandle<gameHudActor> CurrentTarget
		{
			get => GetPropertyValue<CWeakHandle<gameHudActor>>();
			set => SetPropertyValue<CWeakHandle<gameHudActor>>(value);
		}

		[Ordinal(14)] 
		[RED("lookAtTarget")] 
		public entEntityID LookAtTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(15)] 
		[RED("scannerTarget")] 
		public entEntityID ScannerTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(16)] 
		[RED("nameplateTarget")] 
		public entEntityID NameplateTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(17)] 
		[RED("quickHackTarget")] 
		public entEntityID QuickHackTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(18)] 
		[RED("lootedTarget")] 
		public entEntityID LootedTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(19)] 
		[RED("scannningController")] 
		public CWeakHandle<gameScanningController> ScannningController
		{
			get => GetPropertyValue<CWeakHandle<gameScanningController>>();
			set => SetPropertyValue<CWeakHandle<gameScanningController>>(value);
		}

		[Ordinal(20)] 
		[RED("uiScannerVisible")] 
		public CBool UiScannerVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("uiQuickHackVisible")] 
		public CBool UiQuickHackVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("uiQuickHackKeepContext")] 
		public CBool UiQuickHackKeepContext
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("quickHackDescriptionVisible")] 
		public CBool QuickHackDescriptionVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("targetingSystem")] 
		public CWeakHandle<gametargetingTargetingSystem> TargetingSystem
		{
			get => GetPropertyValue<CWeakHandle<gametargetingTargetingSystem>>();
			set => SetPropertyValue<CWeakHandle<gametargetingTargetingSystem>>(value);
		}

		[Ordinal(25)] 
		[RED("visionModeSystem")] 
		public CWeakHandle<gameVisionModeSystem> VisionModeSystem
		{
			get => GetPropertyValue<CWeakHandle<gameVisionModeSystem>>();
			set => SetPropertyValue<CWeakHandle<gameVisionModeSystem>>(value);
		}

		[Ordinal(26)] 
		[RED("isHackingMinigameActive")] 
		public CBool IsHackingMinigameActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("stickInputListener")] 
		public CHandle<redCallbackObject> StickInputListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("quickHackPanelListener")] 
		public CHandle<redCallbackObject> QuickHackPanelListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("carriedBodyListener")] 
		public CHandle<redCallbackObject> CarriedBodyListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("grappleListener")] 
		public CHandle<redCallbackObject> GrappleListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("lookatRequest")] 
		public gameaimAssistAimRequest LookatRequest
		{
			get => GetPropertyValue<gameaimAssistAimRequest>();
			set => SetPropertyValue<gameaimAssistAimRequest>(value);
		}

		[Ordinal(32)] 
		[RED("isQHackUIInputLocked")] 
		public CBool IsQHackUIInputLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(34)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(35)] 
		[RED("playerTargetCallbackID")] 
		public CHandle<redCallbackObject> PlayerTargetCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("braindanceToggleCallbackID")] 
		public CHandle<redCallbackObject> BraindanceToggleCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(37)] 
		[RED("nameplateCallbackID")] 
		public CHandle<redCallbackObject> NameplateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(38)] 
		[RED("visionModeChangedCallbackID")] 
		public CHandle<redCallbackObject> VisionModeChangedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(39)] 
		[RED("scannerTargetCallbackID")] 
		public CHandle<redCallbackObject> ScannerTargetCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(40)] 
		[RED("hackingMinigameCallbackID")] 
		public CHandle<redCallbackObject> HackingMinigameCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(41)] 
		[RED("uiScannerVisibleCallbackID")] 
		public CHandle<redCallbackObject> UiScannerVisibleCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("uiQuickHackVisibleCallbackID")] 
		public CHandle<redCallbackObject> UiQuickHackVisibleCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(43)] 
		[RED("uiQuickhackKeepContextCallbackID")] 
		public CHandle<redCallbackObject> UiQuickhackKeepContextCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(44)] 
		[RED("lootDataCallbackID")] 
		public CHandle<redCallbackObject> LootDataCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(45)] 
		[RED("pulseDelayID")] 
		public gameDelayID PulseDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(46)] 
		[RED("previousStickInput")] 
		public Vector4 PreviousStickInput
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public HUDManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

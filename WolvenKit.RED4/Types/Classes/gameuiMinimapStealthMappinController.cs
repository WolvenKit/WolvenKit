using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapStealthMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("visionConeWidget")] 
		public inkImageWidgetReference VisionConeWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("stealthMappin")] 
		public CWeakHandle<gamemappinsStealthMappin> StealthMappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsStealthMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsStealthMappin>>(value);
		}

		[Ordinal(17)] 
		[RED("fadeOutAnim")] 
		public CHandle<inkanimProxy> FadeOutAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("wasVisible")] 
		public CBool WasVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("attitudeState")] 
		public CName AttitudeState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("preventionState")] 
		public CName PreventionState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("pulsing")] 
		public CBool Pulsing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("hasBeenLooted")] 
		public CBool HasBeenLooted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("isAggressive")] 
		public CBool IsAggressive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("detectionAboveZero")] 
		public CBool DetectionAboveZero
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("wasAlive")] 
		public CBool WasAlive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("wasCompanion")] 
		public CBool WasCompanion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("couldSeePlayer")] 
		public CBool CouldSeePlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("isPrevention")] 
		public CBool IsPrevention
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("isCrowdNPC")] 
		public CBool IsCrowdNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("cautious")] 
		public CBool Cautious
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("shouldShowVisionCone")] 
		public CBool ShouldShowVisionCone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("isCamera")] 
		public CBool IsCamera
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("isTurret")] 
		public CBool IsTurret
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("isNetrunner")] 
		public CBool IsNetrunner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("isHacking")] 
		public CBool IsHacking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("isSquadInCombat")] 
		public CBool IsSquadInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("wasSquadInCombat")] 
		public CBool WasSquadInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("clampingAvailable")] 
		public CBool ClampingAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("defaultOpacity")] 
		public CFloat DefaultOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("adjustedOpacity")] 
		public CFloat AdjustedOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("defaultConeOpacity")] 
		public CFloat DefaultConeOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("detectingConeOpacity")] 
		public CFloat DetectingConeOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(46)] 
		[RED("numberOfShotAttempts")] 
		public CUInt32 NumberOfShotAttempts
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(47)] 
		[RED("highestLootQuality")] 
		public CUInt32 HighestLootQuality
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(48)] 
		[RED("lockLootQuality")] 
		public CBool LockLootQuality
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(50)] 
		[RED("iconWidgetGlitch")] 
		public CWeakHandle<inkWidget> IconWidgetGlitch
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(51)] 
		[RED("visionConeWidgetGlitch")] 
		public CWeakHandle<inkWidget> VisionConeWidgetGlitch
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(52)] 
		[RED("clampArrowWidgetGlitch")] 
		public CWeakHandle<inkWidget> ClampArrowWidgetGlitch
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(53)] 
		[RED("puppetStateBlackboard")] 
		public CWeakHandle<gameIBlackboard> PuppetStateBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(54)] 
		[RED("isInVehicleStance")] 
		public CBool IsInVehicleStance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("stanceStateCb")] 
		public CHandle<redCallbackObject> StanceStateCb
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(56)] 
		[RED("policeChasePrototypeEnabled")] 
		public CBool PoliceChasePrototypeEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("showAnim")] 
		public CHandle<inkanimProxy> ShowAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(58)] 
		[RED("alertedAnim")] 
		public CHandle<inkanimProxy> AlertedAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(59)] 
		[RED("preventionAnimProxy")] 
		public CHandle<inkanimProxy> PreventionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public gameuiMinimapStealthMappinController()
		{
			VisionConeWidget = new();
			PulseWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

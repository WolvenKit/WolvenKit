using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapStealthMappinController : gameuiBaseMinimapMappinController
	{
		private inkImageWidgetReference _visionConeWidget;
		private inkWidgetReference _pulseWidget;
		private wCHandle<gamemappinsStealthMappin> _stealthMappin;
		private CHandle<inkanimProxy> _fadeOutAnim;
		private CBool _isTagged;
		private CBool _wasVisible;
		private CName _attitudeState;
		private CName _preventionState;
		private CBool _pulsing;
		private CBool _hasBeenLooted;
		private CBool _isAggressive;
		private CBool _detectionAboveZero;
		private CBool _isAlive;
		private CBool _wasAlive;
		private CBool _wasCompanion;
		private CBool _couldSeePlayer;
		private CBool _isPrevention;
		private CBool _isCrowdNPC;
		private CBool _cautious;
		private CBool _shouldShowVisionCone;
		private CBool _isDevice;
		private CBool _isCamera;
		private CBool _isTurret;
		private CBool _isNetrunner;
		private CBool _isHacking;
		private CBool _isSquadInCombat;
		private CBool _wasSquadInCombat;
		private CBool _clampingAvailable;
		private CFloat _defaultOpacity;
		private CFloat _adjustedOpacity;
		private CFloat _defaultConeOpacity;
		private CFloat _detectingConeOpacity;
		private CUInt32 _numberOfShotAttempts;
		private CUInt32 _highestLootQuality;
		private CBool _lockLootQuality;
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private wCHandle<inkWidget> _iconWidgetGlitch;
		private wCHandle<inkWidget> _visionConeWidgetGlitch;
		private wCHandle<inkWidget> _clampArrowWidgetGlitch;
		private CHandle<inkanimProxy> _showAnim;
		private CHandle<inkanimProxy> _alertedAnim;
		private CHandle<inkanimProxy> _preventionAnimProxy;

		[Ordinal(14)] 
		[RED("visionConeWidget")] 
		public inkImageWidgetReference VisionConeWidget
		{
			get => GetProperty(ref _visionConeWidget);
			set => SetProperty(ref _visionConeWidget, value);
		}

		[Ordinal(15)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get => GetProperty(ref _pulseWidget);
			set => SetProperty(ref _pulseWidget, value);
		}

		[Ordinal(16)] 
		[RED("stealthMappin")] 
		public wCHandle<gamemappinsStealthMappin> StealthMappin
		{
			get => GetProperty(ref _stealthMappin);
			set => SetProperty(ref _stealthMappin, value);
		}

		[Ordinal(17)] 
		[RED("fadeOutAnim")] 
		public CHandle<inkanimProxy> FadeOutAnim
		{
			get => GetProperty(ref _fadeOutAnim);
			set => SetProperty(ref _fadeOutAnim, value);
		}

		[Ordinal(18)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetProperty(ref _isTagged);
			set => SetProperty(ref _isTagged, value);
		}

		[Ordinal(19)] 
		[RED("wasVisible")] 
		public CBool WasVisible
		{
			get => GetProperty(ref _wasVisible);
			set => SetProperty(ref _wasVisible, value);
		}

		[Ordinal(20)] 
		[RED("attitudeState")] 
		public CName AttitudeState
		{
			get => GetProperty(ref _attitudeState);
			set => SetProperty(ref _attitudeState, value);
		}

		[Ordinal(21)] 
		[RED("preventionState")] 
		public CName PreventionState
		{
			get => GetProperty(ref _preventionState);
			set => SetProperty(ref _preventionState, value);
		}

		[Ordinal(22)] 
		[RED("pulsing")] 
		public CBool Pulsing
		{
			get => GetProperty(ref _pulsing);
			set => SetProperty(ref _pulsing, value);
		}

		[Ordinal(23)] 
		[RED("hasBeenLooted")] 
		public CBool HasBeenLooted
		{
			get => GetProperty(ref _hasBeenLooted);
			set => SetProperty(ref _hasBeenLooted, value);
		}

		[Ordinal(24)] 
		[RED("isAggressive")] 
		public CBool IsAggressive
		{
			get => GetProperty(ref _isAggressive);
			set => SetProperty(ref _isAggressive, value);
		}

		[Ordinal(25)] 
		[RED("detectionAboveZero")] 
		public CBool DetectionAboveZero
		{
			get => GetProperty(ref _detectionAboveZero);
			set => SetProperty(ref _detectionAboveZero, value);
		}

		[Ordinal(26)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetProperty(ref _isAlive);
			set => SetProperty(ref _isAlive, value);
		}

		[Ordinal(27)] 
		[RED("wasAlive")] 
		public CBool WasAlive
		{
			get => GetProperty(ref _wasAlive);
			set => SetProperty(ref _wasAlive, value);
		}

		[Ordinal(28)] 
		[RED("wasCompanion")] 
		public CBool WasCompanion
		{
			get => GetProperty(ref _wasCompanion);
			set => SetProperty(ref _wasCompanion, value);
		}

		[Ordinal(29)] 
		[RED("couldSeePlayer")] 
		public CBool CouldSeePlayer
		{
			get => GetProperty(ref _couldSeePlayer);
			set => SetProperty(ref _couldSeePlayer, value);
		}

		[Ordinal(30)] 
		[RED("isPrevention")] 
		public CBool IsPrevention
		{
			get => GetProperty(ref _isPrevention);
			set => SetProperty(ref _isPrevention, value);
		}

		[Ordinal(31)] 
		[RED("isCrowdNPC")] 
		public CBool IsCrowdNPC
		{
			get => GetProperty(ref _isCrowdNPC);
			set => SetProperty(ref _isCrowdNPC, value);
		}

		[Ordinal(32)] 
		[RED("cautious")] 
		public CBool Cautious
		{
			get => GetProperty(ref _cautious);
			set => SetProperty(ref _cautious, value);
		}

		[Ordinal(33)] 
		[RED("shouldShowVisionCone")] 
		public CBool ShouldShowVisionCone
		{
			get => GetProperty(ref _shouldShowVisionCone);
			set => SetProperty(ref _shouldShowVisionCone, value);
		}

		[Ordinal(34)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get => GetProperty(ref _isDevice);
			set => SetProperty(ref _isDevice, value);
		}

		[Ordinal(35)] 
		[RED("isCamera")] 
		public CBool IsCamera
		{
			get => GetProperty(ref _isCamera);
			set => SetProperty(ref _isCamera, value);
		}

		[Ordinal(36)] 
		[RED("isTurret")] 
		public CBool IsTurret
		{
			get => GetProperty(ref _isTurret);
			set => SetProperty(ref _isTurret, value);
		}

		[Ordinal(37)] 
		[RED("isNetrunner")] 
		public CBool IsNetrunner
		{
			get => GetProperty(ref _isNetrunner);
			set => SetProperty(ref _isNetrunner, value);
		}

		[Ordinal(38)] 
		[RED("isHacking")] 
		public CBool IsHacking
		{
			get => GetProperty(ref _isHacking);
			set => SetProperty(ref _isHacking, value);
		}

		[Ordinal(39)] 
		[RED("isSquadInCombat")] 
		public CBool IsSquadInCombat
		{
			get => GetProperty(ref _isSquadInCombat);
			set => SetProperty(ref _isSquadInCombat, value);
		}

		[Ordinal(40)] 
		[RED("wasSquadInCombat")] 
		public CBool WasSquadInCombat
		{
			get => GetProperty(ref _wasSquadInCombat);
			set => SetProperty(ref _wasSquadInCombat, value);
		}

		[Ordinal(41)] 
		[RED("clampingAvailable")] 
		public CBool ClampingAvailable
		{
			get => GetProperty(ref _clampingAvailable);
			set => SetProperty(ref _clampingAvailable, value);
		}

		[Ordinal(42)] 
		[RED("defaultOpacity")] 
		public CFloat DefaultOpacity
		{
			get => GetProperty(ref _defaultOpacity);
			set => SetProperty(ref _defaultOpacity, value);
		}

		[Ordinal(43)] 
		[RED("adjustedOpacity")] 
		public CFloat AdjustedOpacity
		{
			get => GetProperty(ref _adjustedOpacity);
			set => SetProperty(ref _adjustedOpacity, value);
		}

		[Ordinal(44)] 
		[RED("defaultConeOpacity")] 
		public CFloat DefaultConeOpacity
		{
			get => GetProperty(ref _defaultConeOpacity);
			set => SetProperty(ref _defaultConeOpacity, value);
		}

		[Ordinal(45)] 
		[RED("detectingConeOpacity")] 
		public CFloat DetectingConeOpacity
		{
			get => GetProperty(ref _detectingConeOpacity);
			set => SetProperty(ref _detectingConeOpacity, value);
		}

		[Ordinal(46)] 
		[RED("numberOfShotAttempts")] 
		public CUInt32 NumberOfShotAttempts
		{
			get => GetProperty(ref _numberOfShotAttempts);
			set => SetProperty(ref _numberOfShotAttempts, value);
		}

		[Ordinal(47)] 
		[RED("highestLootQuality")] 
		public CUInt32 HighestLootQuality
		{
			get => GetProperty(ref _highestLootQuality);
			set => SetProperty(ref _highestLootQuality, value);
		}

		[Ordinal(48)] 
		[RED("lockLootQuality")] 
		public CBool LockLootQuality
		{
			get => GetProperty(ref _lockLootQuality);
			set => SetProperty(ref _lockLootQuality, value);
		}

		[Ordinal(49)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetProperty(ref _highLevelState);
			set => SetProperty(ref _highLevelState, value);
		}

		[Ordinal(50)] 
		[RED("iconWidgetGlitch")] 
		public wCHandle<inkWidget> IconWidgetGlitch
		{
			get => GetProperty(ref _iconWidgetGlitch);
			set => SetProperty(ref _iconWidgetGlitch, value);
		}

		[Ordinal(51)] 
		[RED("visionConeWidgetGlitch")] 
		public wCHandle<inkWidget> VisionConeWidgetGlitch
		{
			get => GetProperty(ref _visionConeWidgetGlitch);
			set => SetProperty(ref _visionConeWidgetGlitch, value);
		}

		[Ordinal(52)] 
		[RED("clampArrowWidgetGlitch")] 
		public wCHandle<inkWidget> ClampArrowWidgetGlitch
		{
			get => GetProperty(ref _clampArrowWidgetGlitch);
			set => SetProperty(ref _clampArrowWidgetGlitch, value);
		}

		[Ordinal(53)] 
		[RED("showAnim")] 
		public CHandle<inkanimProxy> ShowAnim
		{
			get => GetProperty(ref _showAnim);
			set => SetProperty(ref _showAnim, value);
		}

		[Ordinal(54)] 
		[RED("alertedAnim")] 
		public CHandle<inkanimProxy> AlertedAnim
		{
			get => GetProperty(ref _alertedAnim);
			set => SetProperty(ref _alertedAnim, value);
		}

		[Ordinal(55)] 
		[RED("preventionAnimProxy")] 
		public CHandle<inkanimProxy> PreventionAnimProxy
		{
			get => GetProperty(ref _preventionAnimProxy);
			set => SetProperty(ref _preventionAnimProxy, value);
		}

		public gameuiMinimapStealthMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

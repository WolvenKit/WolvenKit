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
		private CFloat _defaultOpacity;
		private CFloat _adjustedOpacity;
		private CFloat _defaultConeOpacity;
		private CFloat _detectingConeOpacity;
		private CUInt32 _numberOfShotAttempts;
		private CUInt32 _highestLootQuality;
		private CBool _lockLootQuality;
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private CHandle<inkWidget> _iconWidgetGlitch;
		private CHandle<inkWidget> _visionConeWidgetGlitch;
		private CHandle<inkWidget> _clampArrowWidgetGlitch;
		private CHandle<inkanimProxy> _showAnim;
		private CHandle<inkanimProxy> _alertedAnim;
		private CHandle<inkanimProxy> _preventionAnimProxy;

		[Ordinal(14)] 
		[RED("visionConeWidget")] 
		public inkImageWidgetReference VisionConeWidget
		{
			get
			{
				if (_visionConeWidget == null)
				{
					_visionConeWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "visionConeWidget", cr2w, this);
				}
				return _visionConeWidget;
			}
			set
			{
				if (_visionConeWidget == value)
				{
					return;
				}
				_visionConeWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get
			{
				if (_pulseWidget == null)
				{
					_pulseWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "pulseWidget", cr2w, this);
				}
				return _pulseWidget;
			}
			set
			{
				if (_pulseWidget == value)
				{
					return;
				}
				_pulseWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("stealthMappin")] 
		public wCHandle<gamemappinsStealthMappin> StealthMappin
		{
			get
			{
				if (_stealthMappin == null)
				{
					_stealthMappin = (wCHandle<gamemappinsStealthMappin>) CR2WTypeManager.Create("whandle:gamemappinsStealthMappin", "stealthMappin", cr2w, this);
				}
				return _stealthMappin;
			}
			set
			{
				if (_stealthMappin == value)
				{
					return;
				}
				_stealthMappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("fadeOutAnim")] 
		public CHandle<inkanimProxy> FadeOutAnim
		{
			get
			{
				if (_fadeOutAnim == null)
				{
					_fadeOutAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "fadeOutAnim", cr2w, this);
				}
				return _fadeOutAnim;
			}
			set
			{
				if (_fadeOutAnim == value)
				{
					return;
				}
				_fadeOutAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get
			{
				if (_isTagged == null)
				{
					_isTagged = (CBool) CR2WTypeManager.Create("Bool", "isTagged", cr2w, this);
				}
				return _isTagged;
			}
			set
			{
				if (_isTagged == value)
				{
					return;
				}
				_isTagged = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("wasVisible")] 
		public CBool WasVisible
		{
			get
			{
				if (_wasVisible == null)
				{
					_wasVisible = (CBool) CR2WTypeManager.Create("Bool", "wasVisible", cr2w, this);
				}
				return _wasVisible;
			}
			set
			{
				if (_wasVisible == value)
				{
					return;
				}
				_wasVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("attitudeState")] 
		public CName AttitudeState
		{
			get
			{
				if (_attitudeState == null)
				{
					_attitudeState = (CName) CR2WTypeManager.Create("CName", "attitudeState", cr2w, this);
				}
				return _attitudeState;
			}
			set
			{
				if (_attitudeState == value)
				{
					return;
				}
				_attitudeState = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("preventionState")] 
		public CName PreventionState
		{
			get
			{
				if (_preventionState == null)
				{
					_preventionState = (CName) CR2WTypeManager.Create("CName", "preventionState", cr2w, this);
				}
				return _preventionState;
			}
			set
			{
				if (_preventionState == value)
				{
					return;
				}
				_preventionState = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("pulsing")] 
		public CBool Pulsing
		{
			get
			{
				if (_pulsing == null)
				{
					_pulsing = (CBool) CR2WTypeManager.Create("Bool", "pulsing", cr2w, this);
				}
				return _pulsing;
			}
			set
			{
				if (_pulsing == value)
				{
					return;
				}
				_pulsing = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("hasBeenLooted")] 
		public CBool HasBeenLooted
		{
			get
			{
				if (_hasBeenLooted == null)
				{
					_hasBeenLooted = (CBool) CR2WTypeManager.Create("Bool", "hasBeenLooted", cr2w, this);
				}
				return _hasBeenLooted;
			}
			set
			{
				if (_hasBeenLooted == value)
				{
					return;
				}
				_hasBeenLooted = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("isAggressive")] 
		public CBool IsAggressive
		{
			get
			{
				if (_isAggressive == null)
				{
					_isAggressive = (CBool) CR2WTypeManager.Create("Bool", "isAggressive", cr2w, this);
				}
				return _isAggressive;
			}
			set
			{
				if (_isAggressive == value)
				{
					return;
				}
				_isAggressive = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("detectionAboveZero")] 
		public CBool DetectionAboveZero
		{
			get
			{
				if (_detectionAboveZero == null)
				{
					_detectionAboveZero = (CBool) CR2WTypeManager.Create("Bool", "detectionAboveZero", cr2w, this);
				}
				return _detectionAboveZero;
			}
			set
			{
				if (_detectionAboveZero == value)
				{
					return;
				}
				_detectionAboveZero = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get
			{
				if (_isAlive == null)
				{
					_isAlive = (CBool) CR2WTypeManager.Create("Bool", "isAlive", cr2w, this);
				}
				return _isAlive;
			}
			set
			{
				if (_isAlive == value)
				{
					return;
				}
				_isAlive = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("wasAlive")] 
		public CBool WasAlive
		{
			get
			{
				if (_wasAlive == null)
				{
					_wasAlive = (CBool) CR2WTypeManager.Create("Bool", "wasAlive", cr2w, this);
				}
				return _wasAlive;
			}
			set
			{
				if (_wasAlive == value)
				{
					return;
				}
				_wasAlive = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("wasCompanion")] 
		public CBool WasCompanion
		{
			get
			{
				if (_wasCompanion == null)
				{
					_wasCompanion = (CBool) CR2WTypeManager.Create("Bool", "wasCompanion", cr2w, this);
				}
				return _wasCompanion;
			}
			set
			{
				if (_wasCompanion == value)
				{
					return;
				}
				_wasCompanion = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("couldSeePlayer")] 
		public CBool CouldSeePlayer
		{
			get
			{
				if (_couldSeePlayer == null)
				{
					_couldSeePlayer = (CBool) CR2WTypeManager.Create("Bool", "couldSeePlayer", cr2w, this);
				}
				return _couldSeePlayer;
			}
			set
			{
				if (_couldSeePlayer == value)
				{
					return;
				}
				_couldSeePlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("isPrevention")] 
		public CBool IsPrevention
		{
			get
			{
				if (_isPrevention == null)
				{
					_isPrevention = (CBool) CR2WTypeManager.Create("Bool", "isPrevention", cr2w, this);
				}
				return _isPrevention;
			}
			set
			{
				if (_isPrevention == value)
				{
					return;
				}
				_isPrevention = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("isCrowdNPC")] 
		public CBool IsCrowdNPC
		{
			get
			{
				if (_isCrowdNPC == null)
				{
					_isCrowdNPC = (CBool) CR2WTypeManager.Create("Bool", "isCrowdNPC", cr2w, this);
				}
				return _isCrowdNPC;
			}
			set
			{
				if (_isCrowdNPC == value)
				{
					return;
				}
				_isCrowdNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("cautious")] 
		public CBool Cautious
		{
			get
			{
				if (_cautious == null)
				{
					_cautious = (CBool) CR2WTypeManager.Create("Bool", "cautious", cr2w, this);
				}
				return _cautious;
			}
			set
			{
				if (_cautious == value)
				{
					return;
				}
				_cautious = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("shouldShowVisionCone")] 
		public CBool ShouldShowVisionCone
		{
			get
			{
				if (_shouldShowVisionCone == null)
				{
					_shouldShowVisionCone = (CBool) CR2WTypeManager.Create("Bool", "shouldShowVisionCone", cr2w, this);
				}
				return _shouldShowVisionCone;
			}
			set
			{
				if (_shouldShowVisionCone == value)
				{
					return;
				}
				_shouldShowVisionCone = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get
			{
				if (_isDevice == null)
				{
					_isDevice = (CBool) CR2WTypeManager.Create("Bool", "isDevice", cr2w, this);
				}
				return _isDevice;
			}
			set
			{
				if (_isDevice == value)
				{
					return;
				}
				_isDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("isCamera")] 
		public CBool IsCamera
		{
			get
			{
				if (_isCamera == null)
				{
					_isCamera = (CBool) CR2WTypeManager.Create("Bool", "isCamera", cr2w, this);
				}
				return _isCamera;
			}
			set
			{
				if (_isCamera == value)
				{
					return;
				}
				_isCamera = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("isTurret")] 
		public CBool IsTurret
		{
			get
			{
				if (_isTurret == null)
				{
					_isTurret = (CBool) CR2WTypeManager.Create("Bool", "isTurret", cr2w, this);
				}
				return _isTurret;
			}
			set
			{
				if (_isTurret == value)
				{
					return;
				}
				_isTurret = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("isNetrunner")] 
		public CBool IsNetrunner
		{
			get
			{
				if (_isNetrunner == null)
				{
					_isNetrunner = (CBool) CR2WTypeManager.Create("Bool", "isNetrunner", cr2w, this);
				}
				return _isNetrunner;
			}
			set
			{
				if (_isNetrunner == value)
				{
					return;
				}
				_isNetrunner = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("isHacking")] 
		public CBool IsHacking
		{
			get
			{
				if (_isHacking == null)
				{
					_isHacking = (CBool) CR2WTypeManager.Create("Bool", "isHacking", cr2w, this);
				}
				return _isHacking;
			}
			set
			{
				if (_isHacking == value)
				{
					return;
				}
				_isHacking = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("isSquadInCombat")] 
		public CBool IsSquadInCombat
		{
			get
			{
				if (_isSquadInCombat == null)
				{
					_isSquadInCombat = (CBool) CR2WTypeManager.Create("Bool", "isSquadInCombat", cr2w, this);
				}
				return _isSquadInCombat;
			}
			set
			{
				if (_isSquadInCombat == value)
				{
					return;
				}
				_isSquadInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("wasSquadInCombat")] 
		public CBool WasSquadInCombat
		{
			get
			{
				if (_wasSquadInCombat == null)
				{
					_wasSquadInCombat = (CBool) CR2WTypeManager.Create("Bool", "wasSquadInCombat", cr2w, this);
				}
				return _wasSquadInCombat;
			}
			set
			{
				if (_wasSquadInCombat == value)
				{
					return;
				}
				_wasSquadInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("defaultOpacity")] 
		public CFloat DefaultOpacity
		{
			get
			{
				if (_defaultOpacity == null)
				{
					_defaultOpacity = (CFloat) CR2WTypeManager.Create("Float", "defaultOpacity", cr2w, this);
				}
				return _defaultOpacity;
			}
			set
			{
				if (_defaultOpacity == value)
				{
					return;
				}
				_defaultOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("adjustedOpacity")] 
		public CFloat AdjustedOpacity
		{
			get
			{
				if (_adjustedOpacity == null)
				{
					_adjustedOpacity = (CFloat) CR2WTypeManager.Create("Float", "adjustedOpacity", cr2w, this);
				}
				return _adjustedOpacity;
			}
			set
			{
				if (_adjustedOpacity == value)
				{
					return;
				}
				_adjustedOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("defaultConeOpacity")] 
		public CFloat DefaultConeOpacity
		{
			get
			{
				if (_defaultConeOpacity == null)
				{
					_defaultConeOpacity = (CFloat) CR2WTypeManager.Create("Float", "defaultConeOpacity", cr2w, this);
				}
				return _defaultConeOpacity;
			}
			set
			{
				if (_defaultConeOpacity == value)
				{
					return;
				}
				_defaultConeOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("detectingConeOpacity")] 
		public CFloat DetectingConeOpacity
		{
			get
			{
				if (_detectingConeOpacity == null)
				{
					_detectingConeOpacity = (CFloat) CR2WTypeManager.Create("Float", "detectingConeOpacity", cr2w, this);
				}
				return _detectingConeOpacity;
			}
			set
			{
				if (_detectingConeOpacity == value)
				{
					return;
				}
				_detectingConeOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("numberOfShotAttempts")] 
		public CUInt32 NumberOfShotAttempts
		{
			get
			{
				if (_numberOfShotAttempts == null)
				{
					_numberOfShotAttempts = (CUInt32) CR2WTypeManager.Create("Uint32", "numberOfShotAttempts", cr2w, this);
				}
				return _numberOfShotAttempts;
			}
			set
			{
				if (_numberOfShotAttempts == value)
				{
					return;
				}
				_numberOfShotAttempts = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("highestLootQuality")] 
		public CUInt32 HighestLootQuality
		{
			get
			{
				if (_highestLootQuality == null)
				{
					_highestLootQuality = (CUInt32) CR2WTypeManager.Create("Uint32", "highestLootQuality", cr2w, this);
				}
				return _highestLootQuality;
			}
			set
			{
				if (_highestLootQuality == value)
				{
					return;
				}
				_highestLootQuality = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("lockLootQuality")] 
		public CBool LockLootQuality
		{
			get
			{
				if (_lockLootQuality == null)
				{
					_lockLootQuality = (CBool) CR2WTypeManager.Create("Bool", "lockLootQuality", cr2w, this);
				}
				return _lockLootQuality;
			}
			set
			{
				if (_lockLootQuality == value)
				{
					return;
				}
				_lockLootQuality = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get
			{
				if (_highLevelState == null)
				{
					_highLevelState = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "highLevelState", cr2w, this);
				}
				return _highLevelState;
			}
			set
			{
				if (_highLevelState == value)
				{
					return;
				}
				_highLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("iconWidgetGlitch")] 
		public CHandle<inkWidget> IconWidgetGlitch
		{
			get
			{
				if (_iconWidgetGlitch == null)
				{
					_iconWidgetGlitch = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "iconWidgetGlitch", cr2w, this);
				}
				return _iconWidgetGlitch;
			}
			set
			{
				if (_iconWidgetGlitch == value)
				{
					return;
				}
				_iconWidgetGlitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("visionConeWidgetGlitch")] 
		public CHandle<inkWidget> VisionConeWidgetGlitch
		{
			get
			{
				if (_visionConeWidgetGlitch == null)
				{
					_visionConeWidgetGlitch = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "visionConeWidgetGlitch", cr2w, this);
				}
				return _visionConeWidgetGlitch;
			}
			set
			{
				if (_visionConeWidgetGlitch == value)
				{
					return;
				}
				_visionConeWidgetGlitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("clampArrowWidgetGlitch")] 
		public CHandle<inkWidget> ClampArrowWidgetGlitch
		{
			get
			{
				if (_clampArrowWidgetGlitch == null)
				{
					_clampArrowWidgetGlitch = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "clampArrowWidgetGlitch", cr2w, this);
				}
				return _clampArrowWidgetGlitch;
			}
			set
			{
				if (_clampArrowWidgetGlitch == value)
				{
					return;
				}
				_clampArrowWidgetGlitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("showAnim")] 
		public CHandle<inkanimProxy> ShowAnim
		{
			get
			{
				if (_showAnim == null)
				{
					_showAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "showAnim", cr2w, this);
				}
				return _showAnim;
			}
			set
			{
				if (_showAnim == value)
				{
					return;
				}
				_showAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("alertedAnim")] 
		public CHandle<inkanimProxy> AlertedAnim
		{
			get
			{
				if (_alertedAnim == null)
				{
					_alertedAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "alertedAnim", cr2w, this);
				}
				return _alertedAnim;
			}
			set
			{
				if (_alertedAnim == value)
				{
					return;
				}
				_alertedAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("preventionAnimProxy")] 
		public CHandle<inkanimProxy> PreventionAnimProxy
		{
			get
			{
				if (_preventionAnimProxy == null)
				{
					_preventionAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "preventionAnimProxy", cr2w, this);
				}
				return _preventionAnimProxy;
			}
			set
			{
				if (_preventionAnimProxy == value)
				{
					return;
				}
				_preventionAnimProxy = value;
				PropertySet(this);
			}
		}

		public gameuiMinimapStealthMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

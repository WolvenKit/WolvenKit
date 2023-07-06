using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SensorDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		[Ordinal(120)] 
		[RED("isRecognizableBySenses")] 
		public CBool IsRecognizableBySenses
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(121)] 
		[RED("targetingBehaviour")] 
		public TargetingBehaviour TargetingBehaviour
		{
			get => GetPropertyValue<TargetingBehaviour>();
			set => SetPropertyValue<TargetingBehaviour>(value);
		}

		[Ordinal(122)] 
		[RED("detectionParameters")] 
		public DetectionParameters DetectionParameters
		{
			get => GetPropertyValue<DetectionParameters>();
			set => SetPropertyValue<DetectionParameters>(value);
		}

		[Ordinal(123)] 
		[RED("lookAtPresetVert")] 
		public TweakDBID LookAtPresetVert
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(124)] 
		[RED("lookAtPresetHor")] 
		public TweakDBID LookAtPresetHor
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(125)] 
		[RED("scanGameEffectRef")] 
		public gameEffectRef ScanGameEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(126)] 
		[RED("visionConeEffectRef")] 
		public gameEffectRef VisionConeEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(127)] 
		[RED("visionConeFriendlyEffectRef")] 
		public gameEffectRef VisionConeFriendlyEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(128)] 
		[RED("idleActiveRef")] 
		public gameEffectRef IdleActiveRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(129)] 
		[RED("idleFriendlyRef")] 
		public gameEffectRef IdleFriendlyRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(130)] 
		[RED("canTagEnemies")] 
		public CBool CanTagEnemies
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(131)] 
		[RED("tagLockFromSystem")] 
		public CBool TagLockFromSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(132)] 
		[RED("netrunnerID")] 
		public entEntityID NetrunnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(133)] 
		[RED("netrunnerProxyID")] 
		public entEntityID NetrunnerProxyID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(134)] 
		[RED("netrunnerTargetID")] 
		public entEntityID NetrunnerTargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(135)] 
		[RED("linkedStatusEffect")] 
		public LinkedStatusEffect LinkedStatusEffect
		{
			get => GetPropertyValue<LinkedStatusEffect>();
			set => SetPropertyValue<LinkedStatusEffect>(value);
		}

		[Ordinal(136)] 
		[RED("questForcedTargetID")] 
		public entEntityID QuestForcedTargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(137)] 
		[RED("isInFollowMode")] 
		public CBool IsInFollowMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(138)] 
		[RED("isAttitudeChanged")] 
		public CBool IsAttitudeChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(139)] 
		[RED("isInTagKillMode")] 
		public CBool IsInTagKillMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(140)] 
		[RED("isIdleForced")] 
		public CBool IsIdleForced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(141)] 
		[RED("questTargetToSpot")] 
		public entEntityID QuestTargetToSpot
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(142)] 
		[RED("questTargetSpotted")] 
		public CBool QuestTargetSpotted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(143)] 
		[RED("isAnyTargetIsLocked")] 
		public CBool IsAnyTargetIsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(144)] 
		[RED("isPartOfPrevention")] 
		public CBool IsPartOfPrevention
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SensorDeviceControllerPS()
		{
			DeviceName = "Sensor Device";
			CanPlayerTakeOverControl = true;
			ShouldScannerShowStatus = true;
			ShouldScannerShowAttitude = true;
			IsRecognizableBySenses = true;
			TargetingBehaviour = new TargetingBehaviour { CanRotate = true, LostTargetLookAtTime = 2.000000F, LostTargetSearchTime = 10.000000F };
			DetectionParameters = new DetectionParameters { CanDetectIntruders = true, TimeToActionAfterSpot = 2.000000F, MaxRotationAngle = 90.000000F, PitchAngle = -15.000000F, RotationSpeed = 5.000000F };
			ScanGameEffectRef = new gameEffectRef();
			VisionConeEffectRef = new gameEffectRef();
			VisionConeFriendlyEffectRef = new gameEffectRef();
			IdleActiveRef = new gameEffectRef();
			IdleFriendlyRef = new gameEffectRef();
			NetrunnerID = new entEntityID();
			NetrunnerProxyID = new entEntityID();
			NetrunnerTargetID = new entEntityID();
			LinkedStatusEffect = new LinkedStatusEffect { NetrunnerIDs = new(), TargetID = new entEntityID(), StatusEffectList = new() };
			QuestForcedTargetID = new entEntityID();
			QuestTargetToSpot = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

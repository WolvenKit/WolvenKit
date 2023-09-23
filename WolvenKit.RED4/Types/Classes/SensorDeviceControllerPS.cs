using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SensorDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		[Ordinal(124)] 
		[RED("isRecognizableBySenses")] 
		public CBool IsRecognizableBySenses
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(125)] 
		[RED("targetingBehaviour")] 
		public TargetingBehaviour TargetingBehaviour
		{
			get => GetPropertyValue<TargetingBehaviour>();
			set => SetPropertyValue<TargetingBehaviour>(value);
		}

		[Ordinal(126)] 
		[RED("detectionParameters")] 
		public DetectionParameters DetectionParameters
		{
			get => GetPropertyValue<DetectionParameters>();
			set => SetPropertyValue<DetectionParameters>(value);
		}

		[Ordinal(127)] 
		[RED("lookAtPresetVert")] 
		public TweakDBID LookAtPresetVert
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(128)] 
		[RED("lookAtPresetHor")] 
		public TweakDBID LookAtPresetHor
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(129)] 
		[RED("scanGameEffectRef")] 
		public gameEffectRef ScanGameEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(130)] 
		[RED("visionConeEffectRef")] 
		public gameEffectRef VisionConeEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(131)] 
		[RED("visionConeFriendlyEffectRef")] 
		public gameEffectRef VisionConeFriendlyEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(132)] 
		[RED("idleActiveRef")] 
		public gameEffectRef IdleActiveRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(133)] 
		[RED("idleFriendlyRef")] 
		public gameEffectRef IdleFriendlyRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(134)] 
		[RED("canTagEnemies")] 
		public CBool CanTagEnemies
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(135)] 
		[RED("tagLockFromSystem")] 
		public CBool TagLockFromSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(136)] 
		[RED("netrunnerID")] 
		public entEntityID NetrunnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(137)] 
		[RED("netrunnerProxyID")] 
		public entEntityID NetrunnerProxyID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(138)] 
		[RED("netrunnerTargetID")] 
		public entEntityID NetrunnerTargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(139)] 
		[RED("linkedStatusEffect")] 
		public LinkedStatusEffect LinkedStatusEffect
		{
			get => GetPropertyValue<LinkedStatusEffect>();
			set => SetPropertyValue<LinkedStatusEffect>(value);
		}

		[Ordinal(140)] 
		[RED("questForcedTargetID")] 
		public entEntityID QuestForcedTargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(141)] 
		[RED("isInFollowMode")] 
		public CBool IsInFollowMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(142)] 
		[RED("isAttitudeChanged")] 
		public CBool IsAttitudeChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(143)] 
		[RED("isInTagKillMode")] 
		public CBool IsInTagKillMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(144)] 
		[RED("isIdleForced")] 
		public CBool IsIdleForced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(145)] 
		[RED("questTargetToSpot")] 
		public entEntityID QuestTargetToSpot
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(146)] 
		[RED("questTargetSpotted")] 
		public CBool QuestTargetSpotted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(147)] 
		[RED("isAnyTargetIsLocked")] 
		public CBool IsAnyTargetIsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(148)] 
		[RED("isPartOfPrevention")] 
		public CBool IsPartOfPrevention
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(149)] 
		[RED("ignoreTargetTrackerComponent")] 
		public CBool IgnoreTargetTrackerComponent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SensorDeviceControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

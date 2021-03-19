using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SensorDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		private CBool _isRecognizableBySenses;
		private TargetingBehaviour _targetingBehaviour;
		private DetectionParameters _detectionParameters;
		private TweakDBID _lookAtPresetVert;
		private TweakDBID _lookAtPresetHor;
		private gameEffectRef _scanGameEffectRef;
		private gameEffectRef _visionConeEffectRef;
		private gameEffectRef _visionConeFriendlyEffectRef;
		private gameEffectRef _idleActiveRef;
		private gameEffectRef _idleFriendlyRef;
		private CBool _canTagEnemies;
		private CBool _tagLockFromSystem;
		private entEntityID _netrunnerID;
		private entEntityID _netrunnerProxyID;
		private entEntityID _netrunnerTargetID;
		private LinkedStatusEffect _linkedStatusEffect;
		private entEntityID _questForcedTargetID;
		private CBool _isInFollowMode;
		private CBool _isAttitudeChanged;
		private CBool _isInTagKillMode;
		private CBool _isIdleForced;
		private entEntityID _questTargetToSpot;
		private CBool _questTargetSpotted;
		private CBool _isAnyTargetIsLocked;
		private CBool _isPartOfPrevention;

		[Ordinal(119)] 
		[RED("isRecognizableBySenses")] 
		public CBool IsRecognizableBySenses
		{
			get => GetProperty(ref _isRecognizableBySenses);
			set => SetProperty(ref _isRecognizableBySenses, value);
		}

		[Ordinal(120)] 
		[RED("targetingBehaviour")] 
		public TargetingBehaviour TargetingBehaviour
		{
			get => GetProperty(ref _targetingBehaviour);
			set => SetProperty(ref _targetingBehaviour, value);
		}

		[Ordinal(121)] 
		[RED("detectionParameters")] 
		public DetectionParameters DetectionParameters
		{
			get => GetProperty(ref _detectionParameters);
			set => SetProperty(ref _detectionParameters, value);
		}

		[Ordinal(122)] 
		[RED("lookAtPresetVert")] 
		public TweakDBID LookAtPresetVert
		{
			get => GetProperty(ref _lookAtPresetVert);
			set => SetProperty(ref _lookAtPresetVert, value);
		}

		[Ordinal(123)] 
		[RED("lookAtPresetHor")] 
		public TweakDBID LookAtPresetHor
		{
			get => GetProperty(ref _lookAtPresetHor);
			set => SetProperty(ref _lookAtPresetHor, value);
		}

		[Ordinal(124)] 
		[RED("scanGameEffectRef")] 
		public gameEffectRef ScanGameEffectRef
		{
			get => GetProperty(ref _scanGameEffectRef);
			set => SetProperty(ref _scanGameEffectRef, value);
		}

		[Ordinal(125)] 
		[RED("visionConeEffectRef")] 
		public gameEffectRef VisionConeEffectRef
		{
			get => GetProperty(ref _visionConeEffectRef);
			set => SetProperty(ref _visionConeEffectRef, value);
		}

		[Ordinal(126)] 
		[RED("visionConeFriendlyEffectRef")] 
		public gameEffectRef VisionConeFriendlyEffectRef
		{
			get => GetProperty(ref _visionConeFriendlyEffectRef);
			set => SetProperty(ref _visionConeFriendlyEffectRef, value);
		}

		[Ordinal(127)] 
		[RED("idleActiveRef")] 
		public gameEffectRef IdleActiveRef
		{
			get => GetProperty(ref _idleActiveRef);
			set => SetProperty(ref _idleActiveRef, value);
		}

		[Ordinal(128)] 
		[RED("idleFriendlyRef")] 
		public gameEffectRef IdleFriendlyRef
		{
			get => GetProperty(ref _idleFriendlyRef);
			set => SetProperty(ref _idleFriendlyRef, value);
		}

		[Ordinal(129)] 
		[RED("canTagEnemies")] 
		public CBool CanTagEnemies
		{
			get => GetProperty(ref _canTagEnemies);
			set => SetProperty(ref _canTagEnemies, value);
		}

		[Ordinal(130)] 
		[RED("tagLockFromSystem")] 
		public CBool TagLockFromSystem
		{
			get => GetProperty(ref _tagLockFromSystem);
			set => SetProperty(ref _tagLockFromSystem, value);
		}

		[Ordinal(131)] 
		[RED("netrunnerID")] 
		public entEntityID NetrunnerID
		{
			get => GetProperty(ref _netrunnerID);
			set => SetProperty(ref _netrunnerID, value);
		}

		[Ordinal(132)] 
		[RED("netrunnerProxyID")] 
		public entEntityID NetrunnerProxyID
		{
			get => GetProperty(ref _netrunnerProxyID);
			set => SetProperty(ref _netrunnerProxyID, value);
		}

		[Ordinal(133)] 
		[RED("netrunnerTargetID")] 
		public entEntityID NetrunnerTargetID
		{
			get => GetProperty(ref _netrunnerTargetID);
			set => SetProperty(ref _netrunnerTargetID, value);
		}

		[Ordinal(134)] 
		[RED("linkedStatusEffect")] 
		public LinkedStatusEffect LinkedStatusEffect
		{
			get => GetProperty(ref _linkedStatusEffect);
			set => SetProperty(ref _linkedStatusEffect, value);
		}

		[Ordinal(135)] 
		[RED("questForcedTargetID")] 
		public entEntityID QuestForcedTargetID
		{
			get => GetProperty(ref _questForcedTargetID);
			set => SetProperty(ref _questForcedTargetID, value);
		}

		[Ordinal(136)] 
		[RED("isInFollowMode")] 
		public CBool IsInFollowMode
		{
			get => GetProperty(ref _isInFollowMode);
			set => SetProperty(ref _isInFollowMode, value);
		}

		[Ordinal(137)] 
		[RED("isAttitudeChanged")] 
		public CBool IsAttitudeChanged
		{
			get => GetProperty(ref _isAttitudeChanged);
			set => SetProperty(ref _isAttitudeChanged, value);
		}

		[Ordinal(138)] 
		[RED("isInTagKillMode")] 
		public CBool IsInTagKillMode
		{
			get => GetProperty(ref _isInTagKillMode);
			set => SetProperty(ref _isInTagKillMode, value);
		}

		[Ordinal(139)] 
		[RED("isIdleForced")] 
		public CBool IsIdleForced
		{
			get => GetProperty(ref _isIdleForced);
			set => SetProperty(ref _isIdleForced, value);
		}

		[Ordinal(140)] 
		[RED("questTargetToSpot")] 
		public entEntityID QuestTargetToSpot
		{
			get => GetProperty(ref _questTargetToSpot);
			set => SetProperty(ref _questTargetToSpot, value);
		}

		[Ordinal(141)] 
		[RED("questTargetSpotted")] 
		public CBool QuestTargetSpotted
		{
			get => GetProperty(ref _questTargetSpotted);
			set => SetProperty(ref _questTargetSpotted, value);
		}

		[Ordinal(142)] 
		[RED("isAnyTargetIsLocked")] 
		public CBool IsAnyTargetIsLocked
		{
			get => GetProperty(ref _isAnyTargetIsLocked);
			set => SetProperty(ref _isAnyTargetIsLocked, value);
		}

		[Ordinal(143)] 
		[RED("isPartOfPrevention")] 
		public CBool IsPartOfPrevention
		{
			get => GetProperty(ref _isPartOfPrevention);
			set => SetProperty(ref _isPartOfPrevention, value);
		}

		public SensorDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

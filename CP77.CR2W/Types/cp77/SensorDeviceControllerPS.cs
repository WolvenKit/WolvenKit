using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SensorDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		[Ordinal(119)] [RED("isRecognizableBySenses")] public CBool IsRecognizableBySenses { get; set; }
		[Ordinal(120)] [RED("targetingBehaviour")] public TargetingBehaviour TargetingBehaviour { get; set; }
		[Ordinal(121)] [RED("detectionParameters")] public DetectionParameters DetectionParameters { get; set; }
		[Ordinal(122)] [RED("lookAtPresetVert")] public TweakDBID LookAtPresetVert { get; set; }
		[Ordinal(123)] [RED("lookAtPresetHor")] public TweakDBID LookAtPresetHor { get; set; }
		[Ordinal(124)] [RED("scanGameEffectRef")] public gameEffectRef ScanGameEffectRef { get; set; }
		[Ordinal(125)] [RED("visionConeEffectRef")] public gameEffectRef VisionConeEffectRef { get; set; }
		[Ordinal(126)] [RED("visionConeFriendlyEffectRef")] public gameEffectRef VisionConeFriendlyEffectRef { get; set; }
		[Ordinal(127)] [RED("idleActiveRef")] public gameEffectRef IdleActiveRef { get; set; }
		[Ordinal(128)] [RED("idleFriendlyRef")] public gameEffectRef IdleFriendlyRef { get; set; }
		[Ordinal(129)] [RED("canTagEnemies")] public CBool CanTagEnemies { get; set; }
		[Ordinal(130)] [RED("tagLockFromSystem")] public CBool TagLockFromSystem { get; set; }
		[Ordinal(131)] [RED("netrunnerID")] public entEntityID NetrunnerID { get; set; }
		[Ordinal(132)] [RED("netrunnerProxyID")] public entEntityID NetrunnerProxyID { get; set; }
		[Ordinal(133)] [RED("netrunnerTargetID")] public entEntityID NetrunnerTargetID { get; set; }
		[Ordinal(134)] [RED("linkedStatusEffect")] public LinkedStatusEffect LinkedStatusEffect { get; set; }
		[Ordinal(135)] [RED("questForcedTargetID")] public entEntityID QuestForcedTargetID { get; set; }
		[Ordinal(136)] [RED("isInFollowMode")] public CBool IsInFollowMode { get; set; }
		[Ordinal(137)] [RED("isAttitudeChanged")] public CBool IsAttitudeChanged { get; set; }
		[Ordinal(138)] [RED("isInTagKillMode")] public CBool IsInTagKillMode { get; set; }
		[Ordinal(139)] [RED("isIdleForced")] public CBool IsIdleForced { get; set; }
		[Ordinal(140)] [RED("questTargetToSpot")] public entEntityID QuestTargetToSpot { get; set; }
		[Ordinal(141)] [RED("questTargetSpotted")] public CBool QuestTargetSpotted { get; set; }
		[Ordinal(142)] [RED("isAnyTargetIsLocked")] public CBool IsAnyTargetIsLocked { get; set; }
		[Ordinal(143)] [RED("isPartOfPrevention")] public CBool IsPartOfPrevention { get; set; }

		public SensorDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

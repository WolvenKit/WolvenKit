using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SensorDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		[Ordinal(0)]  [RED("canTagEnemies")] public CBool CanTagEnemies { get; set; }
		[Ordinal(1)]  [RED("detectionParameters")] public DetectionParameters DetectionParameters { get; set; }
		[Ordinal(2)]  [RED("idleActiveRef")] public gameEffectRef IdleActiveRef { get; set; }
		[Ordinal(3)]  [RED("idleFriendlyRef")] public gameEffectRef IdleFriendlyRef { get; set; }
		[Ordinal(4)]  [RED("isAnyTargetIsLocked")] public CBool IsAnyTargetIsLocked { get; set; }
		[Ordinal(5)]  [RED("isAttitudeChanged")] public CBool IsAttitudeChanged { get; set; }
		[Ordinal(6)]  [RED("isIdleForced")] public CBool IsIdleForced { get; set; }
		[Ordinal(7)]  [RED("isInFollowMode")] public CBool IsInFollowMode { get; set; }
		[Ordinal(8)]  [RED("isInTagKillMode")] public CBool IsInTagKillMode { get; set; }
		[Ordinal(9)]  [RED("isPartOfPrevention")] public CBool IsPartOfPrevention { get; set; }
		[Ordinal(10)]  [RED("isRecognizableBySenses")] public CBool IsRecognizableBySenses { get; set; }
		[Ordinal(11)]  [RED("linkedStatusEffect")] public LinkedStatusEffect LinkedStatusEffect { get; set; }
		[Ordinal(12)]  [RED("lookAtPresetHor")] public TweakDBID LookAtPresetHor { get; set; }
		[Ordinal(13)]  [RED("lookAtPresetVert")] public TweakDBID LookAtPresetVert { get; set; }
		[Ordinal(14)]  [RED("netrunnerID")] public entEntityID NetrunnerID { get; set; }
		[Ordinal(15)]  [RED("netrunnerProxyID")] public entEntityID NetrunnerProxyID { get; set; }
		[Ordinal(16)]  [RED("netrunnerTargetID")] public entEntityID NetrunnerTargetID { get; set; }
		[Ordinal(17)]  [RED("questForcedTargetID")] public entEntityID QuestForcedTargetID { get; set; }
		[Ordinal(18)]  [RED("questTargetSpotted")] public CBool QuestTargetSpotted { get; set; }
		[Ordinal(19)]  [RED("questTargetToSpot")] public entEntityID QuestTargetToSpot { get; set; }
		[Ordinal(20)]  [RED("scanGameEffectRef")] public gameEffectRef ScanGameEffectRef { get; set; }
		[Ordinal(21)]  [RED("tagLockFromSystem")] public CBool TagLockFromSystem { get; set; }
		[Ordinal(22)]  [RED("targetingBehaviour")] public TargetingBehaviour TargetingBehaviour { get; set; }
		[Ordinal(23)]  [RED("visionConeEffectRef")] public gameEffectRef VisionConeEffectRef { get; set; }
		[Ordinal(24)]  [RED("visionConeFriendlyEffectRef")] public gameEffectRef VisionConeFriendlyEffectRef { get; set; }

		public SensorDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

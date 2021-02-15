using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleSmartBullet : BaseProjectile
	{
		[Ordinal(51)] [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(52)] [RED("effect")] public gameEffectRef Effect { get; set; }
		[Ordinal(53)] [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(54)] [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(55)] [RED("lifetime")] public CFloat Lifetime_496 { get; set; }
		[Ordinal(56)] [RED("bendTimeRatio")] public CFloat BendTimeRatio { get; set; }
		[Ordinal(57)] [RED("bendFactor")] public CFloat BendFactor { get; set; }
		[Ordinal(58)] [RED("useParabolicPhase")] public CBool UseParabolicPhase { get; set; }
		[Ordinal(59)] [RED("parabolicVelocityMin")] public CFloat ParabolicVelocityMin { get; set; }
		[Ordinal(60)] [RED("parabolicVelocityMax")] public CFloat ParabolicVelocityMax { get; set; }
		[Ordinal(61)] [RED("parabolicDuration")] public CFloat ParabolicDuration { get; set; }
		[Ordinal(62)] [RED("parabolicGravity")] public Vector4 ParabolicGravity { get; set; }
		[Ordinal(63)] [RED("spiralParams")] public CHandle<gameprojectileSpiralParams> SpiralParams { get; set; }
		[Ordinal(64)] [RED("useSpiralParams")] public CBool UseSpiralParams { get; set; }
		[Ordinal(65)] [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(66)] [RED("hit")] public CBool Hit { get; set; }
		[Ordinal(67)] [RED("trailName")] public CName TrailName { get; set; }
		[Ordinal(68)] [RED("statsSystem")] public CHandle<gameStatsSystem> StatsSystem { get; set; }
		[Ordinal(69)] [RED("weaponID")] public entEntityID WeaponID { get; set; }
		[Ordinal(70)] [RED("parabolicPhaseParams")] public CHandle<gameprojectileParabolicTrajectoryParams> ParabolicPhaseParams { get; set; }
		[Ordinal(71)] [RED("followPhaseParams")] public CHandle<gameprojectileFollowCurveTrajectoryParams> FollowPhaseParams { get; set; }
		[Ordinal(72)] [RED("linearPhaseParams")] public CHandle<gameprojectileLinearTrajectoryParams> LinearPhaseParams { get; set; }
		[Ordinal(73)] [RED("targeted")] public CBool Targeted { get; set; }
		[Ordinal(74)] [RED("trailStarted")] public CBool TrailStarted { get; set; }
		[Ordinal(75)] [RED("phase")] public CEnum<ESmartBulletPhase> Phase { get; set; }
		[Ordinal(76)] [RED("timeInPhase")] public CFloat TimeInPhase { get; set; }
		[Ordinal(77)] [RED("randStartVelocity")] public CFloat RandStartVelocity { get; set; }
		[Ordinal(78)] [RED("smartGunMissDelay")] public CFloat SmartGunMissDelay { get; set; }
		[Ordinal(79)] [RED("smartGunHitProbability")] public CFloat SmartGunHitProbability { get; set; }
		[Ordinal(80)] [RED("smartGunMissRadius")] public CFloat SmartGunMissRadius { get; set; }
		[Ordinal(81)] [RED("randomWeaponMissChance")] public CFloat RandomWeaponMissChance { get; set; }
		[Ordinal(82)] [RED("randomTargetMissChance")] public CFloat RandomTargetMissChance { get; set; }
		[Ordinal(83)] [RED("readyToMiss")] public CBool ReadyToMiss { get; set; }
		[Ordinal(84)] [RED("stopAndDropOnTargetingDisruption")] public CBool StopAndDropOnTargetingDisruption { get; set; }
		[Ordinal(85)] [RED("shouldStopAndDrop")] public CBool ShouldStopAndDrop { get; set; }
		[Ordinal(86)] [RED("targetID")] public entEntityID TargetID { get; set; }
		[Ordinal(87)] [RED("ignoredTargetID")] public entEntityID IgnoredTargetID { get; set; }
		[Ordinal(88)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(89)] [RED("weapon")] public wCHandle<gameObject> Weapon { get; set; }
		[Ordinal(90)] [RED("startPosition")] public Vector4 StartPosition { get; set; }
		[Ordinal(91)] [RED("hasExploded")] public CBool HasExploded { get; set; }
		[Ordinal(92)] [RED("attack")] public CHandle<gameIAttack> Attack { get; set; }
		[Ordinal(93)] [RED("BulletCollisionEvaluator")] public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator { get; set; }

		public sampleSmartBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

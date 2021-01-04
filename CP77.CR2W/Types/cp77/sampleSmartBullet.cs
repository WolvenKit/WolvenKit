using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleSmartBullet : BaseProjectile
	{
		[Ordinal(0)]  [RED("BulletCollisionEvaluator")] public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator { get; set; }
		[Ordinal(1)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(2)]  [RED("attack")] public CHandle<gameIAttack> Attack { get; set; }
		[Ordinal(3)]  [RED("bendFactor")] public CFloat BendFactor { get; set; }
		[Ordinal(4)]  [RED("bendTimeRatio")] public CFloat BendTimeRatio { get; set; }
		[Ordinal(5)]  [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(6)]  [RED("damage")] public CHandle<gameEffectInstance> Damage { get; set; }
		[Ordinal(7)]  [RED("effect")] public gameEffectRef Effect { get; set; }
		[Ordinal(8)]  [RED("followPhaseParams")] public CHandle<gameprojectileFollowCurveTrajectoryParams> FollowPhaseParams { get; set; }
		[Ordinal(9)]  [RED("hasExploded")] public CBool HasExploded { get; set; }
		[Ordinal(10)]  [RED("hit")] public CBool Hit { get; set; }
		[Ordinal(11)]  [RED("ignoredTargetID")] public entEntityID IgnoredTargetID { get; set; }
		[Ordinal(12)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(13)]  [RED("linearPhaseParams")] public CHandle<gameprojectileLinearTrajectoryParams> LinearPhaseParams { get; set; }
		[Ordinal(14)]  [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(15)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(16)]  [RED("parabolicDuration")] public CFloat ParabolicDuration { get; set; }
		[Ordinal(17)]  [RED("parabolicGravity")] public Vector4 ParabolicGravity { get; set; }
		[Ordinal(18)]  [RED("parabolicPhaseParams")] public CHandle<gameprojectileParabolicTrajectoryParams> ParabolicPhaseParams { get; set; }
		[Ordinal(19)]  [RED("parabolicVelocityMax")] public CFloat ParabolicVelocityMax { get; set; }
		[Ordinal(20)]  [RED("parabolicVelocityMin")] public CFloat ParabolicVelocityMin { get; set; }
		[Ordinal(21)]  [RED("phase")] public CEnum<ESmartBulletPhase> Phase { get; set; }
		[Ordinal(22)]  [RED("randStartVelocity")] public CFloat RandStartVelocity { get; set; }
		[Ordinal(23)]  [RED("randomTargetMissChance")] public CFloat RandomTargetMissChance { get; set; }
		[Ordinal(24)]  [RED("randomWeaponMissChance")] public CFloat RandomWeaponMissChance { get; set; }
		[Ordinal(25)]  [RED("readyToMiss")] public CBool ReadyToMiss { get; set; }
		[Ordinal(26)]  [RED("shouldStopAndDrop")] public CBool ShouldStopAndDrop { get; set; }
		[Ordinal(27)]  [RED("smartGunHitProbability")] public CFloat SmartGunHitProbability { get; set; }
		[Ordinal(28)]  [RED("smartGunMissDelay")] public CFloat SmartGunMissDelay { get; set; }
		[Ordinal(29)]  [RED("smartGunMissRadius")] public CFloat SmartGunMissRadius { get; set; }
		[Ordinal(30)]  [RED("spiralParams")] public CHandle<gameprojectileSpiralParams> SpiralParams { get; set; }
		[Ordinal(31)]  [RED("startPosition")] public Vector4 StartPosition { get; set; }
		[Ordinal(32)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(33)]  [RED("statsSystem")] public CHandle<gameStatsSystem> StatsSystem { get; set; }
		[Ordinal(34)]  [RED("stopAndDropOnTargetingDisruption")] public CBool StopAndDropOnTargetingDisruption { get; set; }
		[Ordinal(35)]  [RED("targetID")] public entEntityID TargetID { get; set; }
		[Ordinal(36)]  [RED("targeted")] public CBool Targeted { get; set; }
		[Ordinal(37)]  [RED("timeInPhase")] public CFloat TimeInPhase { get; set; }
		[Ordinal(38)]  [RED("trailName")] public CName TrailName { get; set; }
		[Ordinal(39)]  [RED("trailStarted")] public CBool TrailStarted { get; set; }
		[Ordinal(40)]  [RED("useParabolicPhase")] public CBool UseParabolicPhase { get; set; }
		[Ordinal(41)]  [RED("useSpiralParams")] public CBool UseSpiralParams { get; set; }
		[Ordinal(42)]  [RED("weapon")] public wCHandle<gameObject> Weapon { get; set; }
		[Ordinal(43)]  [RED("weaponID")] public entEntityID WeaponID { get; set; }

		public sampleSmartBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

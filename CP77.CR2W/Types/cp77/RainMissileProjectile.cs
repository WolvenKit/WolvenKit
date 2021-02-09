using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RainMissileProjectile : BaseProjectile
	{
		[Ordinal(41)]  [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(42)]  [RED("effect")] public gameEffectRef Effect { get; set; }
		[Ordinal(43)]  [RED("damage")] public CHandle<gameEffectInstance> Damage { get; set; }
		[Ordinal(44)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(45)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }
		[Ordinal(46)]  [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(47)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(48)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(49)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(50)]  [RED("hit")] public CBool Hit { get; set; }
		[Ordinal(51)]  [RED("arrived")] public CBool Arrived { get; set; }
		[Ordinal(52)]  [RED("spawnPosition")] public Vector4 SpawnPosition { get; set; }
		[Ordinal(53)]  [RED("phase1Duration")] public CFloat Phase1Duration { get; set; }
		[Ordinal(54)]  [RED("landIndicatorFX")] public gameFxResource LandIndicatorFX { get; set; }
		[Ordinal(55)]  [RED("fxInstance")] public CHandle<gameFxInstance> FxInstance { get; set; }
		[Ordinal(56)]  [RED("hasExploded")] public CBool HasExploded { get; set; }
		[Ordinal(57)]  [RED("missileDBID")] public TweakDBID MissileDBID { get; set; }
		[Ordinal(58)]  [RED("timeToDestory")] public CFloat TimeToDestory { get; set; }
		[Ordinal(59)]  [RED("initialTargetPosition")] public Vector4 InitialTargetPosition { get; set; }
		[Ordinal(60)]  [RED("initialTargetOffset")] public Vector4 InitialTargetOffset { get; set; }
		[Ordinal(61)]  [RED("finalTargetPosition")] public Vector4 FinalTargetPosition { get; set; }
		[Ordinal(62)]  [RED("finalTargetOffset")] public Vector4 FinalTargetOffset { get; set; }
		[Ordinal(63)]  [RED("finalTargetPositionCalculationDelay")] public CFloat FinalTargetPositionCalculationDelay { get; set; }
		[Ordinal(64)]  [RED("targetComponent")] public wCHandle<entIPlacedComponent> TargetComponent { get; set; }
		[Ordinal(65)]  [RED("followTargetInPhase2")] public CBool FollowTargetInPhase2 { get; set; }
		[Ordinal(66)]  [RED("puppetBroadphaseHitRadiusSquared")] public CFloat PuppetBroadphaseHitRadiusSquared { get; set; }
		[Ordinal(67)]  [RED("phase")] public CEnum<EMissileRainPhase> Phase { get; set; }
		[Ordinal(68)]  [RED("spiralParams")] public CHandle<gameprojectileSpiralParams> SpiralParams { get; set; }
		[Ordinal(69)]  [RED("useSpiralParams")] public CBool UseSpiralParams { get; set; }
		[Ordinal(70)]  [RED("randStartVelocity")] public CFloat RandStartVelocity { get; set; }

		public RainMissileProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RainMissileProjectile : BaseProjectile
	{
		[Ordinal(51)] [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(52)] [RED("effect")] public gameEffectRef Effect { get; set; }
		[Ordinal(53)] [RED("damage")] public CHandle<gameEffectInstance> Damage { get; set; }
		[Ordinal(54)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(55)] [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }
		[Ordinal(56)] [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(57)] [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(58)] [RED("lifetime")] public CFloat Lifetime_544 { get; set; }
		[Ordinal(59)] [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(60)] [RED("hit")] public CBool Hit { get; set; }
		[Ordinal(61)] [RED("arrived")] public CBool Arrived { get; set; }
		[Ordinal(62)] [RED("spawnPosition")] public Vector4 SpawnPosition { get; set; }
		[Ordinal(63)] [RED("phase1Duration")] public CFloat Phase1Duration { get; set; }
		[Ordinal(64)] [RED("landIndicatorFX")] public gameFxResource LandIndicatorFX { get; set; }
		[Ordinal(65)] [RED("fxInstance")] public CHandle<gameFxInstance> FxInstance { get; set; }
		[Ordinal(66)] [RED("hasExploded")] public CBool HasExploded { get; set; }
		[Ordinal(67)] [RED("missileDBID")] public TweakDBID MissileDBID { get; set; }
		[Ordinal(68)] [RED("timeToDestory")] public CFloat TimeToDestory { get; set; }
		[Ordinal(69)] [RED("initialTargetPosition")] public Vector4 InitialTargetPosition { get; set; }
		[Ordinal(70)] [RED("initialTargetOffset")] public Vector4 InitialTargetOffset { get; set; }
		[Ordinal(71)] [RED("finalTargetPosition")] public Vector4 FinalTargetPosition { get; set; }
		[Ordinal(72)] [RED("finalTargetOffset")] public Vector4 FinalTargetOffset { get; set; }
		[Ordinal(73)] [RED("finalTargetPositionCalculationDelay")] public CFloat FinalTargetPositionCalculationDelay { get; set; }
		[Ordinal(74)] [RED("targetComponent")] public wCHandle<entIPlacedComponent> TargetComponent { get; set; }
		[Ordinal(75)] [RED("followTargetInPhase2")] public CBool FollowTargetInPhase2 { get; set; }
		[Ordinal(76)] [RED("puppetBroadphaseHitRadiusSquared")] public CFloat PuppetBroadphaseHitRadiusSquared { get; set; }
		[Ordinal(77)] [RED("phase")] public CEnum<EMissileRainPhase> Phase { get; set; }
		[Ordinal(78)] [RED("spiralParams")] public CHandle<gameprojectileSpiralParams> SpiralParams { get; set; }
		[Ordinal(79)] [RED("useSpiralParams")] public CBool UseSpiralParams { get; set; }
		[Ordinal(80)] [RED("randStartVelocity")] public CFloat RandStartVelocity { get; set; }

		public RainMissileProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

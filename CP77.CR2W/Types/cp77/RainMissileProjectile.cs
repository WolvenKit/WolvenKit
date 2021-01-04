using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RainMissileProjectile : BaseProjectile
	{
		[Ordinal(0)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(1)]  [RED("arrived")] public CBool Arrived { get; set; }
		[Ordinal(2)]  [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(3)]  [RED("damage")] public CHandle<gameEffectInstance> Damage { get; set; }
		[Ordinal(4)]  [RED("effect")] public gameEffectRef Effect { get; set; }
		[Ordinal(5)]  [RED("finalTargetOffset")] public Vector4 FinalTargetOffset { get; set; }
		[Ordinal(6)]  [RED("finalTargetPosition")] public Vector4 FinalTargetPosition { get; set; }
		[Ordinal(7)]  [RED("finalTargetPositionCalculationDelay")] public CFloat FinalTargetPositionCalculationDelay { get; set; }
		[Ordinal(8)]  [RED("followTargetInPhase2")] public CBool FollowTargetInPhase2 { get; set; }
		[Ordinal(9)]  [RED("fxInstance")] public CHandle<gameFxInstance> FxInstance { get; set; }
		[Ordinal(10)]  [RED("hasExploded")] public CBool HasExploded { get; set; }
		[Ordinal(11)]  [RED("hit")] public CBool Hit { get; set; }
		[Ordinal(12)]  [RED("initialTargetOffset")] public Vector4 InitialTargetOffset { get; set; }
		[Ordinal(13)]  [RED("initialTargetPosition")] public Vector4 InitialTargetPosition { get; set; }
		[Ordinal(14)]  [RED("landIndicatorFX")] public gameFxResource LandIndicatorFX { get; set; }
		[Ordinal(15)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(16)]  [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(17)]  [RED("missileDBID")] public TweakDBID MissileDBID { get; set; }
		[Ordinal(18)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(19)]  [RED("phase")] public CEnum<EMissileRainPhase> Phase { get; set; }
		[Ordinal(20)]  [RED("phase1Duration")] public CFloat Phase1Duration { get; set; }
		[Ordinal(21)]  [RED("puppetBroadphaseHitRadiusSquared")] public CFloat PuppetBroadphaseHitRadiusSquared { get; set; }
		[Ordinal(22)]  [RED("randStartVelocity")] public CFloat RandStartVelocity { get; set; }
		[Ordinal(23)]  [RED("spawnPosition")] public Vector4 SpawnPosition { get; set; }
		[Ordinal(24)]  [RED("spiralParams")] public CHandle<gameprojectileSpiralParams> SpiralParams { get; set; }
		[Ordinal(25)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(26)]  [RED("targetComponent")] public wCHandle<entIPlacedComponent> TargetComponent { get; set; }
		[Ordinal(27)]  [RED("timeToDestory")] public CFloat TimeToDestory { get; set; }
		[Ordinal(28)]  [RED("useSpiralParams")] public CBool UseSpiralParams { get; set; }
		[Ordinal(29)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }

		public RainMissileProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

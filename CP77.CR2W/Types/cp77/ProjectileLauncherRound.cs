using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProjectileLauncherRound : gameItemObject
	{
		[Ordinal(33)]  [RED("projectileComponent")] public CHandle<gameprojectileComponent> ProjectileComponent { get; set; }
		[Ordinal(34)]  [RED("user")] public wCHandle<gameObject> User { get; set; }
		[Ordinal(35)]  [RED("projectile")] public wCHandle<gameObject> Projectile { get; set; }
		[Ordinal(36)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }
		[Ordinal(37)]  [RED("projectileSpawnPoint")] public Vector4 ProjectileSpawnPoint { get; set; }
		[Ordinal(38)]  [RED("projectilePosition")] public Vector4 ProjectilePosition { get; set; }
		[Ordinal(39)]  [RED("launchMode")] public CEnum<gamedataProjectileLaunchMode> LaunchMode { get; set; }
		[Ordinal(40)]  [RED("projectileLauncherRound")] public CArray<gameSPartSlots> _ProjectileLauncherRound { get; set; }
		[Ordinal(41)]  [RED("partSlots")] public gameSPartSlots PartSlots { get; set; }
		[Ordinal(42)]  [RED("installedPart")] public gameItemID InstalledPart { get; set; }
		[Ordinal(43)]  [RED("initialLaunchVelocity")] public CFloat InitialLaunchVelocity { get; set; }
		[Ordinal(44)]  [RED("projectileLifetime")] public CFloat ProjectileLifetime { get; set; }
		[Ordinal(45)]  [RED("installedProjectile")] public gameItemID InstalledProjectile { get; set; }
		[Ordinal(46)]  [RED("actionType")] public CEnum<ELauncherActionType> ActionType { get; set; }
		[Ordinal(47)]  [RED("attackRecord")] public CHandle<gamedataAttack_Record> AttackRecord { get; set; }
		[Ordinal(48)]  [RED("lifetimeDelayId")] public gameDelayID LifetimeDelayId { get; set; }
		[Ordinal(49)]  [RED("hitEventData")] public CHandle<gameprojectileHitEvent> HitEventData { get; set; }
		[Ordinal(50)]  [RED("projectileTrailName")] public CName ProjectileTrailName { get; set; }
		[Ordinal(51)]  [RED("projectileCollisionEvaluator")] public CHandle<ProjectileLauncherRoundCollisionEvaluator> ProjectileCollisionEvaluator { get; set; }

		public ProjectileLauncherRound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

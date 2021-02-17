using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProjectileLauncherRound : gameItemObject
	{
		[Ordinal(43)] [RED("projectileComponent")] public CHandle<gameprojectileComponent> ProjectileComponent { get; set; }
		[Ordinal(44)] [RED("user")] public wCHandle<gameObject> User { get; set; }
		[Ordinal(45)] [RED("projectile")] public wCHandle<gameObject> Projectile { get; set; }
		[Ordinal(46)] [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }
		[Ordinal(47)] [RED("projectileSpawnPoint")] public Vector4 ProjectileSpawnPoint { get; set; }
		[Ordinal(48)] [RED("projectilePosition")] public Vector4 ProjectilePosition { get; set; }
		[Ordinal(49)] [RED("launchMode")] public CEnum<gamedataProjectileLaunchMode> LaunchMode { get; set; }
		[Ordinal(50)] [RED("projectileLauncherRound")] public CArray<gameSPartSlots> ProjectileLauncherRound_ { get; set; }
		[Ordinal(51)] [RED("partSlots")] public gameSPartSlots PartSlots { get; set; }
		[Ordinal(52)] [RED("installedPart")] public gameItemID InstalledPart { get; set; }
		[Ordinal(53)] [RED("initialLaunchVelocity")] public CFloat InitialLaunchVelocity { get; set; }
		[Ordinal(54)] [RED("projectileLifetime")] public CFloat ProjectileLifetime { get; set; }
		[Ordinal(55)] [RED("installedProjectile")] public gameItemID InstalledProjectile { get; set; }
		[Ordinal(56)] [RED("actionType")] public CEnum<ELauncherActionType> ActionType { get; set; }
		[Ordinal(57)] [RED("attackRecord")] public CHandle<gamedataAttack_Record> AttackRecord { get; set; }
		[Ordinal(58)] [RED("lifetimeDelayId")] public gameDelayID LifetimeDelayId { get; set; }
		[Ordinal(59)] [RED("hitEventData")] public CHandle<gameprojectileHitEvent> HitEventData { get; set; }
		[Ordinal(60)] [RED("projectileTrailName")] public CName ProjectileTrailName { get; set; }
		[Ordinal(61)] [RED("projectileCollisionEvaluator")] public CHandle<ProjectileLauncherRoundCollisionEvaluator> ProjectileCollisionEvaluator { get; set; }

		public ProjectileLauncherRound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

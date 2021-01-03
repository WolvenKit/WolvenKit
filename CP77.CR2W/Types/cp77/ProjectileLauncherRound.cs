using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ProjectileLauncherRound : gameItemObject
	{
		[Ordinal(0)]  [RED("actionType")] public CEnum<ELauncherActionType> ActionType { get; set; }
		[Ordinal(1)]  [RED("attackRecord")] public CHandle<gamedataAttack_Record> AttackRecord { get; set; }
		[Ordinal(2)]  [RED("hitEventData")] public CHandle<gameprojectileHitEvent> HitEventData { get; set; }
		[Ordinal(3)]  [RED("initialLaunchVelocity")] public CFloat InitialLaunchVelocity { get; set; }
		[Ordinal(4)]  [RED("installedPart")] public gameItemID InstalledPart { get; set; }
		[Ordinal(5)]  [RED("installedProjectile")] public gameItemID InstalledProjectile { get; set; }
		[Ordinal(6)]  [RED("launchMode")] public CEnum<gamedataProjectileLaunchMode> LaunchMode { get; set; }
		[Ordinal(7)]  [RED("lifetimeDelayId")] public gameDelayID LifetimeDelayId { get; set; }
		[Ordinal(8)]  [RED("partSlots")] public gameSPartSlots PartSlots { get; set; }
		[Ordinal(9)]  [RED("projectile")] public wCHandle<gameObject> Projectile { get; set; }
		[Ordinal(10)]  [RED("projectileCollisionEvaluator")] public CHandle<ProjectileLauncherRoundCollisionEvaluator> ProjectileCollisionEvaluator { get; set; }
		[Ordinal(11)]  [RED("projectileComponent")] public CHandle<gameprojectileComponent> ProjectileComponent { get; set; }
		[Ordinal(12)]  [RED("projectileLauncherRound")] public CArray<gameSPartSlots> M_ProjectileLauncherRound { get; set; }
		[Ordinal(13)]  [RED("projectileLifetime")] public CFloat ProjectileLifetime { get; set; }
		[Ordinal(14)]  [RED("projectilePosition")] public Vector4 ProjectilePosition { get; set; }
		[Ordinal(15)]  [RED("projectileSpawnPoint")] public Vector4 ProjectileSpawnPoint { get; set; }
		[Ordinal(16)]  [RED("projectileTrailName")] public CName ProjectileTrailName { get; set; }
		[Ordinal(17)]  [RED("user")] public wCHandle<gameObject> User { get; set; }
		[Ordinal(18)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }

		public ProjectileLauncherRound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProjectileLauncherRound : gameItemObject
	{
		private CHandle<gameprojectileComponent> _projectileComponent;
		private wCHandle<gameObject> _user;
		private wCHandle<gameObject> _projectile;
		private wCHandle<gameweaponObject> _weapon;
		private Vector4 _projectileSpawnPoint;
		private Vector4 _projectilePosition;
		private CEnum<gamedataProjectileLaunchMode> _launchMode;
		private CArray<gameSPartSlots> _projectileLauncherRound;
		private gameSPartSlots _partSlots;
		private gameItemID _installedPart;
		private CFloat _initialLaunchVelocity;
		private CFloat _projectileLifetime;
		private gameItemID _installedProjectile;
		private CEnum<ELauncherActionType> _actionType;
		private CHandle<gamedataAttack_Record> _attackRecord;
		private gameDelayID _lifetimeDelayId;
		private CHandle<gameprojectileHitEvent> _hitEventData;
		private CName _projectileTrailName;
		private CHandle<ProjectileLauncherRoundCollisionEvaluator> _projectileCollisionEvaluator;

		[Ordinal(43)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetProperty(ref _projectileComponent);
			set => SetProperty(ref _projectileComponent, value);
		}

		[Ordinal(44)] 
		[RED("user")] 
		public wCHandle<gameObject> User
		{
			get => GetProperty(ref _user);
			set => SetProperty(ref _user, value);
		}

		[Ordinal(45)] 
		[RED("projectile")] 
		public wCHandle<gameObject> Projectile
		{
			get => GetProperty(ref _projectile);
			set => SetProperty(ref _projectile, value);
		}

		[Ordinal(46)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(47)] 
		[RED("projectileSpawnPoint")] 
		public Vector4 ProjectileSpawnPoint
		{
			get => GetProperty(ref _projectileSpawnPoint);
			set => SetProperty(ref _projectileSpawnPoint, value);
		}

		[Ordinal(48)] 
		[RED("projectilePosition")] 
		public Vector4 ProjectilePosition
		{
			get => GetProperty(ref _projectilePosition);
			set => SetProperty(ref _projectilePosition, value);
		}

		[Ordinal(49)] 
		[RED("launchMode")] 
		public CEnum<gamedataProjectileLaunchMode> LaunchMode
		{
			get => GetProperty(ref _launchMode);
			set => SetProperty(ref _launchMode, value);
		}

		[Ordinal(50)] 
		[RED("projectileLauncherRound")] 
		public CArray<gameSPartSlots> ProjectileLauncherRound_
		{
			get => GetProperty(ref _projectileLauncherRound);
			set => SetProperty(ref _projectileLauncherRound, value);
		}

		[Ordinal(51)] 
		[RED("partSlots")] 
		public gameSPartSlots PartSlots
		{
			get => GetProperty(ref _partSlots);
			set => SetProperty(ref _partSlots, value);
		}

		[Ordinal(52)] 
		[RED("installedPart")] 
		public gameItemID InstalledPart
		{
			get => GetProperty(ref _installedPart);
			set => SetProperty(ref _installedPart, value);
		}

		[Ordinal(53)] 
		[RED("initialLaunchVelocity")] 
		public CFloat InitialLaunchVelocity
		{
			get => GetProperty(ref _initialLaunchVelocity);
			set => SetProperty(ref _initialLaunchVelocity, value);
		}

		[Ordinal(54)] 
		[RED("projectileLifetime")] 
		public CFloat ProjectileLifetime
		{
			get => GetProperty(ref _projectileLifetime);
			set => SetProperty(ref _projectileLifetime, value);
		}

		[Ordinal(55)] 
		[RED("installedProjectile")] 
		public gameItemID InstalledProjectile
		{
			get => GetProperty(ref _installedProjectile);
			set => SetProperty(ref _installedProjectile, value);
		}

		[Ordinal(56)] 
		[RED("actionType")] 
		public CEnum<ELauncherActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		[Ordinal(57)] 
		[RED("attackRecord")] 
		public CHandle<gamedataAttack_Record> AttackRecord
		{
			get => GetProperty(ref _attackRecord);
			set => SetProperty(ref _attackRecord, value);
		}

		[Ordinal(58)] 
		[RED("lifetimeDelayId")] 
		public gameDelayID LifetimeDelayId
		{
			get => GetProperty(ref _lifetimeDelayId);
			set => SetProperty(ref _lifetimeDelayId, value);
		}

		[Ordinal(59)] 
		[RED("hitEventData")] 
		public CHandle<gameprojectileHitEvent> HitEventData
		{
			get => GetProperty(ref _hitEventData);
			set => SetProperty(ref _hitEventData, value);
		}

		[Ordinal(60)] 
		[RED("projectileTrailName")] 
		public CName ProjectileTrailName
		{
			get => GetProperty(ref _projectileTrailName);
			set => SetProperty(ref _projectileTrailName, value);
		}

		[Ordinal(61)] 
		[RED("projectileCollisionEvaluator")] 
		public CHandle<ProjectileLauncherRoundCollisionEvaluator> ProjectileCollisionEvaluator
		{
			get => GetProperty(ref _projectileCollisionEvaluator);
			set => SetProperty(ref _projectileCollisionEvaluator, value);
		}

		public ProjectileLauncherRound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

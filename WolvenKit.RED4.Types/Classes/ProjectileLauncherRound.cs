using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProjectileLauncherRound : gameItemObject
	{
		[Ordinal(43)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetPropertyValue<CHandle<gameprojectileComponent>>();
			set => SetPropertyValue<CHandle<gameprojectileComponent>>(value);
		}

		[Ordinal(44)] 
		[RED("user")] 
		public CWeakHandle<gameObject> User
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(45)] 
		[RED("projectile")] 
		public CWeakHandle<gameObject> Projectile
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(46)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(47)] 
		[RED("projectileSpawnPoint")] 
		public Vector4 ProjectileSpawnPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(48)] 
		[RED("projectilePosition")] 
		public Vector4 ProjectilePosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(49)] 
		[RED("launchMode")] 
		public CEnum<gamedataProjectileLaunchMode> LaunchMode
		{
			get => GetPropertyValue<CEnum<gamedataProjectileLaunchMode>>();
			set => SetPropertyValue<CEnum<gamedataProjectileLaunchMode>>(value);
		}

		[Ordinal(50)] 
		[RED("projectileLauncherRound")] 
		public CArray<gameSPartSlots> ProjectileLauncherRound_
		{
			get => GetPropertyValue<CArray<gameSPartSlots>>();
			set => SetPropertyValue<CArray<gameSPartSlots>>(value);
		}

		[Ordinal(51)] 
		[RED("partSlots")] 
		public gameSPartSlots PartSlots
		{
			get => GetPropertyValue<gameSPartSlots>();
			set => SetPropertyValue<gameSPartSlots>(value);
		}

		[Ordinal(52)] 
		[RED("installedPart")] 
		public gameItemID InstalledPart
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(53)] 
		[RED("initialLaunchVelocity")] 
		public CFloat InitialLaunchVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("projectileLifetime")] 
		public CFloat ProjectileLifetime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("installedProjectile")] 
		public gameItemID InstalledProjectile
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(56)] 
		[RED("actionType")] 
		public CEnum<ELauncherActionType> ActionType
		{
			get => GetPropertyValue<CEnum<ELauncherActionType>>();
			set => SetPropertyValue<CEnum<ELauncherActionType>>(value);
		}

		[Ordinal(57)] 
		[RED("attackRecord")] 
		public CHandle<gamedataAttack_Record> AttackRecord
		{
			get => GetPropertyValue<CHandle<gamedataAttack_Record>>();
			set => SetPropertyValue<CHandle<gamedataAttack_Record>>(value);
		}

		[Ordinal(58)] 
		[RED("lifetimeDelayId")] 
		public gameDelayID LifetimeDelayId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(59)] 
		[RED("hitEventData")] 
		public CHandle<gameprojectileHitEvent> HitEventData
		{
			get => GetPropertyValue<CHandle<gameprojectileHitEvent>>();
			set => SetPropertyValue<CHandle<gameprojectileHitEvent>>(value);
		}

		[Ordinal(60)] 
		[RED("projectileTrailName")] 
		public CName ProjectileTrailName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(61)] 
		[RED("projectileCollisionEvaluator")] 
		public CHandle<ProjectileLauncherRoundCollisionEvaluator> ProjectileCollisionEvaluator
		{
			get => GetPropertyValue<CHandle<ProjectileLauncherRoundCollisionEvaluator>>();
			set => SetPropertyValue<CHandle<ProjectileLauncherRoundCollisionEvaluator>>(value);
		}

		public ProjectileLauncherRound()
		{
			ProjectileSpawnPoint = new();
			ProjectilePosition = new();
			ProjectileLauncherRound_ = new();
			PartSlots = new() { InstalledPart = new(), InnerItemData = new() };
			InstalledPart = new();
			InstalledProjectile = new();
			LifetimeDelayId = new();
		}
	}
}

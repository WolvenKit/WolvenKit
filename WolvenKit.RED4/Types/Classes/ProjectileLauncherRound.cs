using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProjectileLauncherRound : gameItemObject
	{
		[Ordinal(38)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetPropertyValue<CHandle<gameprojectileComponent>>();
			set => SetPropertyValue<CHandle<gameprojectileComponent>>(value);
		}

		[Ordinal(39)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetPropertyValue<CHandle<ResourceLibraryComponent>>();
			set => SetPropertyValue<CHandle<ResourceLibraryComponent>>(value);
		}

		[Ordinal(40)] 
		[RED("user")] 
		public CWeakHandle<gameObject> User
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(41)] 
		[RED("projectile")] 
		public CWeakHandle<gameObject> Projectile
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(42)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(43)] 
		[RED("projectileSpawnPoint")] 
		public Vector4 ProjectileSpawnPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(44)] 
		[RED("launchMode")] 
		public CEnum<gamedataProjectileLaunchMode> LaunchMode
		{
			get => GetPropertyValue<CEnum<gamedataProjectileLaunchMode>>();
			set => SetPropertyValue<CEnum<gamedataProjectileLaunchMode>>(value);
		}

		[Ordinal(45)] 
		[RED("initialLaunchVelocity")] 
		public CFloat InitialLaunchVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(46)] 
		[RED("installedProjectile")] 
		public gameItemID InstalledProjectile
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(47)] 
		[RED("actionType")] 
		public CEnum<ELauncherActionType> ActionType
		{
			get => GetPropertyValue<CEnum<ELauncherActionType>>();
			set => SetPropertyValue<CEnum<ELauncherActionType>>(value);
		}

		[Ordinal(48)] 
		[RED("attackRecord")] 
		public CHandle<gamedataAttack_Record> AttackRecord
		{
			get => GetPropertyValue<CHandle<gamedataAttack_Record>>();
			set => SetPropertyValue<CHandle<gamedataAttack_Record>>(value);
		}

		[Ordinal(49)] 
		[RED("releaseRequestDelayID")] 
		public gameDelayID ReleaseRequestDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(50)] 
		[RED("detonateRequestDelayID")] 
		public gameDelayID DetonateRequestDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(51)] 
		[RED("projectileTrailName")] 
		public CName ProjectileTrailName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(52)] 
		[RED("projectileCollisionEvaluator")] 
		public CHandle<ProjectileLauncherRoundCollisionEvaluator> ProjectileCollisionEvaluator
		{
			get => GetPropertyValue<CHandle<ProjectileLauncherRoundCollisionEvaluator>>();
			set => SetPropertyValue<CHandle<ProjectileLauncherRoundCollisionEvaluator>>(value);
		}

		[Ordinal(53)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("isSinking")] 
		public CBool IsSinking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("waterHeight")] 
		public CFloat WaterHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("deepWaterDepth")] 
		public CFloat DeepWaterDepth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("sinkingDetonationDelay")] 
		public CFloat SinkingDetonationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("waterSurfaceImpactImpulseRadius")] 
		public CFloat WaterSurfaceImpactImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("waterSurfaceImpactImpulseStrength")] 
		public CFloat WaterSurfaceImpactImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(60)] 
		[RED("waterDetonationImpulseRadius")] 
		public CFloat WaterDetonationImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(61)] 
		[RED("waterDetonationImpulseStrength")] 
		public CFloat WaterDetonationImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ProjectileLauncherRound()
		{
			ProjectileSpawnPoint = new Vector4();
			InstalledProjectile = new gameItemID();
			ReleaseRequestDelayID = new gameDelayID();
			DetonateRequestDelayID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

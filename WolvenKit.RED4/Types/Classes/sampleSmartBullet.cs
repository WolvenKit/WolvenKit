using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleSmartBullet : BaseProjectile
	{
		[Ordinal(48)] 
		[RED("meshComponent")] 
		public CHandle<entIComponent> MeshComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(49)] 
		[RED("effect")] 
		public gameEffectRef Effect
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(50)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(51)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("lifetime")] 
		public CFloat Lifetime_448
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("bendTimeRatio")] 
		public CFloat BendTimeRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("bendFactor")] 
		public CFloat BendFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("useParabolicPhase")] 
		public CBool UseParabolicPhase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("parabolicVelocityMin")] 
		public CFloat ParabolicVelocityMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("parabolicVelocityMax")] 
		public CFloat ParabolicVelocityMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("parabolicDuration")] 
		public CFloat ParabolicDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("parabolicGravity")] 
		public Vector4 ParabolicGravity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(60)] 
		[RED("spiralParams")] 
		public CHandle<gameprojectileSpiralParams> SpiralParams
		{
			get => GetPropertyValue<CHandle<gameprojectileSpiralParams>>();
			set => SetPropertyValue<CHandle<gameprojectileSpiralParams>>(value);
		}

		[Ordinal(61)] 
		[RED("useSpiralParams")] 
		public CBool UseSpiralParams
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("hit")] 
		public CBool Hit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("trailName")] 
		public CName TrailName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(65)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CHandle<gameStatsSystem>>();
			set => SetPropertyValue<CHandle<gameStatsSystem>>(value);
		}

		[Ordinal(66)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(67)] 
		[RED("parabolicPhaseParams")] 
		public CHandle<gameprojectileParabolicTrajectoryParams> ParabolicPhaseParams
		{
			get => GetPropertyValue<CHandle<gameprojectileParabolicTrajectoryParams>>();
			set => SetPropertyValue<CHandle<gameprojectileParabolicTrajectoryParams>>(value);
		}

		[Ordinal(68)] 
		[RED("followPhaseParams")] 
		public CHandle<gameprojectileFollowCurveTrajectoryParams> FollowPhaseParams
		{
			get => GetPropertyValue<CHandle<gameprojectileFollowCurveTrajectoryParams>>();
			set => SetPropertyValue<CHandle<gameprojectileFollowCurveTrajectoryParams>>(value);
		}

		[Ordinal(69)] 
		[RED("linearPhaseParams")] 
		public CHandle<gameprojectileLinearTrajectoryParams> LinearPhaseParams
		{
			get => GetPropertyValue<CHandle<gameprojectileLinearTrajectoryParams>>();
			set => SetPropertyValue<CHandle<gameprojectileLinearTrajectoryParams>>(value);
		}

		[Ordinal(70)] 
		[RED("targeted")] 
		public CBool Targeted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("trailStarted")] 
		public CBool TrailStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("phase")] 
		public CEnum<ESmartBulletPhase> Phase
		{
			get => GetPropertyValue<CEnum<ESmartBulletPhase>>();
			set => SetPropertyValue<CEnum<ESmartBulletPhase>>(value);
		}

		[Ordinal(73)] 
		[RED("timeInPhase")] 
		public CFloat TimeInPhase
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(74)] 
		[RED("randStartVelocity")] 
		public CFloat RandStartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(75)] 
		[RED("smartGunMissDelay")] 
		public CFloat SmartGunMissDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(76)] 
		[RED("smartGunHitProbability")] 
		public CFloat SmartGunHitProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(77)] 
		[RED("smartGunMissRadius")] 
		public CFloat SmartGunMissRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(78)] 
		[RED("randomWeaponMissChance")] 
		public CFloat RandomWeaponMissChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(79)] 
		[RED("randomTargetMissChance")] 
		public CFloat RandomTargetMissChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(80)] 
		[RED("readyToMiss")] 
		public CBool ReadyToMiss
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(81)] 
		[RED("stopAndDropOnTargetingDisruption")] 
		public CBool StopAndDropOnTargetingDisruption
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(82)] 
		[RED("shouldStopAndDrop")] 
		public CBool ShouldStopAndDrop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(83)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(84)] 
		[RED("ignoredTargetID")] 
		public entEntityID IgnoredTargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(85)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(86)] 
		[RED("weapon")] 
		public CWeakHandle<gameObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(87)] 
		[RED("startPosition")] 
		public Vector4 StartPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(88)] 
		[RED("hasExploded")] 
		public CBool HasExploded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(89)] 
		[RED("attack")] 
		public CHandle<gameIAttack> Attack
		{
			get => GetPropertyValue<CHandle<gameIAttack>>();
			set => SetPropertyValue<CHandle<gameIAttack>>(value);
		}

		[Ordinal(90)] 
		[RED("BulletCollisionEvaluator")] 
		public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator
		{
			get => GetPropertyValue<CHandle<BulletCollisionEvaluator>>();
			set => SetPropertyValue<CHandle<BulletCollisionEvaluator>>(value);
		}

		[Ordinal(91)] 
		[RED("trackedTargetComponent")] 
		public CWeakHandle<gameTargetingComponent> TrackedTargetComponent
		{
			get => GetPropertyValue<CWeakHandle<gameTargetingComponent>>();
			set => SetPropertyValue<CWeakHandle<gameTargetingComponent>>(value);
		}

		public sampleSmartBullet()
		{
			Effect = new gameEffectRef();
			ParabolicGravity = new Vector4();
			Alive = true;
			WeaponID = new entEntityID();
			TargetID = new entEntityID();
			IgnoredTargetID = new entEntityID();
			StartPosition = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

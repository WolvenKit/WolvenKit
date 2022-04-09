using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MonoDisc : BaseProjectile
	{
		[Ordinal(46)] 
		[RED("throwtype")] 
		public CEnum<ThrowType> Throwtype
		{
			get => GetPropertyValue<CEnum<ThrowType>>();
			set => SetPropertyValue<CEnum<ThrowType>>(value);
		}

		[Ordinal(47)] 
		[RED("targetAcquired")] 
		public CBool TargetAcquired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(49)] 
		[RED("disc")] 
		public CWeakHandle<gameObject> Disc
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(50)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(51)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(52)] 
		[RED("discSpawnPoint")] 
		public Vector4 DiscSpawnPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(53)] 
		[RED("discPosition")] 
		public Vector4 DiscPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(54)] 
		[RED("collisionCount")] 
		public CInt32 CollisionCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(55)] 
		[RED("airTime")] 
		public CFloat AirTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("destroyTimer")] 
		public CFloat DestroyTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("returningToPlayer")] 
		public CBool ReturningToPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("catchingPlayer")] 
		public CBool CatchingPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("discCaught")] 
		public CBool DiscCaught
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("discLodgedToSurface")] 
		public CBool DiscLodgedToSurface
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("OnProjectileCaughtCallback")] 
		public CHandle<redCallbackObject> OnProjectileCaughtCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(62)] 
		[RED("wasNPCHit")] 
		public CBool WasNPCHit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		public MonoDisc()
		{
			DiscSpawnPoint = new();
			DiscPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

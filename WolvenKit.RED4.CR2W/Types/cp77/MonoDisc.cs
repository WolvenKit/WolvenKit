using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MonoDisc : BaseProjectile
	{
		private CEnum<ThrowType> _throwtype;
		private CBool _targetAcquired;
		private wCHandle<gameObject> _player;
		private wCHandle<gameObject> _disc;
		private wCHandle<gameObject> _target;
		private wCHandle<gameIBlackboard> _blackboard;
		private Vector4 _discSpawnPoint;
		private Vector4 _discPosition;
		private CInt32 _collisionCount;
		private CFloat _airTime;
		private CFloat _destroyTimer;
		private CBool _returningToPlayer;
		private CBool _catchingPlayer;
		private CBool _discCaught;
		private CBool _discLodgedToSurface;
		private CBool _wasNPCHit;
		private CHandle<entAnimationControllerComponent> _animationController;

		[Ordinal(51)] 
		[RED("throwtype")] 
		public CEnum<ThrowType> Throwtype
		{
			get => GetProperty(ref _throwtype);
			set => SetProperty(ref _throwtype, value);
		}

		[Ordinal(52)] 
		[RED("targetAcquired")] 
		public CBool TargetAcquired
		{
			get => GetProperty(ref _targetAcquired);
			set => SetProperty(ref _targetAcquired, value);
		}

		[Ordinal(53)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(54)] 
		[RED("disc")] 
		public wCHandle<gameObject> Disc
		{
			get => GetProperty(ref _disc);
			set => SetProperty(ref _disc, value);
		}

		[Ordinal(55)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(56)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(57)] 
		[RED("discSpawnPoint")] 
		public Vector4 DiscSpawnPoint
		{
			get => GetProperty(ref _discSpawnPoint);
			set => SetProperty(ref _discSpawnPoint, value);
		}

		[Ordinal(58)] 
		[RED("discPosition")] 
		public Vector4 DiscPosition
		{
			get => GetProperty(ref _discPosition);
			set => SetProperty(ref _discPosition, value);
		}

		[Ordinal(59)] 
		[RED("collisionCount")] 
		public CInt32 CollisionCount
		{
			get => GetProperty(ref _collisionCount);
			set => SetProperty(ref _collisionCount, value);
		}

		[Ordinal(60)] 
		[RED("airTime")] 
		public CFloat AirTime
		{
			get => GetProperty(ref _airTime);
			set => SetProperty(ref _airTime, value);
		}

		[Ordinal(61)] 
		[RED("destroyTimer")] 
		public CFloat DestroyTimer
		{
			get => GetProperty(ref _destroyTimer);
			set => SetProperty(ref _destroyTimer, value);
		}

		[Ordinal(62)] 
		[RED("returningToPlayer")] 
		public CBool ReturningToPlayer
		{
			get => GetProperty(ref _returningToPlayer);
			set => SetProperty(ref _returningToPlayer, value);
		}

		[Ordinal(63)] 
		[RED("catchingPlayer")] 
		public CBool CatchingPlayer
		{
			get => GetProperty(ref _catchingPlayer);
			set => SetProperty(ref _catchingPlayer, value);
		}

		[Ordinal(64)] 
		[RED("discCaught")] 
		public CBool DiscCaught
		{
			get => GetProperty(ref _discCaught);
			set => SetProperty(ref _discCaught, value);
		}

		[Ordinal(65)] 
		[RED("discLodgedToSurface")] 
		public CBool DiscLodgedToSurface
		{
			get => GetProperty(ref _discLodgedToSurface);
			set => SetProperty(ref _discLodgedToSurface, value);
		}

		[Ordinal(66)] 
		[RED("wasNPCHit")] 
		public CBool WasNPCHit
		{
			get => GetProperty(ref _wasNPCHit);
			set => SetProperty(ref _wasNPCHit, value);
		}

		[Ordinal(67)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetProperty(ref _animationController);
			set => SetProperty(ref _animationController, value);
		}

		public MonoDisc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

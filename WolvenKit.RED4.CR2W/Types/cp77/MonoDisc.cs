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
			get
			{
				if (_throwtype == null)
				{
					_throwtype = (CEnum<ThrowType>) CR2WTypeManager.Create("ThrowType", "throwtype", cr2w, this);
				}
				return _throwtype;
			}
			set
			{
				if (_throwtype == value)
				{
					return;
				}
				_throwtype = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("targetAcquired")] 
		public CBool TargetAcquired
		{
			get
			{
				if (_targetAcquired == null)
				{
					_targetAcquired = (CBool) CR2WTypeManager.Create("Bool", "targetAcquired", cr2w, this);
				}
				return _targetAcquired;
			}
			set
			{
				if (_targetAcquired == value)
				{
					return;
				}
				_targetAcquired = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("disc")] 
		public wCHandle<gameObject> Disc
		{
			get
			{
				if (_disc == null)
				{
					_disc = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "disc", cr2w, this);
				}
				return _disc;
			}
			set
			{
				if (_disc == value)
				{
					return;
				}
				_disc = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("discSpawnPoint")] 
		public Vector4 DiscSpawnPoint
		{
			get
			{
				if (_discSpawnPoint == null)
				{
					_discSpawnPoint = (Vector4) CR2WTypeManager.Create("Vector4", "discSpawnPoint", cr2w, this);
				}
				return _discSpawnPoint;
			}
			set
			{
				if (_discSpawnPoint == value)
				{
					return;
				}
				_discSpawnPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("discPosition")] 
		public Vector4 DiscPosition
		{
			get
			{
				if (_discPosition == null)
				{
					_discPosition = (Vector4) CR2WTypeManager.Create("Vector4", "discPosition", cr2w, this);
				}
				return _discPosition;
			}
			set
			{
				if (_discPosition == value)
				{
					return;
				}
				_discPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("collisionCount")] 
		public CInt32 CollisionCount
		{
			get
			{
				if (_collisionCount == null)
				{
					_collisionCount = (CInt32) CR2WTypeManager.Create("Int32", "collisionCount", cr2w, this);
				}
				return _collisionCount;
			}
			set
			{
				if (_collisionCount == value)
				{
					return;
				}
				_collisionCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("airTime")] 
		public CFloat AirTime
		{
			get
			{
				if (_airTime == null)
				{
					_airTime = (CFloat) CR2WTypeManager.Create("Float", "airTime", cr2w, this);
				}
				return _airTime;
			}
			set
			{
				if (_airTime == value)
				{
					return;
				}
				_airTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("destroyTimer")] 
		public CFloat DestroyTimer
		{
			get
			{
				if (_destroyTimer == null)
				{
					_destroyTimer = (CFloat) CR2WTypeManager.Create("Float", "destroyTimer", cr2w, this);
				}
				return _destroyTimer;
			}
			set
			{
				if (_destroyTimer == value)
				{
					return;
				}
				_destroyTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("returningToPlayer")] 
		public CBool ReturningToPlayer
		{
			get
			{
				if (_returningToPlayer == null)
				{
					_returningToPlayer = (CBool) CR2WTypeManager.Create("Bool", "returningToPlayer", cr2w, this);
				}
				return _returningToPlayer;
			}
			set
			{
				if (_returningToPlayer == value)
				{
					return;
				}
				_returningToPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("catchingPlayer")] 
		public CBool CatchingPlayer
		{
			get
			{
				if (_catchingPlayer == null)
				{
					_catchingPlayer = (CBool) CR2WTypeManager.Create("Bool", "catchingPlayer", cr2w, this);
				}
				return _catchingPlayer;
			}
			set
			{
				if (_catchingPlayer == value)
				{
					return;
				}
				_catchingPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("discCaught")] 
		public CBool DiscCaught
		{
			get
			{
				if (_discCaught == null)
				{
					_discCaught = (CBool) CR2WTypeManager.Create("Bool", "discCaught", cr2w, this);
				}
				return _discCaught;
			}
			set
			{
				if (_discCaught == value)
				{
					return;
				}
				_discCaught = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("discLodgedToSurface")] 
		public CBool DiscLodgedToSurface
		{
			get
			{
				if (_discLodgedToSurface == null)
				{
					_discLodgedToSurface = (CBool) CR2WTypeManager.Create("Bool", "discLodgedToSurface", cr2w, this);
				}
				return _discLodgedToSurface;
			}
			set
			{
				if (_discLodgedToSurface == value)
				{
					return;
				}
				_discLodgedToSurface = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("wasNPCHit")] 
		public CBool WasNPCHit
		{
			get
			{
				if (_wasNPCHit == null)
				{
					_wasNPCHit = (CBool) CR2WTypeManager.Create("Bool", "wasNPCHit", cr2w, this);
				}
				return _wasNPCHit;
			}
			set
			{
				if (_wasNPCHit == value)
				{
					return;
				}
				_wasNPCHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get
			{
				if (_animationController == null)
				{
					_animationController = (CHandle<entAnimationControllerComponent>) CR2WTypeManager.Create("handle:entAnimationControllerComponent", "animationController", cr2w, this);
				}
				return _animationController;
			}
			set
			{
				if (_animationController == value)
				{
					return;
				}
				_animationController = value;
				PropertySet(this);
			}
		}

		public MonoDisc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

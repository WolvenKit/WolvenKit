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
			get
			{
				if (_projectileComponent == null)
				{
					_projectileComponent = (CHandle<gameprojectileComponent>) CR2WTypeManager.Create("handle:gameprojectileComponent", "projectileComponent", cr2w, this);
				}
				return _projectileComponent;
			}
			set
			{
				if (_projectileComponent == value)
				{
					return;
				}
				_projectileComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("user")] 
		public wCHandle<gameObject> User
		{
			get
			{
				if (_user == null)
				{
					_user = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "user", cr2w, this);
				}
				return _user;
			}
			set
			{
				if (_user == value)
				{
					return;
				}
				_user = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("projectile")] 
		public wCHandle<gameObject> Projectile
		{
			get
			{
				if (_projectile == null)
				{
					_projectile = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "projectile", cr2w, this);
				}
				return _projectile;
			}
			set
			{
				if (_projectile == value)
				{
					return;
				}
				_projectile = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (wCHandle<gameweaponObject>) CR2WTypeManager.Create("whandle:gameweaponObject", "weapon", cr2w, this);
				}
				return _weapon;
			}
			set
			{
				if (_weapon == value)
				{
					return;
				}
				_weapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("projectileSpawnPoint")] 
		public Vector4 ProjectileSpawnPoint
		{
			get
			{
				if (_projectileSpawnPoint == null)
				{
					_projectileSpawnPoint = (Vector4) CR2WTypeManager.Create("Vector4", "projectileSpawnPoint", cr2w, this);
				}
				return _projectileSpawnPoint;
			}
			set
			{
				if (_projectileSpawnPoint == value)
				{
					return;
				}
				_projectileSpawnPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("projectilePosition")] 
		public Vector4 ProjectilePosition
		{
			get
			{
				if (_projectilePosition == null)
				{
					_projectilePosition = (Vector4) CR2WTypeManager.Create("Vector4", "projectilePosition", cr2w, this);
				}
				return _projectilePosition;
			}
			set
			{
				if (_projectilePosition == value)
				{
					return;
				}
				_projectilePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("launchMode")] 
		public CEnum<gamedataProjectileLaunchMode> LaunchMode
		{
			get
			{
				if (_launchMode == null)
				{
					_launchMode = (CEnum<gamedataProjectileLaunchMode>) CR2WTypeManager.Create("gamedataProjectileLaunchMode", "launchMode", cr2w, this);
				}
				return _launchMode;
			}
			set
			{
				if (_launchMode == value)
				{
					return;
				}
				_launchMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("projectileLauncherRound")] 
		public CArray<gameSPartSlots> ProjectileLauncherRound_
		{
			get
			{
				if (_projectileLauncherRound == null)
				{
					_projectileLauncherRound = (CArray<gameSPartSlots>) CR2WTypeManager.Create("array:gameSPartSlots", "projectileLauncherRound", cr2w, this);
				}
				return _projectileLauncherRound;
			}
			set
			{
				if (_projectileLauncherRound == value)
				{
					return;
				}
				_projectileLauncherRound = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("partSlots")] 
		public gameSPartSlots PartSlots
		{
			get
			{
				if (_partSlots == null)
				{
					_partSlots = (gameSPartSlots) CR2WTypeManager.Create("gameSPartSlots", "partSlots", cr2w, this);
				}
				return _partSlots;
			}
			set
			{
				if (_partSlots == value)
				{
					return;
				}
				_partSlots = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("installedPart")] 
		public gameItemID InstalledPart
		{
			get
			{
				if (_installedPart == null)
				{
					_installedPart = (gameItemID) CR2WTypeManager.Create("gameItemID", "installedPart", cr2w, this);
				}
				return _installedPart;
			}
			set
			{
				if (_installedPart == value)
				{
					return;
				}
				_installedPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("initialLaunchVelocity")] 
		public CFloat InitialLaunchVelocity
		{
			get
			{
				if (_initialLaunchVelocity == null)
				{
					_initialLaunchVelocity = (CFloat) CR2WTypeManager.Create("Float", "initialLaunchVelocity", cr2w, this);
				}
				return _initialLaunchVelocity;
			}
			set
			{
				if (_initialLaunchVelocity == value)
				{
					return;
				}
				_initialLaunchVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("projectileLifetime")] 
		public CFloat ProjectileLifetime
		{
			get
			{
				if (_projectileLifetime == null)
				{
					_projectileLifetime = (CFloat) CR2WTypeManager.Create("Float", "projectileLifetime", cr2w, this);
				}
				return _projectileLifetime;
			}
			set
			{
				if (_projectileLifetime == value)
				{
					return;
				}
				_projectileLifetime = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("installedProjectile")] 
		public gameItemID InstalledProjectile
		{
			get
			{
				if (_installedProjectile == null)
				{
					_installedProjectile = (gameItemID) CR2WTypeManager.Create("gameItemID", "installedProjectile", cr2w, this);
				}
				return _installedProjectile;
			}
			set
			{
				if (_installedProjectile == value)
				{
					return;
				}
				_installedProjectile = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("actionType")] 
		public CEnum<ELauncherActionType> ActionType
		{
			get
			{
				if (_actionType == null)
				{
					_actionType = (CEnum<ELauncherActionType>) CR2WTypeManager.Create("ELauncherActionType", "actionType", cr2w, this);
				}
				return _actionType;
			}
			set
			{
				if (_actionType == value)
				{
					return;
				}
				_actionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("attackRecord")] 
		public CHandle<gamedataAttack_Record> AttackRecord
		{
			get
			{
				if (_attackRecord == null)
				{
					_attackRecord = (CHandle<gamedataAttack_Record>) CR2WTypeManager.Create("handle:gamedataAttack_Record", "attackRecord", cr2w, this);
				}
				return _attackRecord;
			}
			set
			{
				if (_attackRecord == value)
				{
					return;
				}
				_attackRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("lifetimeDelayId")] 
		public gameDelayID LifetimeDelayId
		{
			get
			{
				if (_lifetimeDelayId == null)
				{
					_lifetimeDelayId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "lifetimeDelayId", cr2w, this);
				}
				return _lifetimeDelayId;
			}
			set
			{
				if (_lifetimeDelayId == value)
				{
					return;
				}
				_lifetimeDelayId = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("hitEventData")] 
		public CHandle<gameprojectileHitEvent> HitEventData
		{
			get
			{
				if (_hitEventData == null)
				{
					_hitEventData = (CHandle<gameprojectileHitEvent>) CR2WTypeManager.Create("handle:gameprojectileHitEvent", "hitEventData", cr2w, this);
				}
				return _hitEventData;
			}
			set
			{
				if (_hitEventData == value)
				{
					return;
				}
				_hitEventData = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("projectileTrailName")] 
		public CName ProjectileTrailName
		{
			get
			{
				if (_projectileTrailName == null)
				{
					_projectileTrailName = (CName) CR2WTypeManager.Create("CName", "projectileTrailName", cr2w, this);
				}
				return _projectileTrailName;
			}
			set
			{
				if (_projectileTrailName == value)
				{
					return;
				}
				_projectileTrailName = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("projectileCollisionEvaluator")] 
		public CHandle<ProjectileLauncherRoundCollisionEvaluator> ProjectileCollisionEvaluator
		{
			get
			{
				if (_projectileCollisionEvaluator == null)
				{
					_projectileCollisionEvaluator = (CHandle<ProjectileLauncherRoundCollisionEvaluator>) CR2WTypeManager.Create("handle:ProjectileLauncherRoundCollisionEvaluator", "projectileCollisionEvaluator", cr2w, this);
				}
				return _projectileCollisionEvaluator;
			}
			set
			{
				if (_projectileCollisionEvaluator == value)
				{
					return;
				}
				_projectileCollisionEvaluator = value;
				PropertySet(this);
			}
		}

		public ProjectileLauncherRound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseProjectile : gameItemObject
	{
		private CHandle<gameprojectileComponent> _projectileComponent;
		private wCHandle<gameObject> _user;
		private wCHandle<gameObject> _projectile;
		private Vector4 _projectileSpawnPoint;
		private Vector4 _projectilePosition;
		private CFloat _initialLaunchVelocity;
		private CFloat _lifeTime;
		private CString _tweakDBPath;

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

		[Ordinal(47)] 
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

		[Ordinal(48)] 
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

		[Ordinal(49)] 
		[RED("lifeTime")] 
		public CFloat LifeTime
		{
			get
			{
				if (_lifeTime == null)
				{
					_lifeTime = (CFloat) CR2WTypeManager.Create("Float", "lifeTime", cr2w, this);
				}
				return _lifeTime;
			}
			set
			{
				if (_lifeTime == value)
				{
					return;
				}
				_lifeTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("tweakDBPath")] 
		public CString TweakDBPath
		{
			get
			{
				if (_tweakDBPath == null)
				{
					_tweakDBPath = (CString) CR2WTypeManager.Create("String", "tweakDBPath", cr2w, this);
				}
				return _tweakDBPath;
			}
			set
			{
				if (_tweakDBPath == value)
				{
					return;
				}
				_tweakDBPath = value;
				PropertySet(this);
			}
		}

		public BaseProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

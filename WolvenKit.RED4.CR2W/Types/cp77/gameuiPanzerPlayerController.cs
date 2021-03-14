using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerPlayerController : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		private CFloat _bulletSpeed;
		private Vector2 _bulletSpawnOffset;
		private CName _bulletLibraryname;
		private CFloat _shootInterval;
		private CName _gameLayerName;
		private CName _invulnerableAnimationName;
		private CName _explosionLibraryName;

		[Ordinal(1)] 
		[RED("bulletSpeed")] 
		public CFloat BulletSpeed
		{
			get
			{
				if (_bulletSpeed == null)
				{
					_bulletSpeed = (CFloat) CR2WTypeManager.Create("Float", "bulletSpeed", cr2w, this);
				}
				return _bulletSpeed;
			}
			set
			{
				if (_bulletSpeed == value)
				{
					return;
				}
				_bulletSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bulletSpawnOffset")] 
		public Vector2 BulletSpawnOffset
		{
			get
			{
				if (_bulletSpawnOffset == null)
				{
					_bulletSpawnOffset = (Vector2) CR2WTypeManager.Create("Vector2", "bulletSpawnOffset", cr2w, this);
				}
				return _bulletSpawnOffset;
			}
			set
			{
				if (_bulletSpawnOffset == value)
				{
					return;
				}
				_bulletSpawnOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bulletLibraryname")] 
		public CName BulletLibraryname
		{
			get
			{
				if (_bulletLibraryname == null)
				{
					_bulletLibraryname = (CName) CR2WTypeManager.Create("CName", "bulletLibraryname", cr2w, this);
				}
				return _bulletLibraryname;
			}
			set
			{
				if (_bulletLibraryname == value)
				{
					return;
				}
				_bulletLibraryname = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("shootInterval")] 
		public CFloat ShootInterval
		{
			get
			{
				if (_shootInterval == null)
				{
					_shootInterval = (CFloat) CR2WTypeManager.Create("Float", "shootInterval", cr2w, this);
				}
				return _shootInterval;
			}
			set
			{
				if (_shootInterval == value)
				{
					return;
				}
				_shootInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("gameLayerName")] 
		public CName GameLayerName
		{
			get
			{
				if (_gameLayerName == null)
				{
					_gameLayerName = (CName) CR2WTypeManager.Create("CName", "gameLayerName", cr2w, this);
				}
				return _gameLayerName;
			}
			set
			{
				if (_gameLayerName == value)
				{
					return;
				}
				_gameLayerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("invulnerableAnimationName")] 
		public CName InvulnerableAnimationName
		{
			get
			{
				if (_invulnerableAnimationName == null)
				{
					_invulnerableAnimationName = (CName) CR2WTypeManager.Create("CName", "invulnerableAnimationName", cr2w, this);
				}
				return _invulnerableAnimationName;
			}
			set
			{
				if (_invulnerableAnimationName == value)
				{
					return;
				}
				_invulnerableAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("explosionLibraryName")] 
		public CName ExplosionLibraryName
		{
			get
			{
				if (_explosionLibraryName == null)
				{
					_explosionLibraryName = (CName) CR2WTypeManager.Create("CName", "explosionLibraryName", cr2w, this);
				}
				return _explosionLibraryName;
			}
			set
			{
				if (_explosionLibraryName == value)
				{
					return;
				}
				_explosionLibraryName = value;
				PropertySet(this);
			}
		}

		public gameuiPanzerPlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

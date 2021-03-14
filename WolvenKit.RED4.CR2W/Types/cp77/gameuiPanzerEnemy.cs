using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerEnemy : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		private CUInt32 _noBonusChanceCoeff;
		private CInt32 _health;
		private CUInt32 _score;
		private Vector2 _shootPoint;
		private CFloat _bulletSpeed;
		private CName _gameLayerName;
		private CName _explosionLibraryName;
		private CName _bulletLibraryName;
		private CName _lifeBonusLibraryName;
		private CUInt32 _lifeBonusChanceCoeff;
		private CName _scoreBonusLibraryName;
		private CUInt32 _scoreBonusChanceCoeff;
		private CUInt32 _score50ChanceCoeff;
		private CUInt32 _score100ChanceCoeff;
		private CUInt32 _score200ChanceCoeff;

		[Ordinal(1)] 
		[RED("noBonusChanceCoeff")] 
		public CUInt32 NoBonusChanceCoeff
		{
			get
			{
				if (_noBonusChanceCoeff == null)
				{
					_noBonusChanceCoeff = (CUInt32) CR2WTypeManager.Create("Uint32", "noBonusChanceCoeff", cr2w, this);
				}
				return _noBonusChanceCoeff;
			}
			set
			{
				if (_noBonusChanceCoeff == value)
				{
					return;
				}
				_noBonusChanceCoeff = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("health")] 
		public CInt32 Health
		{
			get
			{
				if (_health == null)
				{
					_health = (CInt32) CR2WTypeManager.Create("Int32", "health", cr2w, this);
				}
				return _health;
			}
			set
			{
				if (_health == value)
				{
					return;
				}
				_health = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("score")] 
		public CUInt32 Score
		{
			get
			{
				if (_score == null)
				{
					_score = (CUInt32) CR2WTypeManager.Create("Uint32", "score", cr2w, this);
				}
				return _score;
			}
			set
			{
				if (_score == value)
				{
					return;
				}
				_score = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("shootPoint")] 
		public Vector2 ShootPoint
		{
			get
			{
				if (_shootPoint == null)
				{
					_shootPoint = (Vector2) CR2WTypeManager.Create("Vector2", "shootPoint", cr2w, this);
				}
				return _shootPoint;
			}
			set
			{
				if (_shootPoint == value)
				{
					return;
				}
				_shootPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(8)] 
		[RED("bulletLibraryName")] 
		public CName BulletLibraryName
		{
			get
			{
				if (_bulletLibraryName == null)
				{
					_bulletLibraryName = (CName) CR2WTypeManager.Create("CName", "bulletLibraryName", cr2w, this);
				}
				return _bulletLibraryName;
			}
			set
			{
				if (_bulletLibraryName == value)
				{
					return;
				}
				_bulletLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lifeBonusLibraryName")] 
		public CName LifeBonusLibraryName
		{
			get
			{
				if (_lifeBonusLibraryName == null)
				{
					_lifeBonusLibraryName = (CName) CR2WTypeManager.Create("CName", "lifeBonusLibraryName", cr2w, this);
				}
				return _lifeBonusLibraryName;
			}
			set
			{
				if (_lifeBonusLibraryName == value)
				{
					return;
				}
				_lifeBonusLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("lifeBonusChanceCoeff")] 
		public CUInt32 LifeBonusChanceCoeff
		{
			get
			{
				if (_lifeBonusChanceCoeff == null)
				{
					_lifeBonusChanceCoeff = (CUInt32) CR2WTypeManager.Create("Uint32", "lifeBonusChanceCoeff", cr2w, this);
				}
				return _lifeBonusChanceCoeff;
			}
			set
			{
				if (_lifeBonusChanceCoeff == value)
				{
					return;
				}
				_lifeBonusChanceCoeff = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("scoreBonusLibraryName")] 
		public CName ScoreBonusLibraryName
		{
			get
			{
				if (_scoreBonusLibraryName == null)
				{
					_scoreBonusLibraryName = (CName) CR2WTypeManager.Create("CName", "scoreBonusLibraryName", cr2w, this);
				}
				return _scoreBonusLibraryName;
			}
			set
			{
				if (_scoreBonusLibraryName == value)
				{
					return;
				}
				_scoreBonusLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("scoreBonusChanceCoeff")] 
		public CUInt32 ScoreBonusChanceCoeff
		{
			get
			{
				if (_scoreBonusChanceCoeff == null)
				{
					_scoreBonusChanceCoeff = (CUInt32) CR2WTypeManager.Create("Uint32", "scoreBonusChanceCoeff", cr2w, this);
				}
				return _scoreBonusChanceCoeff;
			}
			set
			{
				if (_scoreBonusChanceCoeff == value)
				{
					return;
				}
				_scoreBonusChanceCoeff = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("score50ChanceCoeff")] 
		public CUInt32 Score50ChanceCoeff
		{
			get
			{
				if (_score50ChanceCoeff == null)
				{
					_score50ChanceCoeff = (CUInt32) CR2WTypeManager.Create("Uint32", "score50ChanceCoeff", cr2w, this);
				}
				return _score50ChanceCoeff;
			}
			set
			{
				if (_score50ChanceCoeff == value)
				{
					return;
				}
				_score50ChanceCoeff = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("score100ChanceCoeff")] 
		public CUInt32 Score100ChanceCoeff
		{
			get
			{
				if (_score100ChanceCoeff == null)
				{
					_score100ChanceCoeff = (CUInt32) CR2WTypeManager.Create("Uint32", "score100ChanceCoeff", cr2w, this);
				}
				return _score100ChanceCoeff;
			}
			set
			{
				if (_score100ChanceCoeff == value)
				{
					return;
				}
				_score100ChanceCoeff = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("score200ChanceCoeff")] 
		public CUInt32 Score200ChanceCoeff
		{
			get
			{
				if (_score200ChanceCoeff == null)
				{
					_score200ChanceCoeff = (CUInt32) CR2WTypeManager.Create("Uint32", "score200ChanceCoeff", cr2w, this);
				}
				return _score200ChanceCoeff;
			}
			set
			{
				if (_score200ChanceCoeff == value)
				{
					return;
				}
				_score200ChanceCoeff = value;
				PropertySet(this);
			}
		}

		public gameuiPanzerEnemy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceGameLogicController : gameuiSideScrollerMiniGameLogicController
	{
		private CFloat _jumpAcceleration;
		private CFloat _jumpCancelAcceleration;
		private CFloat _gravity;
		private Vector2 _playerSpawnPoint;
		private CFloat _pixelsPerScore;
		private CFloat _invincibilityTime;
		private CFloat _maxSpeedMultiplier;
		private CFloat _multiplierPerScore;
		private inkWidgetReference _house;
		private inkWidgetReference _ground;
		private CName _startAnimation;
		private CName _deathAnimation;
		private CArray<gameuiRoachRaceChunkLayer> _layers;
		private CName _damageAnimation;
		private CName _healAnimation;
		private inkTextWidgetReference _healthText;
		private inkTextWidgetReference _scoreText;
		private inkTextWidgetReference _scoreMultiplierText;
		private CInt32 _previousHealth;

		[Ordinal(10)] 
		[RED("jumpAcceleration")] 
		public CFloat JumpAcceleration
		{
			get
			{
				if (_jumpAcceleration == null)
				{
					_jumpAcceleration = (CFloat) CR2WTypeManager.Create("Float", "jumpAcceleration", cr2w, this);
				}
				return _jumpAcceleration;
			}
			set
			{
				if (_jumpAcceleration == value)
				{
					return;
				}
				_jumpAcceleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("jumpCancelAcceleration")] 
		public CFloat JumpCancelAcceleration
		{
			get
			{
				if (_jumpCancelAcceleration == null)
				{
					_jumpCancelAcceleration = (CFloat) CR2WTypeManager.Create("Float", "jumpCancelAcceleration", cr2w, this);
				}
				return _jumpCancelAcceleration;
			}
			set
			{
				if (_jumpCancelAcceleration == value)
				{
					return;
				}
				_jumpCancelAcceleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("gravity")] 
		public CFloat Gravity
		{
			get
			{
				if (_gravity == null)
				{
					_gravity = (CFloat) CR2WTypeManager.Create("Float", "gravity", cr2w, this);
				}
				return _gravity;
			}
			set
			{
				if (_gravity == value)
				{
					return;
				}
				_gravity = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("playerSpawnPoint")] 
		public Vector2 PlayerSpawnPoint
		{
			get
			{
				if (_playerSpawnPoint == null)
				{
					_playerSpawnPoint = (Vector2) CR2WTypeManager.Create("Vector2", "playerSpawnPoint", cr2w, this);
				}
				return _playerSpawnPoint;
			}
			set
			{
				if (_playerSpawnPoint == value)
				{
					return;
				}
				_playerSpawnPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("pixelsPerScore")] 
		public CFloat PixelsPerScore
		{
			get
			{
				if (_pixelsPerScore == null)
				{
					_pixelsPerScore = (CFloat) CR2WTypeManager.Create("Float", "pixelsPerScore", cr2w, this);
				}
				return _pixelsPerScore;
			}
			set
			{
				if (_pixelsPerScore == value)
				{
					return;
				}
				_pixelsPerScore = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("invincibilityTime")] 
		public CFloat InvincibilityTime
		{
			get
			{
				if (_invincibilityTime == null)
				{
					_invincibilityTime = (CFloat) CR2WTypeManager.Create("Float", "invincibilityTime", cr2w, this);
				}
				return _invincibilityTime;
			}
			set
			{
				if (_invincibilityTime == value)
				{
					return;
				}
				_invincibilityTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("maxSpeedMultiplier")] 
		public CFloat MaxSpeedMultiplier
		{
			get
			{
				if (_maxSpeedMultiplier == null)
				{
					_maxSpeedMultiplier = (CFloat) CR2WTypeManager.Create("Float", "maxSpeedMultiplier", cr2w, this);
				}
				return _maxSpeedMultiplier;
			}
			set
			{
				if (_maxSpeedMultiplier == value)
				{
					return;
				}
				_maxSpeedMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("multiplierPerScore")] 
		public CFloat MultiplierPerScore
		{
			get
			{
				if (_multiplierPerScore == null)
				{
					_multiplierPerScore = (CFloat) CR2WTypeManager.Create("Float", "multiplierPerScore", cr2w, this);
				}
				return _multiplierPerScore;
			}
			set
			{
				if (_multiplierPerScore == value)
				{
					return;
				}
				_multiplierPerScore = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("house")] 
		public inkWidgetReference House
		{
			get
			{
				if (_house == null)
				{
					_house = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "house", cr2w, this);
				}
				return _house;
			}
			set
			{
				if (_house == value)
				{
					return;
				}
				_house = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("ground")] 
		public inkWidgetReference Ground
		{
			get
			{
				if (_ground == null)
				{
					_ground = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ground", cr2w, this);
				}
				return _ground;
			}
			set
			{
				if (_ground == value)
				{
					return;
				}
				_ground = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("startAnimation")] 
		public CName StartAnimation
		{
			get
			{
				if (_startAnimation == null)
				{
					_startAnimation = (CName) CR2WTypeManager.Create("CName", "startAnimation", cr2w, this);
				}
				return _startAnimation;
			}
			set
			{
				if (_startAnimation == value)
				{
					return;
				}
				_startAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("deathAnimation")] 
		public CName DeathAnimation
		{
			get
			{
				if (_deathAnimation == null)
				{
					_deathAnimation = (CName) CR2WTypeManager.Create("CName", "deathAnimation", cr2w, this);
				}
				return _deathAnimation;
			}
			set
			{
				if (_deathAnimation == value)
				{
					return;
				}
				_deathAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("layers")] 
		public CArray<gameuiRoachRaceChunkLayer> Layers
		{
			get
			{
				if (_layers == null)
				{
					_layers = (CArray<gameuiRoachRaceChunkLayer>) CR2WTypeManager.Create("array:gameuiRoachRaceChunkLayer", "layers", cr2w, this);
				}
				return _layers;
			}
			set
			{
				if (_layers == value)
				{
					return;
				}
				_layers = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("damageAnimation")] 
		public CName DamageAnimation
		{
			get
			{
				if (_damageAnimation == null)
				{
					_damageAnimation = (CName) CR2WTypeManager.Create("CName", "damageAnimation", cr2w, this);
				}
				return _damageAnimation;
			}
			set
			{
				if (_damageAnimation == value)
				{
					return;
				}
				_damageAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("healAnimation")] 
		public CName HealAnimation
		{
			get
			{
				if (_healAnimation == null)
				{
					_healAnimation = (CName) CR2WTypeManager.Create("CName", "healAnimation", cr2w, this);
				}
				return _healAnimation;
			}
			set
			{
				if (_healAnimation == value)
				{
					return;
				}
				_healAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("healthText")] 
		public inkTextWidgetReference HealthText
		{
			get
			{
				if (_healthText == null)
				{
					_healthText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "healthText", cr2w, this);
				}
				return _healthText;
			}
			set
			{
				if (_healthText == value)
				{
					return;
				}
				_healthText = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("scoreText")] 
		public inkTextWidgetReference ScoreText
		{
			get
			{
				if (_scoreText == null)
				{
					_scoreText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "scoreText", cr2w, this);
				}
				return _scoreText;
			}
			set
			{
				if (_scoreText == value)
				{
					return;
				}
				_scoreText = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("scoreMultiplierText")] 
		public inkTextWidgetReference ScoreMultiplierText
		{
			get
			{
				if (_scoreMultiplierText == null)
				{
					_scoreMultiplierText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "scoreMultiplierText", cr2w, this);
				}
				return _scoreMultiplierText;
			}
			set
			{
				if (_scoreMultiplierText == value)
				{
					return;
				}
				_scoreMultiplierText = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get
			{
				if (_previousHealth == null)
				{
					_previousHealth = (CInt32) CR2WTypeManager.Create("Int32", "previousHealth", cr2w, this);
				}
				return _previousHealth;
			}
			set
			{
				if (_previousHealth == value)
				{
					return;
				}
				_previousHealth = value;
				PropertySet(this);
			}
		}

		public gameuiRoachRaceGameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

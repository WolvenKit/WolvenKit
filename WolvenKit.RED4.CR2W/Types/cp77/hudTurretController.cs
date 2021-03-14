using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudTurretController : gameuiHUDGameController
	{
		private inkTextWidgetReference _date;
		private inkTextWidgetReference _timer;
		private inkTextWidgetReference _cameraID;
		private inkTextWidgetReference _healthStatus;
		private inkTextWidgetReference _messageText;
		private inkTextWidgetReference _pitchFluff;
		private inkTextWidgetReference _yawFluff;
		private inkWidgetReference _leftPart;
		private inkWidgetReference _rightPart;
		private CFloat _offsetLeft;
		private CFloat _offsetRight;
		private GameTime _currentTime;
		private CHandle<gameIBlackboard> _bbPlayerStats;
		private CUInt32 _bbPlayerEventId;
		private CInt32 _currentHealth;
		private CInt32 _previousHealth;
		private CInt32 _maximumHealth;
		private wCHandle<gameObject> _playerObject;
		private wCHandle<gameObject> _playerPuppet;
		private inkanimPlaybackOptions _optionIntro;
		private inkanimPlaybackOptions _optionMalfunction;
		private ScriptGameInstance _gameInstance;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(9)] 
		[RED("Date")] 
		public inkTextWidgetReference Date
		{
			get
			{
				if (_date == null)
				{
					_date = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Date", cr2w, this);
				}
				return _date;
			}
			set
			{
				if (_date == value)
				{
					return;
				}
				_date = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("Timer")] 
		public inkTextWidgetReference Timer
		{
			get
			{
				if (_timer == null)
				{
					_timer = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Timer", cr2w, this);
				}
				return _timer;
			}
			set
			{
				if (_timer == value)
				{
					return;
				}
				_timer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("CameraID")] 
		public inkTextWidgetReference CameraID
		{
			get
			{
				if (_cameraID == null)
				{
					_cameraID = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "CameraID", cr2w, this);
				}
				return _cameraID;
			}
			set
			{
				if (_cameraID == value)
				{
					return;
				}
				_cameraID = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("healthStatus")] 
		public inkTextWidgetReference HealthStatus
		{
			get
			{
				if (_healthStatus == null)
				{
					_healthStatus = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "healthStatus", cr2w, this);
				}
				return _healthStatus;
			}
			set
			{
				if (_healthStatus == value)
				{
					return;
				}
				_healthStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("MessageText")] 
		public inkTextWidgetReference MessageText
		{
			get
			{
				if (_messageText == null)
				{
					_messageText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "MessageText", cr2w, this);
				}
				return _messageText;
			}
			set
			{
				if (_messageText == value)
				{
					return;
				}
				_messageText = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("pitchFluff")] 
		public inkTextWidgetReference PitchFluff
		{
			get
			{
				if (_pitchFluff == null)
				{
					_pitchFluff = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "pitchFluff", cr2w, this);
				}
				return _pitchFluff;
			}
			set
			{
				if (_pitchFluff == value)
				{
					return;
				}
				_pitchFluff = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("yawFluff")] 
		public inkTextWidgetReference YawFluff
		{
			get
			{
				if (_yawFluff == null)
				{
					_yawFluff = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "yawFluff", cr2w, this);
				}
				return _yawFluff;
			}
			set
			{
				if (_yawFluff == value)
				{
					return;
				}
				_yawFluff = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get
			{
				if (_leftPart == null)
				{
					_leftPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "leftPart", cr2w, this);
				}
				return _leftPart;
			}
			set
			{
				if (_leftPart == value)
				{
					return;
				}
				_leftPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get
			{
				if (_rightPart == null)
				{
					_rightPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rightPart", cr2w, this);
				}
				return _rightPart;
			}
			set
			{
				if (_rightPart == value)
				{
					return;
				}
				_rightPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("offsetLeft")] 
		public CFloat OffsetLeft
		{
			get
			{
				if (_offsetLeft == null)
				{
					_offsetLeft = (CFloat) CR2WTypeManager.Create("Float", "offsetLeft", cr2w, this);
				}
				return _offsetLeft;
			}
			set
			{
				if (_offsetLeft == value)
				{
					return;
				}
				_offsetLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("offsetRight")] 
		public CFloat OffsetRight
		{
			get
			{
				if (_offsetRight == null)
				{
					_offsetRight = (CFloat) CR2WTypeManager.Create("Float", "offsetRight", cr2w, this);
				}
				return _offsetRight;
			}
			set
			{
				if (_offsetRight == value)
				{
					return;
				}
				_offsetRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get
			{
				if (_currentTime == null)
				{
					_currentTime = (GameTime) CR2WTypeManager.Create("GameTime", "currentTime", cr2w, this);
				}
				return _currentTime;
			}
			set
			{
				if (_currentTime == value)
				{
					return;
				}
				_currentTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("bbPlayerStats")] 
		public CHandle<gameIBlackboard> BbPlayerStats
		{
			get
			{
				if (_bbPlayerStats == null)
				{
					_bbPlayerStats = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbPlayerStats", cr2w, this);
				}
				return _bbPlayerStats;
			}
			set
			{
				if (_bbPlayerStats == value)
				{
					return;
				}
				_bbPlayerStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("bbPlayerEventId")] 
		public CUInt32 BbPlayerEventId
		{
			get
			{
				if (_bbPlayerEventId == null)
				{
					_bbPlayerEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbPlayerEventId", cr2w, this);
				}
				return _bbPlayerEventId;
			}
			set
			{
				if (_bbPlayerEventId == value)
				{
					return;
				}
				_bbPlayerEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get
			{
				if (_currentHealth == null)
				{
					_currentHealth = (CInt32) CR2WTypeManager.Create("Int32", "currentHealth", cr2w, this);
				}
				return _currentHealth;
			}
			set
			{
				if (_currentHealth == value)
				{
					return;
				}
				_currentHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
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

		[Ordinal(25)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get
			{
				if (_maximumHealth == null)
				{
					_maximumHealth = (CInt32) CR2WTypeManager.Create("Int32", "maximumHealth", cr2w, this);
				}
				return _maximumHealth;
			}
			set
			{
				if (_maximumHealth == value)
				{
					return;
				}
				_maximumHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("playerObject")] 
		public wCHandle<gameObject> PlayerObject
		{
			get
			{
				if (_playerObject == null)
				{
					_playerObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerObject", cr2w, this);
				}
				return _playerObject;
			}
			set
			{
				if (_playerObject == value)
				{
					return;
				}
				_playerObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("optionIntro")] 
		public inkanimPlaybackOptions OptionIntro
		{
			get
			{
				if (_optionIntro == null)
				{
					_optionIntro = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "optionIntro", cr2w, this);
				}
				return _optionIntro;
			}
			set
			{
				if (_optionIntro == value)
				{
					return;
				}
				_optionIntro = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("optionMalfunction")] 
		public inkanimPlaybackOptions OptionMalfunction
		{
			get
			{
				if (_optionMalfunction == null)
				{
					_optionMalfunction = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "optionMalfunction", cr2w, this);
				}
				return _optionMalfunction;
			}
			set
			{
				if (_optionMalfunction == value)
				{
					return;
				}
				_optionMalfunction = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		public hudTurretController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

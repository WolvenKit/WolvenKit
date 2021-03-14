using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerGameLogicController : gameuiSideScrollerMiniGameLogicControllerAdvanced
	{
		private CFloat _gameOverDelay;
		private CName _mainMenuLibraryName;
		private CName _scoreboardLibraryName;
		private CName _panelsLayer;
		private CName _gameLayer;
		private CName _cloudsLayer;
		private CName _backgroundLibraryName;
		private CArray<CName> _cloudsLibraryNames;
		private CFloat _minCloudSpawnInterval;
		private CFloat _maxCloudSpawnInterval;
		private CFloat _minCloudSpeed;
		private CFloat _maxCloudSpeed;
		private inkTextWidgetReference _scoreCounter;
		private inkTextWidgetReference _livesCounter;
		private CName _moveUpKey;
		private CName _moveDownKey;
		private CName _moveLeftKey;
		private CName _moveRightKey;
		private CName _shootKey;
		private CName _backKey;
		private CName _submitKey;
		private CFloat _axisDeadZone;
		private CName _moveXAxis;
		private CName _moveYAxis;
		private CName _shootAxis;
		private CName _droneLibraryName;
		private CFloat _minDroneSpawnInterval;
		private CFloat _maxDroneSpawnInterval;
		private CName _avLibraryName;
		private CFloat _minAvSpawnInterval;
		private CFloat _maxAvSpawnInterval;

		[Ordinal(9)] 
		[RED("gameOverDelay")] 
		public CFloat GameOverDelay
		{
			get
			{
				if (_gameOverDelay == null)
				{
					_gameOverDelay = (CFloat) CR2WTypeManager.Create("Float", "gameOverDelay", cr2w, this);
				}
				return _gameOverDelay;
			}
			set
			{
				if (_gameOverDelay == value)
				{
					return;
				}
				_gameOverDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("mainMenuLibraryName")] 
		public CName MainMenuLibraryName
		{
			get
			{
				if (_mainMenuLibraryName == null)
				{
					_mainMenuLibraryName = (CName) CR2WTypeManager.Create("CName", "mainMenuLibraryName", cr2w, this);
				}
				return _mainMenuLibraryName;
			}
			set
			{
				if (_mainMenuLibraryName == value)
				{
					return;
				}
				_mainMenuLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("scoreboardLibraryName")] 
		public CName ScoreboardLibraryName
		{
			get
			{
				if (_scoreboardLibraryName == null)
				{
					_scoreboardLibraryName = (CName) CR2WTypeManager.Create("CName", "scoreboardLibraryName", cr2w, this);
				}
				return _scoreboardLibraryName;
			}
			set
			{
				if (_scoreboardLibraryName == value)
				{
					return;
				}
				_scoreboardLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("panelsLayer")] 
		public CName PanelsLayer
		{
			get
			{
				if (_panelsLayer == null)
				{
					_panelsLayer = (CName) CR2WTypeManager.Create("CName", "panelsLayer", cr2w, this);
				}
				return _panelsLayer;
			}
			set
			{
				if (_panelsLayer == value)
				{
					return;
				}
				_panelsLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("gameLayer")] 
		public CName GameLayer
		{
			get
			{
				if (_gameLayer == null)
				{
					_gameLayer = (CName) CR2WTypeManager.Create("CName", "gameLayer", cr2w, this);
				}
				return _gameLayer;
			}
			set
			{
				if (_gameLayer == value)
				{
					return;
				}
				_gameLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("cloudsLayer")] 
		public CName CloudsLayer
		{
			get
			{
				if (_cloudsLayer == null)
				{
					_cloudsLayer = (CName) CR2WTypeManager.Create("CName", "cloudsLayer", cr2w, this);
				}
				return _cloudsLayer;
			}
			set
			{
				if (_cloudsLayer == value)
				{
					return;
				}
				_cloudsLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("backgroundLibraryName")] 
		public CName BackgroundLibraryName
		{
			get
			{
				if (_backgroundLibraryName == null)
				{
					_backgroundLibraryName = (CName) CR2WTypeManager.Create("CName", "backgroundLibraryName", cr2w, this);
				}
				return _backgroundLibraryName;
			}
			set
			{
				if (_backgroundLibraryName == value)
				{
					return;
				}
				_backgroundLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("cloudsLibraryNames")] 
		public CArray<CName> CloudsLibraryNames
		{
			get
			{
				if (_cloudsLibraryNames == null)
				{
					_cloudsLibraryNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "cloudsLibraryNames", cr2w, this);
				}
				return _cloudsLibraryNames;
			}
			set
			{
				if (_cloudsLibraryNames == value)
				{
					return;
				}
				_cloudsLibraryNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("minCloudSpawnInterval")] 
		public CFloat MinCloudSpawnInterval
		{
			get
			{
				if (_minCloudSpawnInterval == null)
				{
					_minCloudSpawnInterval = (CFloat) CR2WTypeManager.Create("Float", "minCloudSpawnInterval", cr2w, this);
				}
				return _minCloudSpawnInterval;
			}
			set
			{
				if (_minCloudSpawnInterval == value)
				{
					return;
				}
				_minCloudSpawnInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("maxCloudSpawnInterval")] 
		public CFloat MaxCloudSpawnInterval
		{
			get
			{
				if (_maxCloudSpawnInterval == null)
				{
					_maxCloudSpawnInterval = (CFloat) CR2WTypeManager.Create("Float", "maxCloudSpawnInterval", cr2w, this);
				}
				return _maxCloudSpawnInterval;
			}
			set
			{
				if (_maxCloudSpawnInterval == value)
				{
					return;
				}
				_maxCloudSpawnInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("minCloudSpeed")] 
		public CFloat MinCloudSpeed
		{
			get
			{
				if (_minCloudSpeed == null)
				{
					_minCloudSpeed = (CFloat) CR2WTypeManager.Create("Float", "minCloudSpeed", cr2w, this);
				}
				return _minCloudSpeed;
			}
			set
			{
				if (_minCloudSpeed == value)
				{
					return;
				}
				_minCloudSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("maxCloudSpeed")] 
		public CFloat MaxCloudSpeed
		{
			get
			{
				if (_maxCloudSpeed == null)
				{
					_maxCloudSpeed = (CFloat) CR2WTypeManager.Create("Float", "maxCloudSpeed", cr2w, this);
				}
				return _maxCloudSpeed;
			}
			set
			{
				if (_maxCloudSpeed == value)
				{
					return;
				}
				_maxCloudSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("scoreCounter")] 
		public inkTextWidgetReference ScoreCounter
		{
			get
			{
				if (_scoreCounter == null)
				{
					_scoreCounter = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "scoreCounter", cr2w, this);
				}
				return _scoreCounter;
			}
			set
			{
				if (_scoreCounter == value)
				{
					return;
				}
				_scoreCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("livesCounter")] 
		public inkTextWidgetReference LivesCounter
		{
			get
			{
				if (_livesCounter == null)
				{
					_livesCounter = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "livesCounter", cr2w, this);
				}
				return _livesCounter;
			}
			set
			{
				if (_livesCounter == value)
				{
					return;
				}
				_livesCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("moveUpKey")] 
		public CName MoveUpKey
		{
			get
			{
				if (_moveUpKey == null)
				{
					_moveUpKey = (CName) CR2WTypeManager.Create("CName", "moveUpKey", cr2w, this);
				}
				return _moveUpKey;
			}
			set
			{
				if (_moveUpKey == value)
				{
					return;
				}
				_moveUpKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("moveDownKey")] 
		public CName MoveDownKey
		{
			get
			{
				if (_moveDownKey == null)
				{
					_moveDownKey = (CName) CR2WTypeManager.Create("CName", "moveDownKey", cr2w, this);
				}
				return _moveDownKey;
			}
			set
			{
				if (_moveDownKey == value)
				{
					return;
				}
				_moveDownKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("moveLeftKey")] 
		public CName MoveLeftKey
		{
			get
			{
				if (_moveLeftKey == null)
				{
					_moveLeftKey = (CName) CR2WTypeManager.Create("CName", "moveLeftKey", cr2w, this);
				}
				return _moveLeftKey;
			}
			set
			{
				if (_moveLeftKey == value)
				{
					return;
				}
				_moveLeftKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("moveRightKey")] 
		public CName MoveRightKey
		{
			get
			{
				if (_moveRightKey == null)
				{
					_moveRightKey = (CName) CR2WTypeManager.Create("CName", "moveRightKey", cr2w, this);
				}
				return _moveRightKey;
			}
			set
			{
				if (_moveRightKey == value)
				{
					return;
				}
				_moveRightKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("shootKey")] 
		public CName ShootKey
		{
			get
			{
				if (_shootKey == null)
				{
					_shootKey = (CName) CR2WTypeManager.Create("CName", "shootKey", cr2w, this);
				}
				return _shootKey;
			}
			set
			{
				if (_shootKey == value)
				{
					return;
				}
				_shootKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("backKey")] 
		public CName BackKey
		{
			get
			{
				if (_backKey == null)
				{
					_backKey = (CName) CR2WTypeManager.Create("CName", "backKey", cr2w, this);
				}
				return _backKey;
			}
			set
			{
				if (_backKey == value)
				{
					return;
				}
				_backKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("submitKey")] 
		public CName SubmitKey
		{
			get
			{
				if (_submitKey == null)
				{
					_submitKey = (CName) CR2WTypeManager.Create("CName", "submitKey", cr2w, this);
				}
				return _submitKey;
			}
			set
			{
				if (_submitKey == value)
				{
					return;
				}
				_submitKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("axisDeadZone")] 
		public CFloat AxisDeadZone
		{
			get
			{
				if (_axisDeadZone == null)
				{
					_axisDeadZone = (CFloat) CR2WTypeManager.Create("Float", "axisDeadZone", cr2w, this);
				}
				return _axisDeadZone;
			}
			set
			{
				if (_axisDeadZone == value)
				{
					return;
				}
				_axisDeadZone = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("moveXAxis")] 
		public CName MoveXAxis
		{
			get
			{
				if (_moveXAxis == null)
				{
					_moveXAxis = (CName) CR2WTypeManager.Create("CName", "moveXAxis", cr2w, this);
				}
				return _moveXAxis;
			}
			set
			{
				if (_moveXAxis == value)
				{
					return;
				}
				_moveXAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("moveYAxis")] 
		public CName MoveYAxis
		{
			get
			{
				if (_moveYAxis == null)
				{
					_moveYAxis = (CName) CR2WTypeManager.Create("CName", "moveYAxis", cr2w, this);
				}
				return _moveYAxis;
			}
			set
			{
				if (_moveYAxis == value)
				{
					return;
				}
				_moveYAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("shootAxis")] 
		public CName ShootAxis
		{
			get
			{
				if (_shootAxis == null)
				{
					_shootAxis = (CName) CR2WTypeManager.Create("CName", "shootAxis", cr2w, this);
				}
				return _shootAxis;
			}
			set
			{
				if (_shootAxis == value)
				{
					return;
				}
				_shootAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("droneLibraryName")] 
		public CName DroneLibraryName
		{
			get
			{
				if (_droneLibraryName == null)
				{
					_droneLibraryName = (CName) CR2WTypeManager.Create("CName", "droneLibraryName", cr2w, this);
				}
				return _droneLibraryName;
			}
			set
			{
				if (_droneLibraryName == value)
				{
					return;
				}
				_droneLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("minDroneSpawnInterval")] 
		public CFloat MinDroneSpawnInterval
		{
			get
			{
				if (_minDroneSpawnInterval == null)
				{
					_minDroneSpawnInterval = (CFloat) CR2WTypeManager.Create("Float", "minDroneSpawnInterval", cr2w, this);
				}
				return _minDroneSpawnInterval;
			}
			set
			{
				if (_minDroneSpawnInterval == value)
				{
					return;
				}
				_minDroneSpawnInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("maxDroneSpawnInterval")] 
		public CFloat MaxDroneSpawnInterval
		{
			get
			{
				if (_maxDroneSpawnInterval == null)
				{
					_maxDroneSpawnInterval = (CFloat) CR2WTypeManager.Create("Float", "maxDroneSpawnInterval", cr2w, this);
				}
				return _maxDroneSpawnInterval;
			}
			set
			{
				if (_maxDroneSpawnInterval == value)
				{
					return;
				}
				_maxDroneSpawnInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("avLibraryName")] 
		public CName AvLibraryName
		{
			get
			{
				if (_avLibraryName == null)
				{
					_avLibraryName = (CName) CR2WTypeManager.Create("CName", "avLibraryName", cr2w, this);
				}
				return _avLibraryName;
			}
			set
			{
				if (_avLibraryName == value)
				{
					return;
				}
				_avLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("minAvSpawnInterval")] 
		public CFloat MinAvSpawnInterval
		{
			get
			{
				if (_minAvSpawnInterval == null)
				{
					_minAvSpawnInterval = (CFloat) CR2WTypeManager.Create("Float", "minAvSpawnInterval", cr2w, this);
				}
				return _minAvSpawnInterval;
			}
			set
			{
				if (_minAvSpawnInterval == value)
				{
					return;
				}
				_minAvSpawnInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("maxAvSpawnInterval")] 
		public CFloat MaxAvSpawnInterval
		{
			get
			{
				if (_maxAvSpawnInterval == null)
				{
					_maxAvSpawnInterval = (CFloat) CR2WTypeManager.Create("Float", "maxAvSpawnInterval", cr2w, this);
				}
				return _maxAvSpawnInterval;
			}
			set
			{
				if (_maxAvSpawnInterval == value)
				{
					return;
				}
				_maxAvSpawnInterval = value;
				PropertySet(this);
			}
		}

		public gameuiPanzerGameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

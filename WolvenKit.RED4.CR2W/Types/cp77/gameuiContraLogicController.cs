using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiContraLogicController : gameuiSideScrollerMiniGameLogicControllerAdvanced
	{
		private CFloat _playerSpawnHeight;
		private CName _mainMenuScreenLibraryName;
		private CName _scoreboardScreenLibraryName;
		private CName _jumpKey;
		private CName _goDownKey;
		private CName _goLeftKey;
		private CName _goRightKey;
		private CName _lieDownKey;
		private CName _shootKey;
		private CName _submitKey;
		private CFloat _axisDeadZone;
		private CName _moveXAxis;
		private CName _moveYAxis;
		private CName _shootTriggerName;
		private CName _uiLayerName;
		private CName _gameLayerName;
		private CName _platformLayerName;
		private CName _backgroundLayerName;
		private CName _tileLibraryName;
		private CName _platformLibraryName;
		private CName _platformTexturePartName;
		private CName _roadTexturePartName;
		private CFloat _middlePlatformMinDistance;
		private CFloat _middlePlatformMaxDistance;
		private CFloat _topPlatformPosition;
		private CFloat _bottomPlatformPosition;
		private CName _fenceLibraryName;
		private CFloat _fenceSpawnDistance;

		[Ordinal(9)] 
		[RED("playerSpawnHeight")] 
		public CFloat PlayerSpawnHeight
		{
			get
			{
				if (_playerSpawnHeight == null)
				{
					_playerSpawnHeight = (CFloat) CR2WTypeManager.Create("Float", "playerSpawnHeight", cr2w, this);
				}
				return _playerSpawnHeight;
			}
			set
			{
				if (_playerSpawnHeight == value)
				{
					return;
				}
				_playerSpawnHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("mainMenuScreenLibraryName")] 
		public CName MainMenuScreenLibraryName
		{
			get
			{
				if (_mainMenuScreenLibraryName == null)
				{
					_mainMenuScreenLibraryName = (CName) CR2WTypeManager.Create("CName", "mainMenuScreenLibraryName", cr2w, this);
				}
				return _mainMenuScreenLibraryName;
			}
			set
			{
				if (_mainMenuScreenLibraryName == value)
				{
					return;
				}
				_mainMenuScreenLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("scoreboardScreenLibraryName")] 
		public CName ScoreboardScreenLibraryName
		{
			get
			{
				if (_scoreboardScreenLibraryName == null)
				{
					_scoreboardScreenLibraryName = (CName) CR2WTypeManager.Create("CName", "scoreboardScreenLibraryName", cr2w, this);
				}
				return _scoreboardScreenLibraryName;
			}
			set
			{
				if (_scoreboardScreenLibraryName == value)
				{
					return;
				}
				_scoreboardScreenLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("jumpKey")] 
		public CName JumpKey
		{
			get
			{
				if (_jumpKey == null)
				{
					_jumpKey = (CName) CR2WTypeManager.Create("CName", "jumpKey", cr2w, this);
				}
				return _jumpKey;
			}
			set
			{
				if (_jumpKey == value)
				{
					return;
				}
				_jumpKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("goDownKey")] 
		public CName GoDownKey
		{
			get
			{
				if (_goDownKey == null)
				{
					_goDownKey = (CName) CR2WTypeManager.Create("CName", "goDownKey", cr2w, this);
				}
				return _goDownKey;
			}
			set
			{
				if (_goDownKey == value)
				{
					return;
				}
				_goDownKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("goLeftKey")] 
		public CName GoLeftKey
		{
			get
			{
				if (_goLeftKey == null)
				{
					_goLeftKey = (CName) CR2WTypeManager.Create("CName", "goLeftKey", cr2w, this);
				}
				return _goLeftKey;
			}
			set
			{
				if (_goLeftKey == value)
				{
					return;
				}
				_goLeftKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("goRightKey")] 
		public CName GoRightKey
		{
			get
			{
				if (_goRightKey == null)
				{
					_goRightKey = (CName) CR2WTypeManager.Create("CName", "goRightKey", cr2w, this);
				}
				return _goRightKey;
			}
			set
			{
				if (_goRightKey == value)
				{
					return;
				}
				_goRightKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("lieDownKey")] 
		public CName LieDownKey
		{
			get
			{
				if (_lieDownKey == null)
				{
					_lieDownKey = (CName) CR2WTypeManager.Create("CName", "lieDownKey", cr2w, this);
				}
				return _lieDownKey;
			}
			set
			{
				if (_lieDownKey == value)
				{
					return;
				}
				_lieDownKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
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

		[Ordinal(21)] 
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

		[Ordinal(22)] 
		[RED("shootTriggerName")] 
		public CName ShootTriggerName
		{
			get
			{
				if (_shootTriggerName == null)
				{
					_shootTriggerName = (CName) CR2WTypeManager.Create("CName", "shootTriggerName", cr2w, this);
				}
				return _shootTriggerName;
			}
			set
			{
				if (_shootTriggerName == value)
				{
					return;
				}
				_shootTriggerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("uiLayerName")] 
		public CName UiLayerName
		{
			get
			{
				if (_uiLayerName == null)
				{
					_uiLayerName = (CName) CR2WTypeManager.Create("CName", "uiLayerName", cr2w, this);
				}
				return _uiLayerName;
			}
			set
			{
				if (_uiLayerName == value)
				{
					return;
				}
				_uiLayerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
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

		[Ordinal(25)] 
		[RED("platformLayerName")] 
		public CName PlatformLayerName
		{
			get
			{
				if (_platformLayerName == null)
				{
					_platformLayerName = (CName) CR2WTypeManager.Create("CName", "platformLayerName", cr2w, this);
				}
				return _platformLayerName;
			}
			set
			{
				if (_platformLayerName == value)
				{
					return;
				}
				_platformLayerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("backgroundLayerName")] 
		public CName BackgroundLayerName
		{
			get
			{
				if (_backgroundLayerName == null)
				{
					_backgroundLayerName = (CName) CR2WTypeManager.Create("CName", "backgroundLayerName", cr2w, this);
				}
				return _backgroundLayerName;
			}
			set
			{
				if (_backgroundLayerName == value)
				{
					return;
				}
				_backgroundLayerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("tileLibraryName")] 
		public CName TileLibraryName
		{
			get
			{
				if (_tileLibraryName == null)
				{
					_tileLibraryName = (CName) CR2WTypeManager.Create("CName", "tileLibraryName", cr2w, this);
				}
				return _tileLibraryName;
			}
			set
			{
				if (_tileLibraryName == value)
				{
					return;
				}
				_tileLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("platformLibraryName")] 
		public CName PlatformLibraryName
		{
			get
			{
				if (_platformLibraryName == null)
				{
					_platformLibraryName = (CName) CR2WTypeManager.Create("CName", "platformLibraryName", cr2w, this);
				}
				return _platformLibraryName;
			}
			set
			{
				if (_platformLibraryName == value)
				{
					return;
				}
				_platformLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("platformTexturePartName")] 
		public CName PlatformTexturePartName
		{
			get
			{
				if (_platformTexturePartName == null)
				{
					_platformTexturePartName = (CName) CR2WTypeManager.Create("CName", "platformTexturePartName", cr2w, this);
				}
				return _platformTexturePartName;
			}
			set
			{
				if (_platformTexturePartName == value)
				{
					return;
				}
				_platformTexturePartName = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("RoadTexturePartName")] 
		public CName RoadTexturePartName
		{
			get
			{
				if (_roadTexturePartName == null)
				{
					_roadTexturePartName = (CName) CR2WTypeManager.Create("CName", "RoadTexturePartName", cr2w, this);
				}
				return _roadTexturePartName;
			}
			set
			{
				if (_roadTexturePartName == value)
				{
					return;
				}
				_roadTexturePartName = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("middlePlatformMinDistance")] 
		public CFloat MiddlePlatformMinDistance
		{
			get
			{
				if (_middlePlatformMinDistance == null)
				{
					_middlePlatformMinDistance = (CFloat) CR2WTypeManager.Create("Float", "middlePlatformMinDistance", cr2w, this);
				}
				return _middlePlatformMinDistance;
			}
			set
			{
				if (_middlePlatformMinDistance == value)
				{
					return;
				}
				_middlePlatformMinDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("middlePlatformMaxDistance")] 
		public CFloat MiddlePlatformMaxDistance
		{
			get
			{
				if (_middlePlatformMaxDistance == null)
				{
					_middlePlatformMaxDistance = (CFloat) CR2WTypeManager.Create("Float", "middlePlatformMaxDistance", cr2w, this);
				}
				return _middlePlatformMaxDistance;
			}
			set
			{
				if (_middlePlatformMaxDistance == value)
				{
					return;
				}
				_middlePlatformMaxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("topPlatformPosition")] 
		public CFloat TopPlatformPosition
		{
			get
			{
				if (_topPlatformPosition == null)
				{
					_topPlatformPosition = (CFloat) CR2WTypeManager.Create("Float", "topPlatformPosition", cr2w, this);
				}
				return _topPlatformPosition;
			}
			set
			{
				if (_topPlatformPosition == value)
				{
					return;
				}
				_topPlatformPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("bottomPlatformPosition")] 
		public CFloat BottomPlatformPosition
		{
			get
			{
				if (_bottomPlatformPosition == null)
				{
					_bottomPlatformPosition = (CFloat) CR2WTypeManager.Create("Float", "bottomPlatformPosition", cr2w, this);
				}
				return _bottomPlatformPosition;
			}
			set
			{
				if (_bottomPlatformPosition == value)
				{
					return;
				}
				_bottomPlatformPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("fenceLibraryName")] 
		public CName FenceLibraryName
		{
			get
			{
				if (_fenceLibraryName == null)
				{
					_fenceLibraryName = (CName) CR2WTypeManager.Create("CName", "fenceLibraryName", cr2w, this);
				}
				return _fenceLibraryName;
			}
			set
			{
				if (_fenceLibraryName == value)
				{
					return;
				}
				_fenceLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("fenceSpawnDistance")] 
		public CFloat FenceSpawnDistance
		{
			get
			{
				if (_fenceSpawnDistance == null)
				{
					_fenceSpawnDistance = (CFloat) CR2WTypeManager.Create("Float", "fenceSpawnDistance", cr2w, this);
				}
				return _fenceSpawnDistance;
			}
			set
			{
				if (_fenceSpawnDistance == value)
				{
					return;
				}
				_fenceSpawnDistance = value;
				PropertySet(this);
			}
		}

		public gameuiContraLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

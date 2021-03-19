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
			get => GetProperty(ref _playerSpawnHeight);
			set => SetProperty(ref _playerSpawnHeight, value);
		}

		[Ordinal(10)] 
		[RED("mainMenuScreenLibraryName")] 
		public CName MainMenuScreenLibraryName
		{
			get => GetProperty(ref _mainMenuScreenLibraryName);
			set => SetProperty(ref _mainMenuScreenLibraryName, value);
		}

		[Ordinal(11)] 
		[RED("scoreboardScreenLibraryName")] 
		public CName ScoreboardScreenLibraryName
		{
			get => GetProperty(ref _scoreboardScreenLibraryName);
			set => SetProperty(ref _scoreboardScreenLibraryName, value);
		}

		[Ordinal(12)] 
		[RED("jumpKey")] 
		public CName JumpKey
		{
			get => GetProperty(ref _jumpKey);
			set => SetProperty(ref _jumpKey, value);
		}

		[Ordinal(13)] 
		[RED("goDownKey")] 
		public CName GoDownKey
		{
			get => GetProperty(ref _goDownKey);
			set => SetProperty(ref _goDownKey, value);
		}

		[Ordinal(14)] 
		[RED("goLeftKey")] 
		public CName GoLeftKey
		{
			get => GetProperty(ref _goLeftKey);
			set => SetProperty(ref _goLeftKey, value);
		}

		[Ordinal(15)] 
		[RED("goRightKey")] 
		public CName GoRightKey
		{
			get => GetProperty(ref _goRightKey);
			set => SetProperty(ref _goRightKey, value);
		}

		[Ordinal(16)] 
		[RED("lieDownKey")] 
		public CName LieDownKey
		{
			get => GetProperty(ref _lieDownKey);
			set => SetProperty(ref _lieDownKey, value);
		}

		[Ordinal(17)] 
		[RED("shootKey")] 
		public CName ShootKey
		{
			get => GetProperty(ref _shootKey);
			set => SetProperty(ref _shootKey, value);
		}

		[Ordinal(18)] 
		[RED("submitKey")] 
		public CName SubmitKey
		{
			get => GetProperty(ref _submitKey);
			set => SetProperty(ref _submitKey, value);
		}

		[Ordinal(19)] 
		[RED("axisDeadZone")] 
		public CFloat AxisDeadZone
		{
			get => GetProperty(ref _axisDeadZone);
			set => SetProperty(ref _axisDeadZone, value);
		}

		[Ordinal(20)] 
		[RED("moveXAxis")] 
		public CName MoveXAxis
		{
			get => GetProperty(ref _moveXAxis);
			set => SetProperty(ref _moveXAxis, value);
		}

		[Ordinal(21)] 
		[RED("moveYAxis")] 
		public CName MoveYAxis
		{
			get => GetProperty(ref _moveYAxis);
			set => SetProperty(ref _moveYAxis, value);
		}

		[Ordinal(22)] 
		[RED("shootTriggerName")] 
		public CName ShootTriggerName
		{
			get => GetProperty(ref _shootTriggerName);
			set => SetProperty(ref _shootTriggerName, value);
		}

		[Ordinal(23)] 
		[RED("uiLayerName")] 
		public CName UiLayerName
		{
			get => GetProperty(ref _uiLayerName);
			set => SetProperty(ref _uiLayerName, value);
		}

		[Ordinal(24)] 
		[RED("gameLayerName")] 
		public CName GameLayerName
		{
			get => GetProperty(ref _gameLayerName);
			set => SetProperty(ref _gameLayerName, value);
		}

		[Ordinal(25)] 
		[RED("platformLayerName")] 
		public CName PlatformLayerName
		{
			get => GetProperty(ref _platformLayerName);
			set => SetProperty(ref _platformLayerName, value);
		}

		[Ordinal(26)] 
		[RED("backgroundLayerName")] 
		public CName BackgroundLayerName
		{
			get => GetProperty(ref _backgroundLayerName);
			set => SetProperty(ref _backgroundLayerName, value);
		}

		[Ordinal(27)] 
		[RED("tileLibraryName")] 
		public CName TileLibraryName
		{
			get => GetProperty(ref _tileLibraryName);
			set => SetProperty(ref _tileLibraryName, value);
		}

		[Ordinal(28)] 
		[RED("platformLibraryName")] 
		public CName PlatformLibraryName
		{
			get => GetProperty(ref _platformLibraryName);
			set => SetProperty(ref _platformLibraryName, value);
		}

		[Ordinal(29)] 
		[RED("platformTexturePartName")] 
		public CName PlatformTexturePartName
		{
			get => GetProperty(ref _platformTexturePartName);
			set => SetProperty(ref _platformTexturePartName, value);
		}

		[Ordinal(30)] 
		[RED("RoadTexturePartName")] 
		public CName RoadTexturePartName
		{
			get => GetProperty(ref _roadTexturePartName);
			set => SetProperty(ref _roadTexturePartName, value);
		}

		[Ordinal(31)] 
		[RED("middlePlatformMinDistance")] 
		public CFloat MiddlePlatformMinDistance
		{
			get => GetProperty(ref _middlePlatformMinDistance);
			set => SetProperty(ref _middlePlatformMinDistance, value);
		}

		[Ordinal(32)] 
		[RED("middlePlatformMaxDistance")] 
		public CFloat MiddlePlatformMaxDistance
		{
			get => GetProperty(ref _middlePlatformMaxDistance);
			set => SetProperty(ref _middlePlatformMaxDistance, value);
		}

		[Ordinal(33)] 
		[RED("topPlatformPosition")] 
		public CFloat TopPlatformPosition
		{
			get => GetProperty(ref _topPlatformPosition);
			set => SetProperty(ref _topPlatformPosition, value);
		}

		[Ordinal(34)] 
		[RED("bottomPlatformPosition")] 
		public CFloat BottomPlatformPosition
		{
			get => GetProperty(ref _bottomPlatformPosition);
			set => SetProperty(ref _bottomPlatformPosition, value);
		}

		[Ordinal(35)] 
		[RED("fenceLibraryName")] 
		public CName FenceLibraryName
		{
			get => GetProperty(ref _fenceLibraryName);
			set => SetProperty(ref _fenceLibraryName, value);
		}

		[Ordinal(36)] 
		[RED("fenceSpawnDistance")] 
		public CFloat FenceSpawnDistance
		{
			get => GetProperty(ref _fenceSpawnDistance);
			set => SetProperty(ref _fenceSpawnDistance, value);
		}

		public gameuiContraLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

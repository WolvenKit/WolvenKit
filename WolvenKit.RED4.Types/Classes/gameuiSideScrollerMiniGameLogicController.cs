using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSideScrollerMiniGameLogicController : inkWidgetLogicController
	{
		private CName _gameName;
		private CUInt32 _startHealth;
		private CName _playerLibraryName;
		private Vector2 _playerColliderPositionOffset;
		private Vector2 _playerColliderSizeOffset;
		private inkCompoundWidgetReference _gameplayRoot;
		private CFloat _baseSpeed;
		private CArray<CName> _spawnedListLibraryNames;
		private CBool _isGameRunning;

		[Ordinal(1)] 
		[RED("gameName")] 
		public CName GameName
		{
			get => GetProperty(ref _gameName);
			set => SetProperty(ref _gameName, value);
		}

		[Ordinal(2)] 
		[RED("startHealth")] 
		public CUInt32 StartHealth
		{
			get => GetProperty(ref _startHealth);
			set => SetProperty(ref _startHealth, value);
		}

		[Ordinal(3)] 
		[RED("playerLibraryName")] 
		public CName PlayerLibraryName
		{
			get => GetProperty(ref _playerLibraryName);
			set => SetProperty(ref _playerLibraryName, value);
		}

		[Ordinal(4)] 
		[RED("playerColliderPositionOffset")] 
		public Vector2 PlayerColliderPositionOffset
		{
			get => GetProperty(ref _playerColliderPositionOffset);
			set => SetProperty(ref _playerColliderPositionOffset, value);
		}

		[Ordinal(5)] 
		[RED("playerColliderSizeOffset")] 
		public Vector2 PlayerColliderSizeOffset
		{
			get => GetProperty(ref _playerColliderSizeOffset);
			set => SetProperty(ref _playerColliderSizeOffset, value);
		}

		[Ordinal(6)] 
		[RED("gameplayRoot")] 
		public inkCompoundWidgetReference GameplayRoot
		{
			get => GetProperty(ref _gameplayRoot);
			set => SetProperty(ref _gameplayRoot, value);
		}

		[Ordinal(7)] 
		[RED("baseSpeed")] 
		public CFloat BaseSpeed
		{
			get => GetProperty(ref _baseSpeed);
			set => SetProperty(ref _baseSpeed, value);
		}

		[Ordinal(8)] 
		[RED("spawnedListLibraryNames")] 
		public CArray<CName> SpawnedListLibraryNames
		{
			get => GetProperty(ref _spawnedListLibraryNames);
			set => SetProperty(ref _spawnedListLibraryNames, value);
		}

		[Ordinal(9)] 
		[RED("isGameRunning")] 
		public CBool IsGameRunning
		{
			get => GetProperty(ref _isGameRunning);
			set => SetProperty(ref _isGameRunning, value);
		}

		public gameuiSideScrollerMiniGameLogicController()
		{
			_startHealth = 3;
		}
	}
}

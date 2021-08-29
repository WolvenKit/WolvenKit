using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPopulationSpawnerNode : worldNode
	{
		private TweakDBID _objectRecordId;
		private CName _appearanceName;
		private CBool _spawnOnStart;
		private CEnum<gameAlwaysSpawnedState> _alwaysSpawned;
		private CEnum<gameSpawnInViewState> _spawnInView;
		private CBool _prefetchAppearance;

		[Ordinal(4)] 
		[RED("objectRecordId")] 
		public TweakDBID ObjectRecordId
		{
			get => GetProperty(ref _objectRecordId);
			set => SetProperty(ref _objectRecordId, value);
		}

		[Ordinal(5)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}

		[Ordinal(6)] 
		[RED("spawnOnStart")] 
		public CBool SpawnOnStart
		{
			get => GetProperty(ref _spawnOnStart);
			set => SetProperty(ref _spawnOnStart, value);
		}

		[Ordinal(7)] 
		[RED("alwaysSpawned")] 
		public CEnum<gameAlwaysSpawnedState> AlwaysSpawned
		{
			get => GetProperty(ref _alwaysSpawned);
			set => SetProperty(ref _alwaysSpawned, value);
		}

		[Ordinal(8)] 
		[RED("spawnInView")] 
		public CEnum<gameSpawnInViewState> SpawnInView
		{
			get => GetProperty(ref _spawnInView);
			set => SetProperty(ref _spawnInView, value);
		}

		[Ordinal(9)] 
		[RED("prefetchAppearance")] 
		public CBool PrefetchAppearance
		{
			get => GetProperty(ref _prefetchAppearance);
			set => SetProperty(ref _prefetchAppearance, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPopulationSpawnerNode : worldNode
	{
		[Ordinal(4)] 
		[RED("objectRecordId")] 
		public TweakDBID ObjectRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("spawnOnStart")] 
		public CBool SpawnOnStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("alwaysSpawned")] 
		public CEnum<gameAlwaysSpawnedState> AlwaysSpawned
		{
			get => GetPropertyValue<CEnum<gameAlwaysSpawnedState>>();
			set => SetPropertyValue<CEnum<gameAlwaysSpawnedState>>(value);
		}

		[Ordinal(8)] 
		[RED("spawnInView")] 
		public CEnum<gameSpawnInViewState> SpawnInView
		{
			get => GetPropertyValue<CEnum<gameSpawnInViewState>>();
			set => SetPropertyValue<CEnum<gameSpawnInViewState>>(value);
		}

		[Ordinal(9)] 
		[RED("prefetchAppearance")] 
		public CBool PrefetchAppearance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isVehicle")] 
		public CBool IsVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldPopulationSpawnerNode()
		{
			AppearanceName = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

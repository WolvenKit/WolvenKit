using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communitySpawnEntry : ISerializable
	{
		[Ordinal(0)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("phases")] 
		public CArray<CHandle<communitySpawnPhase>> Phases
		{
			get => GetPropertyValue<CArray<CHandle<communitySpawnPhase>>>();
			set => SetPropertyValue<CArray<CHandle<communitySpawnPhase>>>(value);
		}

		[Ordinal(3)] 
		[RED("spawnInView")] 
		public CEnum<gameSpawnInViewState> SpawnInView
		{
			get => GetPropertyValue<CEnum<gameSpawnInViewState>>();
			set => SetPropertyValue<CEnum<gameSpawnInViewState>>(value);
		}

		[Ordinal(4)] 
		[RED("initializers")] 
		public CArray<CHandle<communitySpawnInitializer>> Initializers
		{
			get => GetPropertyValue<CArray<CHandle<communitySpawnInitializer>>>();
			set => SetPropertyValue<CArray<CHandle<communitySpawnInitializer>>>(value);
		}

		public communitySpawnEntry()
		{
			Phases = new() { null };
			Initializers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

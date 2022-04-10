using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLipsyncMappingSceneEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actorVoiceTags")] 
		public CArray<CRUID> ActorVoiceTags
		{
			get => GetPropertyValue<CArray<CRUID>>();
			set => SetPropertyValue<CArray<CRUID>>(value);
		}

		[Ordinal(1)] 
		[RED("animSets")] 
		public CArray<CResourceAsyncReference<animAnimSet>> AnimSets
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<animAnimSet>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<animAnimSet>>>(value);
		}

		public animLipsyncMappingSceneEntry()
		{
			ActorVoiceTags = new();
			AnimSets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLipsyncMappingSceneEntry : RedBaseClass
	{
		private CArray<CRUID> _actorVoiceTags;
		private CArray<CResourceAsyncReference<animAnimSet>> _animSets;

		[Ordinal(0)] 
		[RED("actorVoiceTags")] 
		public CArray<CRUID> ActorVoiceTags
		{
			get => GetProperty(ref _actorVoiceTags);
			set => SetProperty(ref _actorVoiceTags, value);
		}

		[Ordinal(1)] 
		[RED("animSets")] 
		public CArray<CResourceAsyncReference<animAnimSet>> AnimSets
		{
			get => GetProperty(ref _animSets);
			set => SetProperty(ref _animSets, value);
		}
	}
}

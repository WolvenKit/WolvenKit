using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLipsyncMappingSceneEntry : CVariable
	{
		private CArray<CRUID> _actorVoiceTags;
		private CArray<raRef<animAnimSet>> _animSets;

		[Ordinal(0)] 
		[RED("actorVoiceTags")] 
		public CArray<CRUID> ActorVoiceTags
		{
			get => GetProperty(ref _actorVoiceTags);
			set => SetProperty(ref _actorVoiceTags, value);
		}

		[Ordinal(1)] 
		[RED("animSets")] 
		public CArray<raRef<animAnimSet>> AnimSets
		{
			get => GetProperty(ref _animSets);
			set => SetProperty(ref _animSets, value);
		}

		public animLipsyncMappingSceneEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StackTracksExtender_ : animAnimNode_OnePoseInput
	{
		private CName _tag;
		private CArray<animFloatTrackInfo> _newTracks;

		[Ordinal(12)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(13)] 
		[RED("newTracks")] 
		public CArray<animFloatTrackInfo> NewTracks
		{
			get => GetProperty(ref _newTracks);
			set => SetProperty(ref _newTracks, value);
		}

		public animAnimNode_StackTracksExtender_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

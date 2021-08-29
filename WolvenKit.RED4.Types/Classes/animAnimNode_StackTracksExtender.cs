using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_StackTracksExtender : animAnimNode_OnePoseInput
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
	}
}

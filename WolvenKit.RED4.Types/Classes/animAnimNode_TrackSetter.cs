using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_TrackSetter : animAnimNode_OnePoseInput
	{
		private animNamedTrackIndex _track;
		private animFloatLink _value;

		[Ordinal(12)] 
		[RED("track")] 
		public animNamedTrackIndex Track
		{
			get => GetProperty(ref _track);
			set => SetProperty(ref _track, value);
		}

		[Ordinal(13)] 
		[RED("value")] 
		public animFloatLink Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}

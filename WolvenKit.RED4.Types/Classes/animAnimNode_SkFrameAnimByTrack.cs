using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkFrameAnimByTrack : animAnimNode_SkFrameAnim
	{
		private animNamedTrackIndex _progressFloatTrack;
		private animNamedTrackIndex _timeFloatTrack;
		private animNamedTrackIndex _frameFloatTrack;
		private animPoseLink _inputWithTracks;

		[Ordinal(34)] 
		[RED("progressFloatTrack")] 
		public animNamedTrackIndex ProgressFloatTrack
		{
			get => GetProperty(ref _progressFloatTrack);
			set => SetProperty(ref _progressFloatTrack, value);
		}

		[Ordinal(35)] 
		[RED("timeFloatTrack")] 
		public animNamedTrackIndex TimeFloatTrack
		{
			get => GetProperty(ref _timeFloatTrack);
			set => SetProperty(ref _timeFloatTrack, value);
		}

		[Ordinal(36)] 
		[RED("frameFloatTrack")] 
		public animNamedTrackIndex FrameFloatTrack
		{
			get => GetProperty(ref _frameFloatTrack);
			set => SetProperty(ref _frameFloatTrack, value);
		}

		[Ordinal(37)] 
		[RED("inputWithTracks")] 
		public animPoseLink InputWithTracks
		{
			get => GetProperty(ref _inputWithTracks);
			set => SetProperty(ref _inputWithTracks, value);
		}
	}
}

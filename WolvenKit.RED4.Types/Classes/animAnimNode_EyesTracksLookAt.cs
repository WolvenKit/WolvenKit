using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_EyesTracksLookAt : animAnimNode_OnePoseInput
	{
		private animTransformIndex _eyeTransform;
		private animNamedTrackIndex _leftTrack;
		private animNamedTrackIndex _rightTrack;
		private animNamedTrackIndex _upTrack;
		private animNamedTrackIndex _downTrack;
		private CBool _debug;

		[Ordinal(12)] 
		[RED("eyeTransform")] 
		public animTransformIndex EyeTransform
		{
			get => GetProperty(ref _eyeTransform);
			set => SetProperty(ref _eyeTransform, value);
		}

		[Ordinal(13)] 
		[RED("leftTrack")] 
		public animNamedTrackIndex LeftTrack
		{
			get => GetProperty(ref _leftTrack);
			set => SetProperty(ref _leftTrack, value);
		}

		[Ordinal(14)] 
		[RED("rightTrack")] 
		public animNamedTrackIndex RightTrack
		{
			get => GetProperty(ref _rightTrack);
			set => SetProperty(ref _rightTrack, value);
		}

		[Ordinal(15)] 
		[RED("upTrack")] 
		public animNamedTrackIndex UpTrack
		{
			get => GetProperty(ref _upTrack);
			set => SetProperty(ref _upTrack, value);
		}

		[Ordinal(16)] 
		[RED("downTrack")] 
		public animNamedTrackIndex DownTrack
		{
			get => GetProperty(ref _downTrack);
			set => SetProperty(ref _downTrack, value);
		}

		[Ordinal(17)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetProperty(ref _debug);
			set => SetProperty(ref _debug, value);
		}
	}
}

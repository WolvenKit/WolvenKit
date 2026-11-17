using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_EyesTracksLookAt : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("eyeTransform")] 
		public animTransformIndex EyeTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(3)] 
		[RED("leftTrack")] 
		public animNamedTrackIndex LeftTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(4)] 
		[RED("rightTrack")] 
		public animNamedTrackIndex RightTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(5)] 
		[RED("upTrack")] 
		public animNamedTrackIndex UpTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(6)] 
		[RED("downTrack")] 
		public animNamedTrackIndex DownTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(7)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_EyesTracksLookAt()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			EyeTransform = new animTransformIndex();
			LeftTrack = new animNamedTrackIndex();
			RightTrack = new animNamedTrackIndex();
			UpTrack = new animNamedTrackIndex();
			DownTrack = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

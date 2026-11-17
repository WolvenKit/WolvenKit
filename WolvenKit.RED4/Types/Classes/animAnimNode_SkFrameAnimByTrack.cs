using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkFrameAnimByTrack : animAnimNode_SkFrameAnim
	{
		[Ordinal(22)] 
		[RED("progressFloatTrack")] 
		public animNamedTrackIndex ProgressFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(23)] 
		[RED("timeFloatTrack")] 
		public animNamedTrackIndex TimeFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(24)] 
		[RED("frameFloatTrack")] 
		public animNamedTrackIndex FrameFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(25)] 
		[RED("inputWithTracks")] 
		public animPoseLink InputWithTracks
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_SkFrameAnimByTrack()
		{
			ProgressFloatTrack = new animNamedTrackIndex();
			TimeFloatTrack = new animNamedTrackIndex();
			FrameFloatTrack = new animNamedTrackIndex();
			InputWithTracks = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

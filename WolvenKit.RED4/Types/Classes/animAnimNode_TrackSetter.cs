using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TrackSetter : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("track")] 
		public animNamedTrackIndex Track
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(13)] 
		[RED("value")] 
		public animFloatLink Value
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_TrackSetter()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			Track = new animNamedTrackIndex();
			Value = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

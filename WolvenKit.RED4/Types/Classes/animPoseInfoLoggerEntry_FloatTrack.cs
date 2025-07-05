using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animPoseInfoLoggerEntry_FloatTrack : animPoseInfoLoggerEntry
	{
		[Ordinal(0)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(1)] 
		[RED("showOnlyWhenPositive")] 
		public CBool ShowOnlyWhenPositive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animPoseInfoLoggerEntry_FloatTrack()
		{
			FloatTrack = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

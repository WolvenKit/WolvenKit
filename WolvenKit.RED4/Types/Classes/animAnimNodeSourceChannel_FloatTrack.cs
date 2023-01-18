using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNodeSourceChannel_FloatTrack : animIAnimNodeSourceChannel_Float
	{
		[Ordinal(0)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(1)] 
		[RED("useComplementValue")] 
		public CBool UseComplementValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNodeSourceChannel_FloatTrack()
		{
			FloatTrack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

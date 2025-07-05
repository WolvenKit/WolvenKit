using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioSoundsLimiterMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("tooManyPlayingGruntsAndVOsLimitation")] 
		public CArray<audioLimitedSound> TooManyPlayingGruntsAndVOsLimitation
		{
			get => GetPropertyValue<CArray<audioLimitedSound>>();
			set => SetPropertyValue<CArray<audioLimitedSound>>(value);
		}

		[Ordinal(2)] 
		[RED("gunsAreLoudAndMusicIsActiveLimitation")] 
		public CArray<audioLimitedSound> GunsAreLoudAndMusicIsActiveLimitation
		{
			get => GetPropertyValue<CArray<audioLimitedSound>>();
			set => SetPropertyValue<CArray<audioLimitedSound>>(value);
		}

		[Ordinal(3)] 
		[RED("gunsAreLoudLimitation")] 
		public CArray<audioLimitedSound> GunsAreLoudLimitation
		{
			get => GetPropertyValue<CArray<audioLimitedSound>>();
			set => SetPropertyValue<CArray<audioLimitedSound>>(value);
		}

		[Ordinal(4)] 
		[RED("tooManyPlayingSoundsLimitation")] 
		public CArray<audioLimitedSound> TooManyPlayingSoundsLimitation
		{
			get => GetPropertyValue<CArray<audioLimitedSound>>();
			set => SetPropertyValue<CArray<audioLimitedSound>>(value);
		}

		public audioSoundsLimiterMetadata()
		{
			TooManyPlayingGruntsAndVOsLimitation = new();
			GunsAreLoudAndMusicIsActiveLimitation = new();
			GunsAreLoudLimitation = new();
			TooManyPlayingSoundsLimitation = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

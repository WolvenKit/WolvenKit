using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAdvertSoundMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("audioEvent1")] 
		public CName AudioEvent1
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("audioEvent2")] 
		public CName AudioEvent2
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("audioEvent3")] 
		public CName AudioEvent3
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("audioEvent4")] 
		public CName AudioEvent4
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("useCustomDelays")] 
		public CBool UseCustomDelays
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("speedOfSound")] 
		public CFloat SpeedOfSound
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("soundDelay1")] 
		public CFloat SoundDelay1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("soundDelay2")] 
		public CFloat SoundDelay2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("soundDelay3")] 
		public CFloat SoundDelay3
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("soundDelay4")] 
		public CFloat SoundDelay4
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioAdvertSoundMetadata()
		{
			SpeedOfSound = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

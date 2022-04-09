using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAccumulatedSoundDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("accumulatedSounds")] 
		public CArray<CName> AccumulatedSounds
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("inSpammingMode")] 
		public CBool InSpammingMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("fadeParam")] 
		public CName FadeParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("soundTimeout")] 
		public CFloat SoundTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("loopStart")] 
		public CName LoopStart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("loopEnd")] 
		public CName LoopEnd
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("spammingSound")] 
		public CName SpammingSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("spammingSoundInterval")] 
		public CFloat SpammingSoundInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioAccumulatedSoundDecoratorMetadata()
		{
			AccumulatedSounds = new();
			SoundTimeout = 1.000000F;
			SpammingSoundInterval = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

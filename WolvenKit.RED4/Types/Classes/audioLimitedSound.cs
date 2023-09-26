using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLimitedSound : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("soundType")] 
		public CEnum<audioLimitedSoundType> SoundType
		{
			get => GetPropertyValue<CEnum<audioLimitedSoundType>>();
			set => SetPropertyValue<CEnum<audioLimitedSoundType>>(value);
		}

		[Ordinal(1)] 
		[RED("attenuationDistance")] 
		public CFloat AttenuationDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioLimitedSound()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

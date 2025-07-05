using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioBreathingUnderwaterMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("inhaleSound")] 
		public CName InhaleSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("exhaleSound")] 
		public CName ExhaleSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("emergenceSound")] 
		public CName EmergenceSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("struggledEmergenceSound")] 
		public CName StruggledEmergenceSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("divingSuitRTPC")] 
		public CName DivingSuitRTPC
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("BPM")] 
		public CFloat BPM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("lowOxygen")] 
		public CFloat LowOxygen
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioBreathingUnderwaterMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

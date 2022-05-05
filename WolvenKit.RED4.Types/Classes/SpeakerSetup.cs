using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpeakerSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("defaultMusic")] 
		public CEnum<ERadioStationList> DefaultMusic
		{
			get => GetPropertyValue<CEnum<ERadioStationList>>();
			set => SetPropertyValue<CEnum<ERadioStationList>>(value);
		}

		[Ordinal(1)] 
		[RED("distractionMusic")] 
		public CEnum<ERadioStationList> DistractionMusic
		{
			get => GetPropertyValue<CEnum<ERadioStationList>>();
			set => SetPropertyValue<CEnum<ERadioStationList>>(value);
		}

		[Ordinal(2)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("useOnlyGlitchSFX")] 
		public CBool UseOnlyGlitchSFX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SpeakerSetup()
		{
			Range = 10.000000F;
			GlitchSFX = "dev_radio_ditraction_glitching";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

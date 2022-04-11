using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioFoleyGlobalMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("fadeoutTime")] 
		public CFloat FadeoutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("fadeoutRtpc")] 
		public CName FadeoutRtpc
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioFoleyGlobalMetadata()
		{
			FadeoutTime = 20.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

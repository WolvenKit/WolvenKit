using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioReflectionMaterialSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("lowPass")] 
		public CFloat LowPass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("highPass")] 
		public CFloat HighPass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("gain")] 
		public CFloat Gain
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioReflectionMaterialSettings()
		{
			Gain = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

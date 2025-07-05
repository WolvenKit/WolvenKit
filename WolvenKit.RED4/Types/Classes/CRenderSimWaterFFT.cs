using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CRenderSimWaterFFT : IDynamicTextureGenerator
	{
		[Ordinal(0)] 
		[RED("windDir")] 
		public CFloat WindDir
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("windSpeed")] 
		public CFloat WindSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("windScale")] 
		public CFloat WindScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("amplitude")] 
		public CFloat Amplitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("lambda")] 
		public CFloat Lambda
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CRenderSimWaterFFT()
		{
			WindSpeed = 8.000000F;
			WindScale = 1.000000F;
			Amplitude = 20.000000F;
			Lambda = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WaterAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("blurMin")] 
		public CFloat BlurMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("blurMax")] 
		public CFloat BlurMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("blurExponent")] 
		public CFloat BlurExponent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("depth")] 
		public CFloat Depth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("density")] 
		public CFloat Density
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("lightAbsorptionColor")] 
		public HDRColor LightAbsorptionColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(8)] 
		[RED("lightDecayColor")] 
		public HDRColor LightDecayColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(9)] 
		[RED("globalWaterMask")] 
		public CResourceReference<CBitmapTexture> GlobalWaterMask
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(10)] 
		[RED("windDir")] 
		public CLegacySingleChannelCurve<CFloat> WindDir
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(11)] 
		[RED("windSpeed")] 
		public CLegacySingleChannelCurve<CFloat> WindSpeed
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(12)] 
		[RED("windScale")] 
		public CLegacySingleChannelCurve<CFloat> WindScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(13)] 
		[RED("amplitude")] 
		public CLegacySingleChannelCurve<CFloat> Amplitude
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(14)] 
		[RED("lambda")] 
		public CLegacySingleChannelCurve<CFloat> Lambda
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public WaterAreaSettings()
		{
			Enable = true;
			BlurMax = 10.000000F;
			BlurExponent = 1.000000F;
			Depth = 50.000000F;
			Density = 10.000000F;
			LightAbsorptionColor = new() { Red = 0.100000F, Green = 0.500000F, Blue = 1.000000F, Alpha = 1.000000F };
			LightDecayColor = new() { Red = 0.100000F, Green = 0.130000F, Blue = 0.130000F, Alpha = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

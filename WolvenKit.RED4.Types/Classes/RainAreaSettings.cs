using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RainAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("numParticles")] 
		public CUInt32 NumParticles
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("heightRange")] 
		public CFloat HeightRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("globalLightResponse")] 
		public CFloat GlobalLightResponse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("tiling")] 
		public CLegacySingleChannelCurve<CFloat> Tiling
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("porosityThresholdStart")] 
		public CFloat PorosityThresholdStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("porosityThresholdEnd")] 
		public CFloat PorosityThresholdEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("glossinessFactor")] 
		public CFloat GlossinessFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("baseColorFactor")] 
		public CFloat BaseColorFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("moistureAccumulationSpeed")] 
		public CFloat MoistureAccumulationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("puddlesAccumulationSpeed")] 
		public CFloat PuddlesAccumulationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("moistureEvaporationSpeed")] 
		public CFloat MoistureEvaporationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("puddlesEvaporationSpeed")] 
		public CFloat PuddlesEvaporationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("rainIntensity")] 
		public CLegacySingleChannelCurve<CFloat> RainIntensity
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(16)] 
		[RED("rainOverride")] 
		public CLegacySingleChannelCurve<CFloat> RainOverride
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(17)] 
		[RED("rainMoistureOverride")] 
		public CLegacySingleChannelCurve<CFloat> RainMoistureOverride
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(18)] 
		[RED("rainPuddlesOverride")] 
		public CLegacySingleChannelCurve<CFloat> RainPuddlesOverride
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(19)] 
		[RED("waterRainIntensity")] 
		public CFloat WaterRainIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("rainleaksMask")] 
		public CResourceReference<CBitmapTexture> RainleaksMask
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(21)] 
		[RED("raindropsMask")] 
		public CResourceReference<CBitmapTexture> RaindropsMask
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(22)] 
		[RED("rainRipplesMask")] 
		public CResourceReference<CBitmapTexture> RainRipplesMask
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		public RainAreaSettings()
		{
			Enable = true;
			Radius = 45.000000F;
			HeightRange = 40.000000F;
			GlobalLightResponse = 1.000000F;
			PorosityThresholdStart = 0.400000F;
			PorosityThresholdEnd = 0.900000F;
			GlossinessFactor = 0.500000F;
			BaseColorFactor = 0.500000F;
			MoistureAccumulationSpeed = 5.000000F;
			PuddlesAccumulationSpeed = 1.500000F;
			MoistureEvaporationSpeed = 2.500000F;
			PuddlesEvaporationSpeed = 0.250000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

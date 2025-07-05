using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PathTracingSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("albedoModulation")] 
		public CFloat AlbedoModulation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("diffuseGlobalScale")] 
		public CFloat DiffuseGlobalScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("diffuseSunScale")] 
		public CFloat DiffuseSunScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("diffuseSkyScale")] 
		public CFloat DiffuseSkyScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("diffuseLocalLightsScale")] 
		public CFloat DiffuseLocalLightsScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("diffuseEmissiveScale")] 
		public CFloat DiffuseEmissiveScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("specularGlobalScale")] 
		public CFloat SpecularGlobalScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("specularSunScale")] 
		public CFloat SpecularSunScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("specularSkyScale")] 
		public CFloat SpecularSkyScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("specularLocalLightsScale")] 
		public CFloat SpecularLocalLightsScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("specularEmissiveScale")] 
		public CFloat SpecularEmissiveScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("maxIntensity")] 
		public CFloat MaxIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("GIOnlyLightScale")] 
		public CFloat GIOnlyLightScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("rayNumber")] 
		public CUInt32 RayNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(16)] 
		[RED("bounceNumber")] 
		public CUInt32 BounceNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(17)] 
		[RED("rayNumberScreenshot")] 
		public CUInt32 RayNumberScreenshot
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(18)] 
		[RED("bounceNumberScreenshot")] 
		public CUInt32 BounceNumberScreenshot
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PathTracingSettings()
		{
			Enable = true;
			DiffuseGlobalScale = 1.000000F;
			DiffuseSunScale = 1.000000F;
			DiffuseSkyScale = 1.000000F;
			DiffuseLocalLightsScale = 1.000000F;
			DiffuseEmissiveScale = 1.000000F;
			SpecularGlobalScale = 1.000000F;
			SpecularSunScale = 1.000000F;
			SpecularSkyScale = 1.000000F;
			SpecularLocalLightsScale = 1.000000F;
			SpecularEmissiveScale = 1.000000F;
			MaxIntensity = 10.000000F;
			GIOnlyLightScale = 0.350000F;
			RayNumber = 2;
			BounceNumber = 2;
			RayNumberScreenshot = 24;
			BounceNumberScreenshot = 3;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

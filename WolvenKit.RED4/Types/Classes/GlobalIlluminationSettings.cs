using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlobalIlluminationSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("multiBouceScale")] 
		public CLegacySingleChannelCurve<CFloat> MultiBouceScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("multiBouceSaturation")] 
		public CLegacySingleChannelCurve<CFloat> MultiBouceSaturation
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("emissiveScale")] 
		public CLegacySingleChannelCurve<CFloat> EmissiveScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("diffuseScale")] 
		public CLegacySingleChannelCurve<CFloat> DiffuseScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("localLightsScale")] 
		public CLegacySingleChannelCurve<CFloat> LocalLightsScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("lightScaleCompenensation")] 
		public CLegacySingleChannelCurve<CFloat> LightScaleCompenensation
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(8)] 
		[RED("reflectionCompensation")] 
		public CLegacySingleChannelCurve<CFloat> ReflectionCompensation
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("ambientBase")] 
		public CLegacySingleChannelCurve<HDRColor> AmbientBase
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(10)] 
		[RED("rayTracedSkyRadianceScale")] 
		public CLegacySingleChannelCurve<CFloat> RayTracedSkyRadianceScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public GlobalIlluminationSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

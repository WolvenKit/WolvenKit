using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldWorldGlobalLightParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("unit")] 
		public CEnum<ELightUnit> Unit
		{
			get => GetPropertyValue<CEnum<ELightUnit>>();
			set => SetPropertyValue<CEnum<ELightUnit>>(value);
		}

		[Ordinal(1)] 
		[RED("sunColor")] 
		public CLegacySingleChannelCurve<HDRColor> SunColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(2)] 
		[RED("moonColor")] 
		public CLegacySingleChannelCurve<HDRColor> MoonColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(3)] 
		[RED("sunSize")] 
		public CLegacySingleChannelCurve<CFloat> SunSize
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("moonSize")] 
		public CLegacySingleChannelCurve<CFloat> MoonSize
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("specularTint")] 
		public CLegacySingleChannelCurve<HDRColor> SpecularTint
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		public worldWorldGlobalLightParameters()
		{
			Unit = Enums.ELightUnit.LU_Lux;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

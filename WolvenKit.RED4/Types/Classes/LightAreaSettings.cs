using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LightAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("latitude")] 
		public CLegacySingleChannelCurve<CFloat> Latitude
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("season")] 
		public CEnum<ETimeOfYearSeason> Season
		{
			get => GetPropertyValue<CEnum<ETimeOfYearSeason>>();
			set => SetPropertyValue<CEnum<ETimeOfYearSeason>>(value);
		}

		[Ordinal(4)] 
		[RED("sunRotationOffset")] 
		public CLegacySingleChannelCurve<CFloat> SunRotationOffset
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("sunColor")] 
		public CLegacySingleChannelCurve<HDRColor> SunColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(6)] 
		[RED("sunSize")] 
		public CLegacySingleChannelCurve<CFloat> SunSize
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("moonRotationOffset")] 
		public CLegacySingleChannelCurve<CFloat> MoonRotationOffset
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(8)] 
		[RED("moonColor")] 
		public CLegacySingleChannelCurve<HDRColor> MoonColor
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(9)] 
		[RED("moonSize")] 
		public CLegacySingleChannelCurve<CFloat> MoonSize
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(10)] 
		[RED("specularTint")] 
		public CLegacySingleChannelCurve<HDRColor> SpecularTint
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		public LightAreaSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

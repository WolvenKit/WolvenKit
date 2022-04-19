using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RTAOAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("RangeNear")] 
		public CLegacySingleChannelCurve<CFloat> RangeNear
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("RangeFar")] 
		public CLegacySingleChannelCurve<CFloat> RangeFar
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("RadiusNear")] 
		public CLegacySingleChannelCurve<CFloat> RadiusNear
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("RadiusFar")] 
		public CLegacySingleChannelCurve<CFloat> RadiusFar
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("coneAoDiffuseStrength")] 
		public CLegacySingleChannelCurve<CFloat> ConeAoDiffuseStrength
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("coneAoSpecularStrength")] 
		public CLegacySingleChannelCurve<CFloat> ConeAoSpecularStrength
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(8)] 
		[RED("coneAoSpecularTreshold")] 
		public CLegacySingleChannelCurve<CFloat> ConeAoSpecularTreshold
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("lightAoDiffuseStrength")] 
		public CLegacySingleChannelCurve<CFloat> LightAoDiffuseStrength
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(10)] 
		[RED("lightAoSpecularStrength")] 
		public CLegacySingleChannelCurve<CFloat> LightAoSpecularStrength
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public RTAOAreaSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

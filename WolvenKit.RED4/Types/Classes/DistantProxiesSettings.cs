using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DistantProxiesSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("distantProxiesEmissive")] 
		public CFloat DistantProxiesEmissive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("distantProxiesEmissiveHeight")] 
		public CFloat DistantProxiesEmissiveHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("distantProxiesEmissivePower")] 
		public CFloat DistantProxiesEmissivePower
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("distantProxiesBboxzBlend")] 
		public CFloat DistantProxiesBboxzBlend
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DistantProxiesSettings()
		{
			Enable = true;
			DistantProxiesEmissiveHeight = 500.000000F;
			DistantProxiesEmissivePower = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

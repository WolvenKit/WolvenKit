using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SSSRAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("depthFadeStart")] 
		public CFloat DepthFadeStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("depthFadeEnd")] 
		public CFloat DepthFadeEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SSSRAreaSettings()
		{
			Enable = true;
			DepthFadeStart = 4000.000000F;
			DepthFadeEnd = 5000.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SharpeningAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("sharpeningStrength")] 
		public CFloat SharpeningStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("sharpeningStrengthWhenUpsaling")] 
		public CFloat SharpeningStrengthWhenUpsaling
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("sharpeningStrengthUpscalingTreshold")] 
		public CFloat SharpeningStrengthUpscalingTreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SharpeningAreaSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

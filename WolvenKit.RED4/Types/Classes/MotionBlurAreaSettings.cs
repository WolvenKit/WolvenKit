using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MotionBlurAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public MotionBlurAreaSettings()
		{
			Enable = true;
			Strength = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SwimmingTransitionEvents : LocomotionSwimmingEvents
	{
		[Ordinal(6)] 
		[RED("maxDownwardSpeed")] 
		public CFloat MaxDownwardSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("minDownwardsSpeed")] 
		public CFloat MinDownwardsSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("upwardsImpulseStrength")] 
		public CFloat UpwardsImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SwimmingTransitionEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

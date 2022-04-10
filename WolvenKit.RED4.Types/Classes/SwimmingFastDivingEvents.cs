using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SwimmingFastDivingEvents : LocomotionSwimmingEvents
	{
		[Ordinal(6)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SwimmingFastDivingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

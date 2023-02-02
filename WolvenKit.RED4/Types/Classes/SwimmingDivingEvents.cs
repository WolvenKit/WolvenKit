using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SwimmingDivingEvents : LocomotionSwimmingEvents
	{
		[Ordinal(6)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SwimmingDivingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

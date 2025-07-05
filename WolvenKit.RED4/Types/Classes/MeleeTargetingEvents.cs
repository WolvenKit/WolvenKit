using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeTargetingEvents : MeleeEventsTransition
	{
		[Ordinal(2)] 
		[RED("aimInTimeRemaining")] 
		public CFloat AimInTimeRemaining
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public MeleeTargetingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

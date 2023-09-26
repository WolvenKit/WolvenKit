using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class MeleeHoldGenericDecisions : MeleeTransition
	{
		[Ordinal(1)] 
		[RED("driverCombatListener")] 
		public CHandle<DriverCombatListener> DriverCombatListener
		{
			get => GetPropertyValue<CHandle<DriverCombatListener>>();
			set => SetPropertyValue<CHandle<DriverCombatListener>>(value);
		}

		public MeleeHoldGenericDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

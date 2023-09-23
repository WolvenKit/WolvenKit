using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeMountedStrongAttackDecisions : MeleeStrongAttackDecisions
	{
		[Ordinal(1)] 
		[RED("driverCombatListener")] 
		public CHandle<DriverCombatListener> DriverCombatListener
		{
			get => GetPropertyValue<CHandle<DriverCombatListener>>();
			set => SetPropertyValue<CHandle<DriverCombatListener>>(value);
		}

		public MeleeMountedStrongAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

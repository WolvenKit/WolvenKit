using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeMountedComboAttackDecisions : MeleeComboAttackDecisions
	{
		[Ordinal(1)] 
		[RED("driverCombatListener")] 
		public CHandle<DriverCombatListener> DriverCombatListener
		{
			get => GetPropertyValue<CHandle<DriverCombatListener>>();
			set => SetPropertyValue<CHandle<DriverCombatListener>>(value);
		}

		public MeleeMountedComboAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

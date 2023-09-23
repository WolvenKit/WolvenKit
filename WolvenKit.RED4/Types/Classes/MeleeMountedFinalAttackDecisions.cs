using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeMountedFinalAttackDecisions : MeleeFinalAttackDecisions
	{
		[Ordinal(1)] 
		[RED("driverCombatListener")] 
		public CHandle<DriverCombatListener> DriverCombatListener
		{
			get => GetPropertyValue<CHandle<DriverCombatListener>>();
			set => SetPropertyValue<CHandle<DriverCombatListener>>(value);
		}

		public MeleeMountedFinalAttackDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

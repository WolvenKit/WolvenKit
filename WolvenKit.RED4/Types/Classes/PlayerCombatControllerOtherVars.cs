using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerCombatControllerOtherVars : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<PlayerCombatState> State
		{
			get => GetPropertyValue<CEnum<PlayerCombatState>>();
			set => SetPropertyValue<CEnum<PlayerCombatState>>(value);
		}

		public PlayerCombatControllerOtherVars()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerCombatControllerBlackboardListenersFunctions : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CName CrouchActive
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PlayerCombatControllerBlackboardListenersFunctions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

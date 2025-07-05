using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerCombatControllerBBListeners : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CHandle<redCallbackObject> CrouchActive
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public PlayerCombatControllerBBListeners()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerCombatControllerBBIds : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CHandle<gamebbScriptDefinition> CrouchActive
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		public PlayerCombatControllerBBIds()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

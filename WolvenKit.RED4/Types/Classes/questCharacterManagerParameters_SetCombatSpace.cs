using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerParameters_SetCombatSpace : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("combatSpaceSize")] 
		public CEnum<AICombatSpaceSize> CombatSpaceSize
		{
			get => GetPropertyValue<CEnum<AICombatSpaceSize>>();
			set => SetPropertyValue<CEnum<AICombatSpaceSize>>(value);
		}

		public questCharacterManagerParameters_SetCombatSpace()
		{
			PuppetRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

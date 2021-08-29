using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerParameters_SetCombatSpace : questICharacterManagerCombat_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CEnum<AICombatSpaceSize> _combatSpaceSize;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("combatSpaceSize")] 
		public CEnum<AICombatSpaceSize> CombatSpaceSize
		{
			get => GetProperty(ref _combatSpaceSize);
			set => SetProperty(ref _combatSpaceSize, value);
		}
	}
}

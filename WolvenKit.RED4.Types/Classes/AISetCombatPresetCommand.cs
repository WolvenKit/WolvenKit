using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISetCombatPresetCommand : AICombatRelatedCommand
	{
		private CEnum<EAICombatPreset> _combatPreset;

		[Ordinal(5)] 
		[RED("combatPreset")] 
		public CEnum<EAICombatPreset> CombatPreset
		{
			get => GetProperty(ref _combatPreset);
			set => SetProperty(ref _combatPreset, value);
		}
	}
}

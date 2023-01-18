using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AISetCombatPresetCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] 
		[RED("combatPreset")] 
		public CEnum<EAICombatPreset> CombatPreset
		{
			get => GetPropertyValue<CEnum<EAICombatPreset>>();
			set => SetPropertyValue<CEnum<EAICombatPreset>>(value);
		}

		public AISetCombatPresetCommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

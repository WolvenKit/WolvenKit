using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_StealthDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _combatDebug;
		private gamebbScriptID_Uint32 _numberOfCombatants;

		[Ordinal(0)] 
		[RED("CombatDebug")] 
		public gamebbScriptID_Bool CombatDebug
		{
			get => GetProperty(ref _combatDebug);
			set => SetProperty(ref _combatDebug, value);
		}

		[Ordinal(1)] 
		[RED("numberOfCombatants")] 
		public gamebbScriptID_Uint32 NumberOfCombatants
		{
			get => GetProperty(ref _numberOfCombatants);
			set => SetProperty(ref _numberOfCombatants, value);
		}
	}
}

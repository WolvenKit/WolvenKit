using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_StealthDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("CombatDebug")] 
		public gamebbScriptID_Bool CombatDebug
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("numberOfCombatants")] 
		public gamebbScriptID_Uint32 NumberOfCombatants
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		public UI_StealthDef()
		{
			CombatDebug = new gamebbScriptID_Bool();
			NumberOfCombatants = new gamebbScriptID_Uint32();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_LevelUpDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("level")] 
		public gamebbScriptID_Variant Level
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_LevelUpDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

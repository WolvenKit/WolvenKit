using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_HUDButtonHintDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("ActionsData")] 
		public gamebbScriptID_Variant ActionsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_HUDButtonHintDef()
		{
			ActionsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

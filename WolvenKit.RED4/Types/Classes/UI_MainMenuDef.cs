using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_MainMenuDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("ShowDataValidationError")] 
		public gamebbScriptID_Bool ShowDataValidationError
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_MainMenuDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

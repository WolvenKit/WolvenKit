using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MenuEventBlackboardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("MenuEventToTrigger")] 
		public gamebbScriptID_CName MenuEventToTrigger
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		public MenuEventBlackboardDef()
		{
			MenuEventToTrigger = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

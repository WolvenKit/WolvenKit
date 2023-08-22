using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_HUDNarrationLogDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("LastEvent")] 
		public gamebbScriptID_Variant LastEvent
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_HUDNarrationLogDef()
		{
			LastEvent = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

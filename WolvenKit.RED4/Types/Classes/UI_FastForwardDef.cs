using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_FastForwardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("FastForwardAvailable")] 
		public gamebbScriptID_Bool FastForwardAvailable
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("FastForwardActive")] 
		public gamebbScriptID_Bool FastForwardActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_FastForwardDef()
		{
			FastForwardAvailable = new();
			FastForwardActive = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

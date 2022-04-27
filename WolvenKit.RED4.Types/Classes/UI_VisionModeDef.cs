using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_VisionModeDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("isEnabled")] 
		public gamebbScriptID_Bool IsEnabled
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_VisionModeDef()
		{
			IsEnabled = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

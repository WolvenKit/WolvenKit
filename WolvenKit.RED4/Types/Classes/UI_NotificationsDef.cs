using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_NotificationsDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("WarningMessage")] 
		public gamebbScriptID_Variant WarningMessage
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("OnscreenMessage")] 
		public gamebbScriptID_Variant OnscreenMessage
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_NotificationsDef()
		{
			WarningMessage = new gamebbScriptID_Variant();
			OnscreenMessage = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

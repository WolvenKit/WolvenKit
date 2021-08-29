using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_NotificationsDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _warningMessage;
		private gamebbScriptID_Variant _onscreenMessage;

		[Ordinal(0)] 
		[RED("WarningMessage")] 
		public gamebbScriptID_Variant WarningMessage
		{
			get => GetProperty(ref _warningMessage);
			set => SetProperty(ref _warningMessage, value);
		}

		[Ordinal(1)] 
		[RED("OnscreenMessage")] 
		public gamebbScriptID_Variant OnscreenMessage
		{
			get => GetProperty(ref _onscreenMessage);
			set => SetProperty(ref _onscreenMessage, value);
		}
	}
}

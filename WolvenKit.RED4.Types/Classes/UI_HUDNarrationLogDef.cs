using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_HUDNarrationLogDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _lastEvent;

		[Ordinal(0)] 
		[RED("LastEvent")] 
		public gamebbScriptID_Variant LastEvent
		{
			get => GetProperty(ref _lastEvent);
			set => SetProperty(ref _lastEvent, value);
		}
	}
}

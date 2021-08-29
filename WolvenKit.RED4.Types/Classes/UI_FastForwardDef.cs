using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_FastForwardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _fastForwardAvailable;
		private gamebbScriptID_Bool _fastForwardActive;

		[Ordinal(0)] 
		[RED("FastForwardAvailable")] 
		public gamebbScriptID_Bool FastForwardAvailable
		{
			get => GetProperty(ref _fastForwardAvailable);
			set => SetProperty(ref _fastForwardAvailable, value);
		}

		[Ordinal(1)] 
		[RED("FastForwardActive")] 
		public gamebbScriptID_Bool FastForwardActive
		{
			get => GetProperty(ref _fastForwardActive);
			set => SetProperty(ref _fastForwardActive, value);
		}
	}
}

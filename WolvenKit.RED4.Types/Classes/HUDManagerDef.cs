using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HUDManagerDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _showHudHintMessege;
		private gamebbScriptID_String _hudHintMessegeContent;

		[Ordinal(0)] 
		[RED("ShowHudHintMessege")] 
		public gamebbScriptID_Bool ShowHudHintMessege
		{
			get => GetProperty(ref _showHudHintMessege);
			set => SetProperty(ref _showHudHintMessege, value);
		}

		[Ordinal(1)] 
		[RED("HudHintMessegeContent")] 
		public gamebbScriptID_String HudHintMessegeContent
		{
			get => GetProperty(ref _hudHintMessegeContent);
			set => SetProperty(ref _hudHintMessegeContent, value);
		}
	}
}

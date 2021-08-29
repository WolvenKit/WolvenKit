using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuEventBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_CName _menuEventToTrigger;

		[Ordinal(0)] 
		[RED("MenuEventToTrigger")] 
		public gamebbScriptID_CName MenuEventToTrigger
		{
			get => GetProperty(ref _menuEventToTrigger);
			set => SetProperty(ref _menuEventToTrigger, value);
		}
	}
}

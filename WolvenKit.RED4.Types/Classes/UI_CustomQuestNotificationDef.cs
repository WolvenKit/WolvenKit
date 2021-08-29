using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_CustomQuestNotificationDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _data;

		[Ordinal(0)] 
		[RED("data")] 
		public gamebbScriptID_Variant Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}

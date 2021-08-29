using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_HUDButtonHintDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _actionsData;

		[Ordinal(0)] 
		[RED("ActionsData")] 
		public gamebbScriptID_Variant ActionsData
		{
			get => GetProperty(ref _actionsData);
			set => SetProperty(ref _actionsData, value);
		}
	}
}

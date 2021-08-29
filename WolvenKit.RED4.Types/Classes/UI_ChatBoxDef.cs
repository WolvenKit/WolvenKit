using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_ChatBoxDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _textList;

		[Ordinal(0)] 
		[RED("TextList")] 
		public gamebbScriptID_Variant TextList
		{
			get => GetProperty(ref _textList);
			set => SetProperty(ref _textList, value);
		}
	}
}

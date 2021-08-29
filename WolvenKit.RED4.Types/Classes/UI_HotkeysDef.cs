using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_HotkeysDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _modifiedHotkey;

		[Ordinal(0)] 
		[RED("ModifiedHotkey")] 
		public gamebbScriptID_Variant ModifiedHotkey
		{
			get => GetProperty(ref _modifiedHotkey);
			set => SetProperty(ref _modifiedHotkey, value);
		}
	}
}

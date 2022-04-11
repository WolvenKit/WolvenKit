using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_HotkeysDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("ModifiedHotkey")] 
		public gamebbScriptID_Variant ModifiedHotkey
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_HotkeysDef()
		{
			ModifiedHotkey = new();
		}
	}
}

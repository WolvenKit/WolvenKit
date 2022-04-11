using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_ItemLogDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("ItemLogItem")] 
		public gamebbScriptID_Variant ItemLogItem
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_ItemLogDef()
		{
			ItemLogItem = new();
		}
	}
}

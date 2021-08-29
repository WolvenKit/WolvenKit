using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_ItemLogDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _itemLogItem;

		[Ordinal(0)] 
		[RED("ItemLogItem")] 
		public gamebbScriptID_Variant ItemLogItem
		{
			get => GetProperty(ref _itemLogItem);
			set => SetProperty(ref _itemLogItem, value);
		}
	}
}

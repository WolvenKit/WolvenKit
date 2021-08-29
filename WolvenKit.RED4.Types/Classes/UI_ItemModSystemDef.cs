using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_ItemModSystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _itemModSystemUpdated;

		[Ordinal(0)] 
		[RED("ItemModSystemUpdated")] 
		public gamebbScriptID_Variant ItemModSystemUpdated
		{
			get => GetProperty(ref _itemModSystemUpdated);
			set => SetProperty(ref _itemModSystemUpdated, value);
		}
	}
}

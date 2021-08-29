using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_HudTooltipDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _itemId;
		private gamebbScriptID_Bool _showTooltip;

		[Ordinal(0)] 
		[RED("ItemId")] 
		public gamebbScriptID_Variant ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(1)] 
		[RED("ShowTooltip")] 
		public gamebbScriptID_Bool ShowTooltip
		{
			get => GetProperty(ref _showTooltip);
			set => SetProperty(ref _showTooltip, value);
		}
	}
}

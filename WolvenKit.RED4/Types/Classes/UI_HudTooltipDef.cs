using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_HudTooltipDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("ItemId")] 
		public gamebbScriptID_Variant ItemId
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("ShowTooltip")] 
		public gamebbScriptID_Bool ShowTooltip
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_HudTooltipDef()
		{
			ItemId = new();
			ShowTooltip = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

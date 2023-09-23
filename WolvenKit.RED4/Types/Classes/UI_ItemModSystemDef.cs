using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_ItemModSystemDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("ItemModSystemUpdated")] 
		public gamebbScriptID_Variant ItemModSystemUpdated
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("ItemModSystemUpgradingInProgress")] 
		public gamebbScriptID_Bool ItemModSystemUpgradingInProgress
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_ItemModSystemDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

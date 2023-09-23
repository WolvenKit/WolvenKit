using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_TopbarHubMenuDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("IsSubmenuHidden")] 
		public gamebbScriptID_Bool IsSubmenuHidden
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("MetaQuestStatus")] 
		public gamebbScriptID_Variant MetaQuestStatus
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_TopbarHubMenuDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

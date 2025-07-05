using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_BriefingDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("BriefingToOpen")] 
		public gamebbScriptID_String BriefingToOpen
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(1)] 
		[RED("BriefingSize")] 
		public gamebbScriptID_Variant BriefingSize
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("BriefingAlignment")] 
		public gamebbScriptID_Variant BriefingAlignment
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_BriefingDef()
		{
			BriefingToOpen = new gamebbScriptID_String();
			BriefingSize = new gamebbScriptID_Variant();
			BriefingAlignment = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

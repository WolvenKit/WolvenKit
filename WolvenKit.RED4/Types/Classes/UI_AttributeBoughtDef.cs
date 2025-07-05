using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_AttributeBoughtDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("attribute")] 
		public gamebbScriptID_Variant Attribute
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_AttributeBoughtDef()
		{
			Attribute = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

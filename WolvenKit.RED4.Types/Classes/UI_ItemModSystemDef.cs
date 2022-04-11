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

		public UI_ItemModSystemDef()
		{
			ItemModSystemUpdated = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

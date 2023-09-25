using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_CraftingDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("lastCommand")] 
		public gamebbScriptID_Variant LastCommand
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("lastItem")] 
		public gamebbScriptID_Variant LastItem
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("lastIngredients")] 
		public gamebbScriptID_Variant LastIngredients
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_CraftingDef()
		{
			LastCommand = new gamebbScriptID_Variant();
			LastItem = new gamebbScriptID_Variant();
			LastIngredients = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

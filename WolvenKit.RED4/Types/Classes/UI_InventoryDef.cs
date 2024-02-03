using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_InventoryDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("itemAdded")] 
		public gamebbScriptID_Variant ItemAdded
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("itemRemoved")] 
		public gamebbScriptID_Variant ItemRemoved
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("itemQuantityChanged")] 
		public gamebbScriptID_Variant ItemQuantityChanged
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_InventoryDef()
		{
			ItemAdded = new gamebbScriptID_Variant();
			ItemRemoved = new gamebbScriptID_Variant();
			ItemQuantityChanged = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemModeInventoryListenerCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("itemModeInstance")] 
		public CWeakHandle<InventoryItemModeLogicController> ItemModeInstance
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemModeLogicController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemModeLogicController>>(value);
		}

		public ItemModeInventoryListenerCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

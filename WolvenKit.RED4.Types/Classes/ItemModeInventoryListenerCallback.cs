using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemModeInventoryListenerCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("itemModeInstance")] 
		public CWeakHandle<InventoryItemModeLogicController> ItemModeInstance
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemModeLogicController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemModeLogicController>>(value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemModeInventoryListenerCallback : gameInventoryScriptCallback
	{
		private CWeakHandle<InventoryItemModeLogicController> _itemModeInstance;

		[Ordinal(1)] 
		[RED("itemModeInstance")] 
		public CWeakHandle<InventoryItemModeLogicController> ItemModeInstance
		{
			get => GetProperty(ref _itemModeInstance);
			set => SetProperty(ref _itemModeInstance, value);
		}
	}
}

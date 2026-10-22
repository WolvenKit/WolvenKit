using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemChooserUnequipMod : redEvent
	{
		[Ordinal(0)] 
		[RED("itemChooser")] 
		public CWeakHandle<InventoryGenericItemChooser> ItemChooser
		{
			get => GetPropertyValue<CWeakHandle<InventoryGenericItemChooser>>();
			set => SetPropertyValue<CWeakHandle<InventoryGenericItemChooser>>(value);
		}

		[Ordinal(1)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(2)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ItemChooserUnequipMod()
		{
			ItemData = new gameInventoryItemData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

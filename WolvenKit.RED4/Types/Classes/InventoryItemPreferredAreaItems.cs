using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemPreferredAreaItems : IScriptable
	{
		[Ordinal(0)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(1)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<CWeakHandle<UIInventoryItem>> Items
		{
			get => GetPropertyValue<CArray<CWeakHandle<UIInventoryItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<UIInventoryItem>>>(value);
		}

		public InventoryItemPreferredAreaItems()
		{
			Items = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

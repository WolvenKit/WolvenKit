using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemPreferredAreaItems : IScriptable
	{
		[Ordinal(0)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<InventoryItemData> Items
		{
			get => GetPropertyValue<CArray<InventoryItemData>>();
			set => SetPropertyValue<CArray<InventoryItemData>>(value);
		}

		public ItemPreferredAreaItems()
		{
			Items = new();
		}
	}
}

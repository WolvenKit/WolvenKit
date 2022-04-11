using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentAreaCategoryCreated : redEvent
	{
		[Ordinal(0)] 
		[RED("categoryController")] 
		public CWeakHandle<InventoryItemDisplayCategoryArea> CategoryController
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayCategoryArea>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayCategoryArea>>(value);
		}

		[Ordinal(1)] 
		[RED("equipmentAreasControllers")] 
		public CArray<CWeakHandle<InventoryItemDisplayEquipmentArea>> EquipmentAreasControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayEquipmentArea>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayEquipmentArea>>>(value);
		}

		public EquipmentAreaCategoryCreated()
		{
			EquipmentAreasControllers = new();
		}
	}
}

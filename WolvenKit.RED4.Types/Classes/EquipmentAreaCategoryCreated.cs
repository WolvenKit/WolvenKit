using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentAreaCategoryCreated : redEvent
	{
		private CWeakHandle<InventoryItemDisplayCategoryArea> _categoryController;
		private CArray<CWeakHandle<InventoryItemDisplayEquipmentArea>> _equipmentAreasControllers;

		[Ordinal(0)] 
		[RED("categoryController")] 
		public CWeakHandle<InventoryItemDisplayCategoryArea> CategoryController
		{
			get => GetProperty(ref _categoryController);
			set => SetProperty(ref _categoryController, value);
		}

		[Ordinal(1)] 
		[RED("equipmentAreasControllers")] 
		public CArray<CWeakHandle<InventoryItemDisplayEquipmentArea>> EquipmentAreasControllers
		{
			get => GetProperty(ref _equipmentAreasControllers);
			set => SetProperty(ref _equipmentAreasControllers, value);
		}
	}
}

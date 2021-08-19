using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentAreaCategoryCreated : redEvent
	{
		private wCHandle<InventoryItemDisplayCategoryArea> _categoryController;
		private CArray<wCHandle<InventoryItemDisplayEquipmentArea>> _equipmentAreasControllers;

		[Ordinal(0)] 
		[RED("categoryController")] 
		public wCHandle<InventoryItemDisplayCategoryArea> CategoryController
		{
			get => GetProperty(ref _categoryController);
			set => SetProperty(ref _categoryController, value);
		}

		[Ordinal(1)] 
		[RED("equipmentAreasControllers")] 
		public CArray<wCHandle<InventoryItemDisplayEquipmentArea>> EquipmentAreasControllers
		{
			get => GetProperty(ref _equipmentAreasControllers);
			set => SetProperty(ref _equipmentAreasControllers, value);
		}

		public EquipmentAreaCategoryCreated(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

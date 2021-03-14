using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentAreaCategoryCreated : redEvent
	{
		private CHandle<InventoryItemDisplayCategoryArea> _categoryController;
		private CArray<CHandle<InventoryItemDisplayEquipmentArea>> _equipmentAreasControllers;

		[Ordinal(0)] 
		[RED("categoryController")] 
		public CHandle<InventoryItemDisplayCategoryArea> CategoryController
		{
			get
			{
				if (_categoryController == null)
				{
					_categoryController = (CHandle<InventoryItemDisplayCategoryArea>) CR2WTypeManager.Create("handle:InventoryItemDisplayCategoryArea", "categoryController", cr2w, this);
				}
				return _categoryController;
			}
			set
			{
				if (_categoryController == value)
				{
					return;
				}
				_categoryController = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("equipmentAreasControllers")] 
		public CArray<CHandle<InventoryItemDisplayEquipmentArea>> EquipmentAreasControllers
		{
			get
			{
				if (_equipmentAreasControllers == null)
				{
					_equipmentAreasControllers = (CArray<CHandle<InventoryItemDisplayEquipmentArea>>) CR2WTypeManager.Create("array:handle:InventoryItemDisplayEquipmentArea", "equipmentAreasControllers", cr2w, this);
				}
				return _equipmentAreasControllers;
			}
			set
			{
				if (_equipmentAreasControllers == value)
				{
					return;
				}
				_equipmentAreasControllers = value;
				PropertySet(this);
			}
		}

		public EquipmentAreaCategoryCreated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

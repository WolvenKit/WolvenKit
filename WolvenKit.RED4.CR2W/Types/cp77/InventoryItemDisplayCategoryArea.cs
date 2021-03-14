using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemDisplayCategoryArea : inkWidgetLogicController
	{
		private CArray<inkWidgetReference> _areasToHide;
		private CArray<inkCompoundWidgetReference> _equipmentAreas;
		private inkWidgetReference _newItemsWrapper;
		private inkTextWidgetReference _newItemsCounter;
		private CArray<CHandle<InventoryItemDisplayEquipmentArea>> _categoryAreas;

		[Ordinal(1)] 
		[RED("areasToHide")] 
		public CArray<inkWidgetReference> AreasToHide
		{
			get
			{
				if (_areasToHide == null)
				{
					_areasToHide = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "areasToHide", cr2w, this);
				}
				return _areasToHide;
			}
			set
			{
				if (_areasToHide == value)
				{
					return;
				}
				_areasToHide = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("equipmentAreas")] 
		public CArray<inkCompoundWidgetReference> EquipmentAreas
		{
			get
			{
				if (_equipmentAreas == null)
				{
					_equipmentAreas = (CArray<inkCompoundWidgetReference>) CR2WTypeManager.Create("array:inkCompoundWidgetReference", "equipmentAreas", cr2w, this);
				}
				return _equipmentAreas;
			}
			set
			{
				if (_equipmentAreas == value)
				{
					return;
				}
				_equipmentAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("newItemsWrapper")] 
		public inkWidgetReference NewItemsWrapper
		{
			get
			{
				if (_newItemsWrapper == null)
				{
					_newItemsWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "newItemsWrapper", cr2w, this);
				}
				return _newItemsWrapper;
			}
			set
			{
				if (_newItemsWrapper == value)
				{
					return;
				}
				_newItemsWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("newItemsCounter")] 
		public inkTextWidgetReference NewItemsCounter
		{
			get
			{
				if (_newItemsCounter == null)
				{
					_newItemsCounter = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "newItemsCounter", cr2w, this);
				}
				return _newItemsCounter;
			}
			set
			{
				if (_newItemsCounter == value)
				{
					return;
				}
				_newItemsCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("categoryAreas")] 
		public CArray<CHandle<InventoryItemDisplayEquipmentArea>> CategoryAreas
		{
			get
			{
				if (_categoryAreas == null)
				{
					_categoryAreas = (CArray<CHandle<InventoryItemDisplayEquipmentArea>>) CR2WTypeManager.Create("array:handle:InventoryItemDisplayEquipmentArea", "categoryAreas", cr2w, this);
				}
				return _categoryAreas;
			}
			set
			{
				if (_categoryAreas == value)
				{
					return;
				}
				_categoryAreas = value;
				PropertySet(this);
			}
		}

		public InventoryItemDisplayCategoryArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

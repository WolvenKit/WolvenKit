using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareInventoryMiniGrid : inkWidgetLogicController
	{
		private inkUniformGridWidgetReference _gridContainer;
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _sublabel;
		private inkTextWidgetReference _number;
		private inkWidgetReference _numberPanel;
		private CInt32 _gridWidth;
		private CInt32 _selectedSlotIndex;
		private CInt32 _toEquipeSlotIndex;
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CHandle<IScriptable> _parentObject;
		private CName _onRealeaseCallbackName;
		private CArray<CHandle<InventoryItemDisplayController>> _gridData;

		[Ordinal(1)] 
		[RED("gridContainer")] 
		public inkUniformGridWidgetReference GridContainer
		{
			get
			{
				if (_gridContainer == null)
				{
					_gridContainer = (inkUniformGridWidgetReference) CR2WTypeManager.Create("inkUniformGridWidgetReference", "gridContainer", cr2w, this);
				}
				return _gridContainer;
			}
			set
			{
				if (_gridContainer == value)
				{
					return;
				}
				_gridContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sublabel")] 
		public inkTextWidgetReference Sublabel
		{
			get
			{
				if (_sublabel == null)
				{
					_sublabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "sublabel", cr2w, this);
				}
				return _sublabel;
			}
			set
			{
				if (_sublabel == value)
				{
					return;
				}
				_sublabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("number")] 
		public inkTextWidgetReference Number
		{
			get
			{
				if (_number == null)
				{
					_number = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "number", cr2w, this);
				}
				return _number;
			}
			set
			{
				if (_number == value)
				{
					return;
				}
				_number = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("numberPanel")] 
		public inkWidgetReference NumberPanel
		{
			get
			{
				if (_numberPanel == null)
				{
					_numberPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "numberPanel", cr2w, this);
				}
				return _numberPanel;
			}
			set
			{
				if (_numberPanel == value)
				{
					return;
				}
				_numberPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("gridWidth")] 
		public CInt32 GridWidth
		{
			get
			{
				if (_gridWidth == null)
				{
					_gridWidth = (CInt32) CR2WTypeManager.Create("Int32", "gridWidth", cr2w, this);
				}
				return _gridWidth;
			}
			set
			{
				if (_gridWidth == value)
				{
					return;
				}
				_gridWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("selectedSlotIndex")] 
		public CInt32 SelectedSlotIndex
		{
			get
			{
				if (_selectedSlotIndex == null)
				{
					_selectedSlotIndex = (CInt32) CR2WTypeManager.Create("Int32", "selectedSlotIndex", cr2w, this);
				}
				return _selectedSlotIndex;
			}
			set
			{
				if (_selectedSlotIndex == value)
				{
					return;
				}
				_selectedSlotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("toEquipeSlotIndex")] 
		public CInt32 ToEquipeSlotIndex
		{
			get
			{
				if (_toEquipeSlotIndex == null)
				{
					_toEquipeSlotIndex = (CInt32) CR2WTypeManager.Create("Int32", "toEquipeSlotIndex", cr2w, this);
				}
				return _toEquipeSlotIndex;
			}
			set
			{
				if (_toEquipeSlotIndex == value)
				{
					return;
				}
				_toEquipeSlotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get
			{
				if (_equipArea == null)
				{
					_equipArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipArea", cr2w, this);
				}
				return _equipArea;
			}
			set
			{
				if (_equipArea == value)
				{
					return;
				}
				_equipArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("parentObject")] 
		public CHandle<IScriptable> ParentObject
		{
			get
			{
				if (_parentObject == null)
				{
					_parentObject = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "parentObject", cr2w, this);
				}
				return _parentObject;
			}
			set
			{
				if (_parentObject == value)
				{
					return;
				}
				_parentObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("onRealeaseCallbackName")] 
		public CName OnRealeaseCallbackName
		{
			get
			{
				if (_onRealeaseCallbackName == null)
				{
					_onRealeaseCallbackName = (CName) CR2WTypeManager.Create("CName", "onRealeaseCallbackName", cr2w, this);
				}
				return _onRealeaseCallbackName;
			}
			set
			{
				if (_onRealeaseCallbackName == value)
				{
					return;
				}
				_onRealeaseCallbackName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("gridData")] 
		public CArray<CHandle<InventoryItemDisplayController>> GridData
		{
			get
			{
				if (_gridData == null)
				{
					_gridData = (CArray<CHandle<InventoryItemDisplayController>>) CR2WTypeManager.Create("array:handle:InventoryItemDisplayController", "gridData", cr2w, this);
				}
				return _gridData;
			}
			set
			{
				if (_gridData == value)
				{
					return;
				}
				_gridData = value;
				PropertySet(this);
			}
		}

		public CyberwareInventoryMiniGrid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

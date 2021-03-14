using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryEquipmentSlot : inkWidgetLogicController
	{
		private inkWidgetReference _equipSlotRef;
		private inkWidgetReference _emptySlotButtonRef;
		private inkImageWidgetReference _backgroundShape;
		private inkImageWidgetReference _backgroundHighlight;
		private inkImageWidgetReference _backgroundFrame;
		private inkWidgetReference _unavailableIcon;
		private inkImageWidgetReference _toggleHighlight;
		private wCHandle<InventoryItemDisplayController> _currentItemView;
		private CBool _empty;
		private InventoryItemData _itemData;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CString _slotName;
		private CInt32 _slotIndex;
		private CBool _disableSlot;
		private Vector2 _smallSize;
		private Vector2 _bigSize;

		[Ordinal(1)] 
		[RED("EquipSlotRef")] 
		public inkWidgetReference EquipSlotRef
		{
			get
			{
				if (_equipSlotRef == null)
				{
					_equipSlotRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "EquipSlotRef", cr2w, this);
				}
				return _equipSlotRef;
			}
			set
			{
				if (_equipSlotRef == value)
				{
					return;
				}
				_equipSlotRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("EmptySlotButtonRef")] 
		public inkWidgetReference EmptySlotButtonRef
		{
			get
			{
				if (_emptySlotButtonRef == null)
				{
					_emptySlotButtonRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "EmptySlotButtonRef", cr2w, this);
				}
				return _emptySlotButtonRef;
			}
			set
			{
				if (_emptySlotButtonRef == value)
				{
					return;
				}
				_emptySlotButtonRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("BackgroundShape")] 
		public inkImageWidgetReference BackgroundShape
		{
			get
			{
				if (_backgroundShape == null)
				{
					_backgroundShape = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "BackgroundShape", cr2w, this);
				}
				return _backgroundShape;
			}
			set
			{
				if (_backgroundShape == value)
				{
					return;
				}
				_backgroundShape = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("BackgroundHighlight")] 
		public inkImageWidgetReference BackgroundHighlight
		{
			get
			{
				if (_backgroundHighlight == null)
				{
					_backgroundHighlight = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "BackgroundHighlight", cr2w, this);
				}
				return _backgroundHighlight;
			}
			set
			{
				if (_backgroundHighlight == value)
				{
					return;
				}
				_backgroundHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("BackgroundFrame")] 
		public inkImageWidgetReference BackgroundFrame
		{
			get
			{
				if (_backgroundFrame == null)
				{
					_backgroundFrame = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "BackgroundFrame", cr2w, this);
				}
				return _backgroundFrame;
			}
			set
			{
				if (_backgroundFrame == value)
				{
					return;
				}
				_backgroundFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("unavailableIcon")] 
		public inkWidgetReference UnavailableIcon
		{
			get
			{
				if (_unavailableIcon == null)
				{
					_unavailableIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "unavailableIcon", cr2w, this);
				}
				return _unavailableIcon;
			}
			set
			{
				if (_unavailableIcon == value)
				{
					return;
				}
				_unavailableIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("toggleHighlight")] 
		public inkImageWidgetReference ToggleHighlight
		{
			get
			{
				if (_toggleHighlight == null)
				{
					_toggleHighlight = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "toggleHighlight", cr2w, this);
				}
				return _toggleHighlight;
			}
			set
			{
				if (_toggleHighlight == value)
				{
					return;
				}
				_toggleHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("CurrentItemView")] 
		public wCHandle<InventoryItemDisplayController> CurrentItemView
		{
			get
			{
				if (_currentItemView == null)
				{
					_currentItemView = (wCHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("whandle:InventoryItemDisplayController", "CurrentItemView", cr2w, this);
				}
				return _currentItemView;
			}
			set
			{
				if (_currentItemView == value)
				{
					return;
				}
				_currentItemView = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Empty")] 
		public CBool Empty
		{
			get
			{
				if (_empty == null)
				{
					_empty = (CBool) CR2WTypeManager.Create("Bool", "Empty", cr2w, this);
				}
				return _empty;
			}
			set
			{
				if (_empty == value)
				{
					return;
				}
				_empty = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "itemData", cr2w, this);
				}
				return _itemData;
			}
			set
			{
				if (_itemData == value)
				{
					return;
				}
				_itemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get
			{
				if (_equipmentArea == null)
				{
					_equipmentArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipmentArea", cr2w, this);
				}
				return _equipmentArea;
			}
			set
			{
				if (_equipmentArea == value)
				{
					return;
				}
				_equipmentArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CString) CR2WTypeManager.Create("String", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get
			{
				if (_slotIndex == null)
				{
					_slotIndex = (CInt32) CR2WTypeManager.Create("Int32", "slotIndex", cr2w, this);
				}
				return _slotIndex;
			}
			set
			{
				if (_slotIndex == value)
				{
					return;
				}
				_slotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("DisableSlot")] 
		public CBool DisableSlot
		{
			get
			{
				if (_disableSlot == null)
				{
					_disableSlot = (CBool) CR2WTypeManager.Create("Bool", "DisableSlot", cr2w, this);
				}
				return _disableSlot;
			}
			set
			{
				if (_disableSlot == value)
				{
					return;
				}
				_disableSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("smallSize")] 
		public Vector2 SmallSize
		{
			get
			{
				if (_smallSize == null)
				{
					_smallSize = (Vector2) CR2WTypeManager.Create("Vector2", "smallSize", cr2w, this);
				}
				return _smallSize;
			}
			set
			{
				if (_smallSize == value)
				{
					return;
				}
				_smallSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("bigSize")] 
		public Vector2 BigSize
		{
			get
			{
				if (_bigSize == null)
				{
					_bigSize = (Vector2) CR2WTypeManager.Create("Vector2", "bigSize", cr2w, this);
				}
				return _bigSize;
			}
			set
			{
				if (_bigSize == value)
				{
					return;
				}
				_bigSize = value;
				PropertySet(this);
			}
		}

		public InventoryEquipmentSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

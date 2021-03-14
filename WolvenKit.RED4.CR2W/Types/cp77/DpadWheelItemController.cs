using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DpadWheelItemController : inkWidgetLogicController
	{
		private inkWidgetReference _selectorWrapper;
		private inkImageWidgetReference _icon;
		private inkWidgetReference _displayWrapper;
		private inkWidgetReference _itemWrapper;
		private inkWidgetReference _arrows;
		private inkImageWidgetReference _abilityIcon;
		private inkImageWidgetReference _quickHackIcon;
		private inkImageWidgetReference _highlight02;
		private inkImageWidgetReference _highlight03;
		private inkImageWidgetReference _highlight04;
		private inkImageWidgetReference _highlight05;
		private inkImageWidgetReference _highlight06;
		private inkImageWidgetReference _highlight07;
		private inkImageWidgetReference _highlight08;
		private CFloat _textDist;
		private CFloat _weaponTextDist;
		private QuickSlotCommand _data;
		private CHandle<inkWidget> _root;
		private CHandle<InventoryItemDisplay> _item;
		private CHandle<inkWidget> _itemWidget;
		private CHandle<InventoryDataManagerV2> _inventoryDataManager;
		private inkImageWidgetReference _highlight;
		private InventoryItemData _itemData;
		private AbilityData _abilityData;
		private CName _quickHackWheelDefIcon;

		[Ordinal(1)] 
		[RED("selectorWrapper")] 
		public inkWidgetReference SelectorWrapper
		{
			get
			{
				if (_selectorWrapper == null)
				{
					_selectorWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectorWrapper", cr2w, this);
				}
				return _selectorWrapper;
			}
			set
			{
				if (_selectorWrapper == value)
				{
					return;
				}
				_selectorWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("displayWrapper")] 
		public inkWidgetReference DisplayWrapper
		{
			get
			{
				if (_displayWrapper == null)
				{
					_displayWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "displayWrapper", cr2w, this);
				}
				return _displayWrapper;
			}
			set
			{
				if (_displayWrapper == value)
				{
					return;
				}
				_displayWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("itemWrapper")] 
		public inkWidgetReference ItemWrapper
		{
			get
			{
				if (_itemWrapper == null)
				{
					_itemWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemWrapper", cr2w, this);
				}
				return _itemWrapper;
			}
			set
			{
				if (_itemWrapper == value)
				{
					return;
				}
				_itemWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("arrows")] 
		public inkWidgetReference Arrows
		{
			get
			{
				if (_arrows == null)
				{
					_arrows = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "arrows", cr2w, this);
				}
				return _arrows;
			}
			set
			{
				if (_arrows == value)
				{
					return;
				}
				_arrows = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("abilityIcon")] 
		public inkImageWidgetReference AbilityIcon
		{
			get
			{
				if (_abilityIcon == null)
				{
					_abilityIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "abilityIcon", cr2w, this);
				}
				return _abilityIcon;
			}
			set
			{
				if (_abilityIcon == value)
				{
					return;
				}
				_abilityIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("quickHackIcon")] 
		public inkImageWidgetReference QuickHackIcon
		{
			get
			{
				if (_quickHackIcon == null)
				{
					_quickHackIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "quickHackIcon", cr2w, this);
				}
				return _quickHackIcon;
			}
			set
			{
				if (_quickHackIcon == value)
				{
					return;
				}
				_quickHackIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("highlight02")] 
		public inkImageWidgetReference Highlight02
		{
			get
			{
				if (_highlight02 == null)
				{
					_highlight02 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "highlight02", cr2w, this);
				}
				return _highlight02;
			}
			set
			{
				if (_highlight02 == value)
				{
					return;
				}
				_highlight02 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("highlight03")] 
		public inkImageWidgetReference Highlight03
		{
			get
			{
				if (_highlight03 == null)
				{
					_highlight03 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "highlight03", cr2w, this);
				}
				return _highlight03;
			}
			set
			{
				if (_highlight03 == value)
				{
					return;
				}
				_highlight03 = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("highlight04")] 
		public inkImageWidgetReference Highlight04
		{
			get
			{
				if (_highlight04 == null)
				{
					_highlight04 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "highlight04", cr2w, this);
				}
				return _highlight04;
			}
			set
			{
				if (_highlight04 == value)
				{
					return;
				}
				_highlight04 = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("highlight05")] 
		public inkImageWidgetReference Highlight05
		{
			get
			{
				if (_highlight05 == null)
				{
					_highlight05 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "highlight05", cr2w, this);
				}
				return _highlight05;
			}
			set
			{
				if (_highlight05 == value)
				{
					return;
				}
				_highlight05 = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("highlight06")] 
		public inkImageWidgetReference Highlight06
		{
			get
			{
				if (_highlight06 == null)
				{
					_highlight06 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "highlight06", cr2w, this);
				}
				return _highlight06;
			}
			set
			{
				if (_highlight06 == value)
				{
					return;
				}
				_highlight06 = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("highlight07")] 
		public inkImageWidgetReference Highlight07
		{
			get
			{
				if (_highlight07 == null)
				{
					_highlight07 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "highlight07", cr2w, this);
				}
				return _highlight07;
			}
			set
			{
				if (_highlight07 == value)
				{
					return;
				}
				_highlight07 = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("highlight08")] 
		public inkImageWidgetReference Highlight08
		{
			get
			{
				if (_highlight08 == null)
				{
					_highlight08 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "highlight08", cr2w, this);
				}
				return _highlight08;
			}
			set
			{
				if (_highlight08 == value)
				{
					return;
				}
				_highlight08 = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("textDist")] 
		public CFloat TextDist
		{
			get
			{
				if (_textDist == null)
				{
					_textDist = (CFloat) CR2WTypeManager.Create("Float", "textDist", cr2w, this);
				}
				return _textDist;
			}
			set
			{
				if (_textDist == value)
				{
					return;
				}
				_textDist = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("weaponTextDist")] 
		public CFloat WeaponTextDist
		{
			get
			{
				if (_weaponTextDist == null)
				{
					_weaponTextDist = (CFloat) CR2WTypeManager.Create("Float", "weaponTextDist", cr2w, this);
				}
				return _weaponTextDist;
			}
			set
			{
				if (_weaponTextDist == value)
				{
					return;
				}
				_weaponTextDist = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("data")] 
		public QuickSlotCommand Data
		{
			get
			{
				if (_data == null)
				{
					_data = (QuickSlotCommand) CR2WTypeManager.Create("QuickSlotCommand", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("item")] 
		public CHandle<InventoryItemDisplay> Item
		{
			get
			{
				if (_item == null)
				{
					_item = (CHandle<InventoryItemDisplay>) CR2WTypeManager.Create("handle:InventoryItemDisplay", "item", cr2w, this);
				}
				return _item;
			}
			set
			{
				if (_item == value)
				{
					return;
				}
				_item = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("itemWidget")] 
		public CHandle<inkWidget> ItemWidget
		{
			get
			{
				if (_itemWidget == null)
				{
					_itemWidget = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "itemWidget", cr2w, this);
				}
				return _itemWidget;
			}
			set
			{
				if (_itemWidget == value)
				{
					return;
				}
				_itemWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("InventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get
			{
				if (_inventoryDataManager == null)
				{
					_inventoryDataManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryDataManager", cr2w, this);
				}
				return _inventoryDataManager;
			}
			set
			{
				if (_inventoryDataManager == value)
				{
					return;
				}
				_inventoryDataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("highlight")] 
		public inkImageWidgetReference Highlight
		{
			get
			{
				if (_highlight == null)
				{
					_highlight = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "highlight", cr2w, this);
				}
				return _highlight;
			}
			set
			{
				if (_highlight == value)
				{
					return;
				}
				_highlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
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

		[Ordinal(24)] 
		[RED("abilityData")] 
		public AbilityData AbilityData
		{
			get
			{
				if (_abilityData == null)
				{
					_abilityData = (AbilityData) CR2WTypeManager.Create("AbilityData", "abilityData", cr2w, this);
				}
				return _abilityData;
			}
			set
			{
				if (_abilityData == value)
				{
					return;
				}
				_abilityData = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("quickHackWheelDefIcon")] 
		public CName QuickHackWheelDefIcon
		{
			get
			{
				if (_quickHackWheelDefIcon == null)
				{
					_quickHackWheelDefIcon = (CName) CR2WTypeManager.Create("CName", "quickHackWheelDefIcon", cr2w, this);
				}
				return _quickHackWheelDefIcon;
			}
			set
			{
				if (_quickHackWheelDefIcon == value)
				{
					return;
				}
				_quickHackWheelDefIcon = value;
				PropertySet(this);
			}
		}

		public DpadWheelItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

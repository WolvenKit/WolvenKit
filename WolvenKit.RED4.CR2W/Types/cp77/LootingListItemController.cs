using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootingListItemController : inkWidgetLogicController
	{
		private inkWidgetReference _widgetWrapper;
		private inkTextWidgetReference _itemName;
		private inkWidgetReference _itemRarity;
		private inkWidgetReference _iconicLines;
		private inkTextWidgetReference _itemQuantity;
		private inkWidgetReference _defaultIcon;
		private inkImageWidgetReference _specialIcon;
		private inkImageWidgetReference _comparisionArrow;
		private inkWidgetReference _itemTypeIconWrapper;
		private inkImageWidgetReference _itemTypeIcon;
		private CArray<inkWidgetReference> _highlightFrames;
		private CHandle<InventoryTooltipData> _tooltipData;
		private CHandle<MinimalLootingListItemData> _lootingData;

		[Ordinal(1)] 
		[RED("widgetWrapper")] 
		public inkWidgetReference WidgetWrapper
		{
			get
			{
				if (_widgetWrapper == null)
				{
					_widgetWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "widgetWrapper", cr2w, this);
				}
				return _widgetWrapper;
			}
			set
			{
				if (_widgetWrapper == value)
				{
					return;
				}
				_widgetWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get
			{
				if (_itemName == null)
				{
					_itemName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemName", cr2w, this);
				}
				return _itemName;
			}
			set
			{
				if (_itemName == value)
				{
					return;
				}
				_itemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemRarity")] 
		public inkWidgetReference ItemRarity
		{
			get
			{
				if (_itemRarity == null)
				{
					_itemRarity = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemRarity", cr2w, this);
				}
				return _itemRarity;
			}
			set
			{
				if (_itemRarity == value)
				{
					return;
				}
				_itemRarity = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("iconicLines")] 
		public inkWidgetReference IconicLines
		{
			get
			{
				if (_iconicLines == null)
				{
					_iconicLines = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "iconicLines", cr2w, this);
				}
				return _iconicLines;
			}
			set
			{
				if (_iconicLines == value)
				{
					return;
				}
				_iconicLines = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemQuantity")] 
		public inkTextWidgetReference ItemQuantity
		{
			get
			{
				if (_itemQuantity == null)
				{
					_itemQuantity = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemQuantity", cr2w, this);
				}
				return _itemQuantity;
			}
			set
			{
				if (_itemQuantity == value)
				{
					return;
				}
				_itemQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("defaultIcon")] 
		public inkWidgetReference DefaultIcon
		{
			get
			{
				if (_defaultIcon == null)
				{
					_defaultIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "defaultIcon", cr2w, this);
				}
				return _defaultIcon;
			}
			set
			{
				if (_defaultIcon == value)
				{
					return;
				}
				_defaultIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("specialIcon")] 
		public inkImageWidgetReference SpecialIcon
		{
			get
			{
				if (_specialIcon == null)
				{
					_specialIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "specialIcon", cr2w, this);
				}
				return _specialIcon;
			}
			set
			{
				if (_specialIcon == value)
				{
					return;
				}
				_specialIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("comparisionArrow")] 
		public inkImageWidgetReference ComparisionArrow
		{
			get
			{
				if (_comparisionArrow == null)
				{
					_comparisionArrow = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "comparisionArrow", cr2w, this);
				}
				return _comparisionArrow;
			}
			set
			{
				if (_comparisionArrow == value)
				{
					return;
				}
				_comparisionArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("itemTypeIconWrapper")] 
		public inkWidgetReference ItemTypeIconWrapper
		{
			get
			{
				if (_itemTypeIconWrapper == null)
				{
					_itemTypeIconWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemTypeIconWrapper", cr2w, this);
				}
				return _itemTypeIconWrapper;
			}
			set
			{
				if (_itemTypeIconWrapper == value)
				{
					return;
				}
				_itemTypeIconWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("itemTypeIcon")] 
		public inkImageWidgetReference ItemTypeIcon
		{
			get
			{
				if (_itemTypeIcon == null)
				{
					_itemTypeIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "itemTypeIcon", cr2w, this);
				}
				return _itemTypeIcon;
			}
			set
			{
				if (_itemTypeIcon == value)
				{
					return;
				}
				_itemTypeIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("highlightFrames")] 
		public CArray<inkWidgetReference> HighlightFrames
		{
			get
			{
				if (_highlightFrames == null)
				{
					_highlightFrames = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "highlightFrames", cr2w, this);
				}
				return _highlightFrames;
			}
			set
			{
				if (_highlightFrames == value)
				{
					return;
				}
				_highlightFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("tooltipData")] 
		public CHandle<InventoryTooltipData> TooltipData
		{
			get
			{
				if (_tooltipData == null)
				{
					_tooltipData = (CHandle<InventoryTooltipData>) CR2WTypeManager.Create("handle:InventoryTooltipData", "tooltipData", cr2w, this);
				}
				return _tooltipData;
			}
			set
			{
				if (_tooltipData == value)
				{
					return;
				}
				_tooltipData = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("lootingData")] 
		public CHandle<MinimalLootingListItemData> LootingData
		{
			get
			{
				if (_lootingData == null)
				{
					_lootingData = (CHandle<MinimalLootingListItemData>) CR2WTypeManager.Create("handle:MinimalLootingListItemData", "lootingData", cr2w, this);
				}
				return _lootingData;
			}
			set
			{
				if (_lootingData == value)
				{
					return;
				}
				_lootingData = value;
				PropertySet(this);
			}
		}

		public LootingListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

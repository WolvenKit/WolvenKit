using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootingItemController : inkWidgetLogicController
	{
		private CHandle<inkTextWidget> _itemNameText;
		private CBool _isCurrentlySelected;
		private inkTextWidgetReference _itemName;
		private inkTextWidgetReference _itemType;
		private inkTextWidgetReference _itemWeight;
		private inkTextWidgetReference _itemQuantity;
		private inkWidgetReference _itemQualityBar;
		private inkWidgetReference _itemSelection;
		private inkImageWidgetReference _itemIcon;

		[Ordinal(1)] 
		[RED("itemNameText")] 
		public CHandle<inkTextWidget> ItemNameText
		{
			get
			{
				if (_itemNameText == null)
				{
					_itemNameText = (CHandle<inkTextWidget>) CR2WTypeManager.Create("handle:inkTextWidget", "itemNameText", cr2w, this);
				}
				return _itemNameText;
			}
			set
			{
				if (_itemNameText == value)
				{
					return;
				}
				_itemNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isCurrentlySelected")] 
		public CBool IsCurrentlySelected
		{
			get
			{
				if (_isCurrentlySelected == null)
				{
					_isCurrentlySelected = (CBool) CR2WTypeManager.Create("Bool", "isCurrentlySelected", cr2w, this);
				}
				return _isCurrentlySelected;
			}
			set
			{
				if (_isCurrentlySelected == value)
				{
					return;
				}
				_isCurrentlySelected = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("itemType")] 
		public inkTextWidgetReference ItemType
		{
			get
			{
				if (_itemType == null)
				{
					_itemType = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemType", cr2w, this);
				}
				return _itemType;
			}
			set
			{
				if (_itemType == value)
				{
					return;
				}
				_itemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemWeight")] 
		public inkTextWidgetReference ItemWeight
		{
			get
			{
				if (_itemWeight == null)
				{
					_itemWeight = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemWeight", cr2w, this);
				}
				return _itemWeight;
			}
			set
			{
				if (_itemWeight == value)
				{
					return;
				}
				_itemWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("itemQualityBar")] 
		public inkWidgetReference ItemQualityBar
		{
			get
			{
				if (_itemQualityBar == null)
				{
					_itemQualityBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemQualityBar", cr2w, this);
				}
				return _itemQualityBar;
			}
			set
			{
				if (_itemQualityBar == value)
				{
					return;
				}
				_itemQualityBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("itemSelection")] 
		public inkWidgetReference ItemSelection
		{
			get
			{
				if (_itemSelection == null)
				{
					_itemSelection = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemSelection", cr2w, this);
				}
				return _itemSelection;
			}
			set
			{
				if (_itemSelection == value)
				{
					return;
				}
				_itemSelection = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("itemIcon")] 
		public inkImageWidgetReference ItemIcon
		{
			get
			{
				if (_itemIcon == null)
				{
					_itemIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "itemIcon", cr2w, this);
				}
				return _itemIcon;
			}
			set
			{
				if (_itemIcon == value)
				{
					return;
				}
				_itemIcon = value;
				PropertySet(this);
			}
		}

		public LootingItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

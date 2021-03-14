using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IngredientListItemLogicController : inkButtonController
	{
		private inkTextWidgetReference _itemName;
		private inkTextWidgetReference _inventoryQuantity;
		private inkTextWidgetReference _ingredientQuantity;
		private inkTextWidgetReference _availability;
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _emptyIcon;
		private CArray<inkWidgetReference> _availableBgElements;
		private CArray<inkWidgetReference> _unavailableBgElements;
		private inkWidgetReference _buyButton;
		private inkWidgetReference _countWrapper;
		private inkWidgetReference _itemRarity;
		private IngredientData _data;
		private wCHandle<inkWidget> _root;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("inventoryQuantity")] 
		public inkTextWidgetReference InventoryQuantity
		{
			get
			{
				if (_inventoryQuantity == null)
				{
					_inventoryQuantity = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "inventoryQuantity", cr2w, this);
				}
				return _inventoryQuantity;
			}
			set
			{
				if (_inventoryQuantity == value)
				{
					return;
				}
				_inventoryQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("ingredientQuantity")] 
		public inkTextWidgetReference IngredientQuantity
		{
			get
			{
				if (_ingredientQuantity == null)
				{
					_ingredientQuantity = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ingredientQuantity", cr2w, this);
				}
				return _ingredientQuantity;
			}
			set
			{
				if (_ingredientQuantity == value)
				{
					return;
				}
				_ingredientQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("availability")] 
		public inkTextWidgetReference Availability
		{
			get
			{
				if (_availability == null)
				{
					_availability = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "availability", cr2w, this);
				}
				return _availability;
			}
			set
			{
				if (_availability == value)
				{
					return;
				}
				_availability = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("emptyIcon")] 
		public inkImageWidgetReference EmptyIcon
		{
			get
			{
				if (_emptyIcon == null)
				{
					_emptyIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "emptyIcon", cr2w, this);
				}
				return _emptyIcon;
			}
			set
			{
				if (_emptyIcon == value)
				{
					return;
				}
				_emptyIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("availableBgElements")] 
		public CArray<inkWidgetReference> AvailableBgElements
		{
			get
			{
				if (_availableBgElements == null)
				{
					_availableBgElements = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "availableBgElements", cr2w, this);
				}
				return _availableBgElements;
			}
			set
			{
				if (_availableBgElements == value)
				{
					return;
				}
				_availableBgElements = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("unavailableBgElements")] 
		public CArray<inkWidgetReference> UnavailableBgElements
		{
			get
			{
				if (_unavailableBgElements == null)
				{
					_unavailableBgElements = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "unavailableBgElements", cr2w, this);
				}
				return _unavailableBgElements;
			}
			set
			{
				if (_unavailableBgElements == value)
				{
					return;
				}
				_unavailableBgElements = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("buyButton")] 
		public inkWidgetReference BuyButton
		{
			get
			{
				if (_buyButton == null)
				{
					_buyButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buyButton", cr2w, this);
				}
				return _buyButton;
			}
			set
			{
				if (_buyButton == value)
				{
					return;
				}
				_buyButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("countWrapper")] 
		public inkWidgetReference CountWrapper
		{
			get
			{
				if (_countWrapper == null)
				{
					_countWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "countWrapper", cr2w, this);
				}
				return _countWrapper;
			}
			set
			{
				if (_countWrapper == value)
				{
					return;
				}
				_countWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
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

		[Ordinal(21)] 
		[RED("data")] 
		public IngredientData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (IngredientData) CR2WTypeManager.Create("IngredientData", "data", cr2w, this);
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

		[Ordinal(22)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
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

		[Ordinal(23)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "TooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		public IngredientListItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

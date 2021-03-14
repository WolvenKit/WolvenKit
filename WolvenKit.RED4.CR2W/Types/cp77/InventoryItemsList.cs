using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemsList : inkWidgetLogicController
	{
		private CName _inventoryItemName;
		private inkCompoundWidgetReference _itemsLayoutRef;
		private CArray<CHandle<ATooltipData>> _tooltipsData;
		private wCHandle<gameObject> _itemsOwner;
		private wCHandle<inkCompoundWidget> _itemsLayout;
		private CArray<wCHandle<inkWidget>> _inventoryItems;
		private CBool _isDevice;
		private CHandle<InventoryDataManagerV2> _inventoryManager;

		[Ordinal(1)] 
		[RED("InventoryItemName")] 
		public CName InventoryItemName
		{
			get
			{
				if (_inventoryItemName == null)
				{
					_inventoryItemName = (CName) CR2WTypeManager.Create("CName", "InventoryItemName", cr2w, this);
				}
				return _inventoryItemName;
			}
			set
			{
				if (_inventoryItemName == value)
				{
					return;
				}
				_inventoryItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ItemsLayoutRef")] 
		public inkCompoundWidgetReference ItemsLayoutRef
		{
			get
			{
				if (_itemsLayoutRef == null)
				{
					_itemsLayoutRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ItemsLayoutRef", cr2w, this);
				}
				return _itemsLayoutRef;
			}
			set
			{
				if (_itemsLayoutRef == value)
				{
					return;
				}
				_itemsLayoutRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("TooltipsData")] 
		public CArray<CHandle<ATooltipData>> TooltipsData
		{
			get
			{
				if (_tooltipsData == null)
				{
					_tooltipsData = (CArray<CHandle<ATooltipData>>) CR2WTypeManager.Create("array:handle:ATooltipData", "TooltipsData", cr2w, this);
				}
				return _tooltipsData;
			}
			set
			{
				if (_tooltipsData == value)
				{
					return;
				}
				_tooltipsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ItemsOwner")] 
		public wCHandle<gameObject> ItemsOwner
		{
			get
			{
				if (_itemsOwner == null)
				{
					_itemsOwner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "ItemsOwner", cr2w, this);
				}
				return _itemsOwner;
			}
			set
			{
				if (_itemsOwner == value)
				{
					return;
				}
				_itemsOwner = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ItemsLayout")] 
		public wCHandle<inkCompoundWidget> ItemsLayout
		{
			get
			{
				if (_itemsLayout == null)
				{
					_itemsLayout = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "ItemsLayout", cr2w, this);
				}
				return _itemsLayout;
			}
			set
			{
				if (_itemsLayout == value)
				{
					return;
				}
				_itemsLayout = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("InventoryItems")] 
		public CArray<wCHandle<inkWidget>> InventoryItems
		{
			get
			{
				if (_inventoryItems == null)
				{
					_inventoryItems = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "InventoryItems", cr2w, this);
				}
				return _inventoryItems;
			}
			set
			{
				if (_inventoryItems == value)
				{
					return;
				}
				_inventoryItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("IsDevice")] 
		public CBool IsDevice
		{
			get
			{
				if (_isDevice == null)
				{
					_isDevice = (CBool) CR2WTypeManager.Create("Bool", "IsDevice", cr2w, this);
				}
				return _isDevice;
			}
			set
			{
				if (_isDevice == value)
				{
					return;
				}
				_isDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		public InventoryItemsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

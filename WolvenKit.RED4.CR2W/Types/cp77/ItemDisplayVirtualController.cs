using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayVirtualController : inkVirtualCompoundItemController
	{
		private inkWidgetReference _itemDisplayWidget;
		private CName _widgetToSpawn;
		private CHandle<WrappedInventoryItemData> _wrappedData;
		private InventoryItemData _data;
		private wCHandle<inkWidget> _spawnedWidget;

		[Ordinal(15)] 
		[RED("itemDisplayWidget")] 
		public inkWidgetReference ItemDisplayWidget
		{
			get
			{
				if (_itemDisplayWidget == null)
				{
					_itemDisplayWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemDisplayWidget", cr2w, this);
				}
				return _itemDisplayWidget;
			}
			set
			{
				if (_itemDisplayWidget == value)
				{
					return;
				}
				_itemDisplayWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("widgetToSpawn")] 
		public CName WidgetToSpawn
		{
			get
			{
				if (_widgetToSpawn == null)
				{
					_widgetToSpawn = (CName) CR2WTypeManager.Create("CName", "widgetToSpawn", cr2w, this);
				}
				return _widgetToSpawn;
			}
			set
			{
				if (_widgetToSpawn == value)
				{
					return;
				}
				_widgetToSpawn = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("wrappedData")] 
		public CHandle<WrappedInventoryItemData> WrappedData
		{
			get
			{
				if (_wrappedData == null)
				{
					_wrappedData = (CHandle<WrappedInventoryItemData>) CR2WTypeManager.Create("handle:WrappedInventoryItemData", "wrappedData", cr2w, this);
				}
				return _wrappedData;
			}
			set
			{
				if (_wrappedData == value)
				{
					return;
				}
				_wrappedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("data")] 
		public InventoryItemData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "data", cr2w, this);
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

		[Ordinal(19)] 
		[RED("spawnedWidget")] 
		public wCHandle<inkWidget> SpawnedWidget
		{
			get
			{
				if (_spawnedWidget == null)
				{
					_spawnedWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "spawnedWidget", cr2w, this);
				}
				return _spawnedWidget;
			}
			set
			{
				if (_spawnedWidget == value)
				{
					return;
				}
				_spawnedWidget = value;
				PropertySet(this);
			}
		}

		public ItemDisplayVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

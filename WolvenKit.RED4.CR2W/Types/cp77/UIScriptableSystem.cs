using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystem : gameScriptableSystem
	{
		private CInt32 _backpackActiveSorting;
		private CInt32 _backpackActiveFilter;
		private CBool _isBackpackActiveFilterSaved;
		private CInt32 _vendorPanelPlayerActiveSorting;
		private CInt32 _vendorPanelVendorActiveSorting;
		private CArray<gameItemID> _newItems;
		private wCHandle<PlayerPuppet> _attachedPlayer;
		private CHandle<UIScriptableInventoryListenerCallback> _inventoryListenerCallback;
		private CHandle<gameInventoryScriptListener> _inventoryListener;

		[Ordinal(0)] 
		[RED("backpackActiveSorting")] 
		public CInt32 BackpackActiveSorting
		{
			get
			{
				if (_backpackActiveSorting == null)
				{
					_backpackActiveSorting = (CInt32) CR2WTypeManager.Create("Int32", "backpackActiveSorting", cr2w, this);
				}
				return _backpackActiveSorting;
			}
			set
			{
				if (_backpackActiveSorting == value)
				{
					return;
				}
				_backpackActiveSorting = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("backpackActiveFilter")] 
		public CInt32 BackpackActiveFilter
		{
			get
			{
				if (_backpackActiveFilter == null)
				{
					_backpackActiveFilter = (CInt32) CR2WTypeManager.Create("Int32", "backpackActiveFilter", cr2w, this);
				}
				return _backpackActiveFilter;
			}
			set
			{
				if (_backpackActiveFilter == value)
				{
					return;
				}
				_backpackActiveFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isBackpackActiveFilterSaved")] 
		public CBool IsBackpackActiveFilterSaved
		{
			get
			{
				if (_isBackpackActiveFilterSaved == null)
				{
					_isBackpackActiveFilterSaved = (CBool) CR2WTypeManager.Create("Bool", "isBackpackActiveFilterSaved", cr2w, this);
				}
				return _isBackpackActiveFilterSaved;
			}
			set
			{
				if (_isBackpackActiveFilterSaved == value)
				{
					return;
				}
				_isBackpackActiveFilterSaved = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("vendorPanelPlayerActiveSorting")] 
		public CInt32 VendorPanelPlayerActiveSorting
		{
			get
			{
				if (_vendorPanelPlayerActiveSorting == null)
				{
					_vendorPanelPlayerActiveSorting = (CInt32) CR2WTypeManager.Create("Int32", "vendorPanelPlayerActiveSorting", cr2w, this);
				}
				return _vendorPanelPlayerActiveSorting;
			}
			set
			{
				if (_vendorPanelPlayerActiveSorting == value)
				{
					return;
				}
				_vendorPanelPlayerActiveSorting = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("vendorPanelVendorActiveSorting")] 
		public CInt32 VendorPanelVendorActiveSorting
		{
			get
			{
				if (_vendorPanelVendorActiveSorting == null)
				{
					_vendorPanelVendorActiveSorting = (CInt32) CR2WTypeManager.Create("Int32", "vendorPanelVendorActiveSorting", cr2w, this);
				}
				return _vendorPanelVendorActiveSorting;
			}
			set
			{
				if (_vendorPanelVendorActiveSorting == value)
				{
					return;
				}
				_vendorPanelVendorActiveSorting = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("newItems")] 
		public CArray<gameItemID> NewItems
		{
			get
			{
				if (_newItems == null)
				{
					_newItems = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "newItems", cr2w, this);
				}
				return _newItems;
			}
			set
			{
				if (_newItems == value)
				{
					return;
				}
				_newItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("attachedPlayer")] 
		public wCHandle<PlayerPuppet> AttachedPlayer
		{
			get
			{
				if (_attachedPlayer == null)
				{
					_attachedPlayer = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "attachedPlayer", cr2w, this);
				}
				return _attachedPlayer;
			}
			set
			{
				if (_attachedPlayer == value)
				{
					return;
				}
				_attachedPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("inventoryListenerCallback")] 
		public CHandle<UIScriptableInventoryListenerCallback> InventoryListenerCallback
		{
			get
			{
				if (_inventoryListenerCallback == null)
				{
					_inventoryListenerCallback = (CHandle<UIScriptableInventoryListenerCallback>) CR2WTypeManager.Create("handle:UIScriptableInventoryListenerCallback", "inventoryListenerCallback", cr2w, this);
				}
				return _inventoryListenerCallback;
			}
			set
			{
				if (_inventoryListenerCallback == value)
				{
					return;
				}
				_inventoryListenerCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get
			{
				if (_inventoryListener == null)
				{
					_inventoryListener = (CHandle<gameInventoryScriptListener>) CR2WTypeManager.Create("handle:gameInventoryScriptListener", "inventoryListener", cr2w, this);
				}
				return _inventoryListener;
			}
			set
			{
				if (_inventoryListener == value)
				{
					return;
				}
				_inventoryListener = value;
				PropertySet(this);
			}
		}

		public UIScriptableSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemLog : gameuiMenuGameController
	{
		private inkCompoundWidgetReference _listRef;
		private CFloat _initialPopupDelay;
		private CArray<CHandle<DisassemblePopupLogicController>> _popupList;
		private CArray<InventoryItemData> _listOfAddedInventoryItems;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private CHandle<ItemLogUserData> _data;
		private CInt32 _onScreenCount;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private inkanimPlaybackOptions _animOptions;

		[Ordinal(3)] 
		[RED("listRef")] 
		public inkCompoundWidgetReference ListRef
		{
			get
			{
				if (_listRef == null)
				{
					_listRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "listRef", cr2w, this);
				}
				return _listRef;
			}
			set
			{
				if (_listRef == value)
				{
					return;
				}
				_listRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("initialPopupDelay")] 
		public CFloat InitialPopupDelay
		{
			get
			{
				if (_initialPopupDelay == null)
				{
					_initialPopupDelay = (CFloat) CR2WTypeManager.Create("Float", "initialPopupDelay", cr2w, this);
				}
				return _initialPopupDelay;
			}
			set
			{
				if (_initialPopupDelay == value)
				{
					return;
				}
				_initialPopupDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("popupList")] 
		public CArray<CHandle<DisassemblePopupLogicController>> PopupList
		{
			get
			{
				if (_popupList == null)
				{
					_popupList = (CArray<CHandle<DisassemblePopupLogicController>>) CR2WTypeManager.Create("array:handle:DisassemblePopupLogicController", "popupList", cr2w, this);
				}
				return _popupList;
			}
			set
			{
				if (_popupList == value)
				{
					return;
				}
				_popupList = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("listOfAddedInventoryItems")] 
		public CArray<InventoryItemData> ListOfAddedInventoryItems
		{
			get
			{
				if (_listOfAddedInventoryItems == null)
				{
					_listOfAddedInventoryItems = (CArray<InventoryItemData>) CR2WTypeManager.Create("array:InventoryItemData", "listOfAddedInventoryItems", cr2w, this);
				}
				return _listOfAddedInventoryItems;
			}
			set
			{
				if (_listOfAddedInventoryItems == value)
				{
					return;
				}
				_listOfAddedInventoryItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
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

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<ItemLogUserData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<ItemLogUserData>) CR2WTypeManager.Create("handle:ItemLogUserData", "data", cr2w, this);
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

		[Ordinal(10)] 
		[RED("onScreenCount")] 
		public CInt32 OnScreenCount
		{
			get
			{
				if (_onScreenCount == null)
				{
					_onScreenCount = (CInt32) CR2WTypeManager.Create("Int32", "onScreenCount", cr2w, this);
				}
				return _onScreenCount;
			}
			set
			{
				if (_onScreenCount == value)
				{
					return;
				}
				_onScreenCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get
			{
				if (_alpha_fadein == null)
				{
					_alpha_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "alpha_fadein", cr2w, this);
				}
				return _alpha_fadein;
			}
			set
			{
				if (_alpha_fadein == value)
				{
					return;
				}
				_alpha_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get
			{
				if (_animOptions == null)
				{
					_animOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "AnimOptions", cr2w, this);
				}
				return _animOptions;
			}
			set
			{
				if (_animOptions == value)
				{
					return;
				}
				_animOptions = value;
				PropertySet(this);
			}
		}

		public ItemLog(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

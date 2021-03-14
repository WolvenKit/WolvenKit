using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisassembleManager : gameuiMenuGameController
	{
		private inkCompoundWidgetReference _listRef;
		private CFloat _initialPopupDelay;
		private CArray<CHandle<DisassemblePopupLogicController>> _popupList;
		private CArray<InventoryItemData> _listOfAddedInventoryItems;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private CHandle<gameTransactionSystem> _transactionSystem;
		private CHandle<inkWidget> _root;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private inkanimPlaybackOptions _animOptions;
		private CHandle<UI_CraftingDef> _disassembleCallback;
		private CHandle<gameIBlackboard> _disassembleBlackboard;
		private CUInt32 _disassembleBBID;
		private CUInt32 _craftingBBID;

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
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get
			{
				if (_transactionSystem == null)
				{
					_transactionSystem = (CHandle<gameTransactionSystem>) CR2WTypeManager.Create("handle:gameTransactionSystem", "transactionSystem", cr2w, this);
				}
				return _transactionSystem;
			}
			set
			{
				if (_transactionSystem == value)
				{
					return;
				}
				_transactionSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		[Ordinal(14)] 
		[RED("DisassembleCallback")] 
		public CHandle<UI_CraftingDef> DisassembleCallback
		{
			get
			{
				if (_disassembleCallback == null)
				{
					_disassembleCallback = (CHandle<UI_CraftingDef>) CR2WTypeManager.Create("handle:UI_CraftingDef", "DisassembleCallback", cr2w, this);
				}
				return _disassembleCallback;
			}
			set
			{
				if (_disassembleCallback == value)
				{
					return;
				}
				_disassembleCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("DisassembleBlackboard")] 
		public CHandle<gameIBlackboard> DisassembleBlackboard
		{
			get
			{
				if (_disassembleBlackboard == null)
				{
					_disassembleBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "DisassembleBlackboard", cr2w, this);
				}
				return _disassembleBlackboard;
			}
			set
			{
				if (_disassembleBlackboard == value)
				{
					return;
				}
				_disassembleBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("DisassembleBBID")] 
		public CUInt32 DisassembleBBID
		{
			get
			{
				if (_disassembleBBID == null)
				{
					_disassembleBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "DisassembleBBID", cr2w, this);
				}
				return _disassembleBBID;
			}
			set
			{
				if (_disassembleBBID == value)
				{
					return;
				}
				_disassembleBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("CraftingBBID")] 
		public CUInt32 CraftingBBID
		{
			get
			{
				if (_craftingBBID == null)
				{
					_craftingBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "CraftingBBID", cr2w, this);
				}
				return _craftingBBID;
			}
			set
			{
				if (_craftingBBID == value)
				{
					return;
				}
				_craftingBBID = value;
				PropertySet(this);
			}
		}

		public DisassembleManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

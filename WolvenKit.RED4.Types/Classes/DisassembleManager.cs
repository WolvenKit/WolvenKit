using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisassembleManager : gameuiMenuGameController
	{
		private inkCompoundWidgetReference _listRef;
		private CFloat _initialPopupDelay;
		private CArray<CWeakHandle<DisassemblePopupLogicController>> _popupList;
		private CArray<InventoryItemData> _listOfAddedInventoryItems;
		private CWeakHandle<PlayerPuppet> _player;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private CHandle<gameTransactionSystem> _transactionSystem;
		private CWeakHandle<inkWidget> _root;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private inkanimPlaybackOptions _animOptions;
		private CHandle<UI_CraftingDef> _disassembleCallback;
		private CWeakHandle<gameIBlackboard> _disassembleBlackboard;
		private CHandle<redCallbackObject> _disassembleBBID;
		private CHandle<redCallbackObject> _craftingBBID;

		[Ordinal(3)] 
		[RED("listRef")] 
		public inkCompoundWidgetReference ListRef
		{
			get => GetProperty(ref _listRef);
			set => SetProperty(ref _listRef, value);
		}

		[Ordinal(4)] 
		[RED("initialPopupDelay")] 
		public CFloat InitialPopupDelay
		{
			get => GetProperty(ref _initialPopupDelay);
			set => SetProperty(ref _initialPopupDelay, value);
		}

		[Ordinal(5)] 
		[RED("popupList")] 
		public CArray<CWeakHandle<DisassemblePopupLogicController>> PopupList
		{
			get => GetProperty(ref _popupList);
			set => SetProperty(ref _popupList, value);
		}

		[Ordinal(6)] 
		[RED("listOfAddedInventoryItems")] 
		public CArray<InventoryItemData> ListOfAddedInventoryItems
		{
			get => GetProperty(ref _listOfAddedInventoryItems);
			set => SetProperty(ref _listOfAddedInventoryItems, value);
		}

		[Ordinal(7)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(8)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(9)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(10)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(11)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(12)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetProperty(ref _alpha_fadein);
			set => SetProperty(ref _alpha_fadein, value);
		}

		[Ordinal(13)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(14)] 
		[RED("DisassembleCallback")] 
		public CHandle<UI_CraftingDef> DisassembleCallback
		{
			get => GetProperty(ref _disassembleCallback);
			set => SetProperty(ref _disassembleCallback, value);
		}

		[Ordinal(15)] 
		[RED("DisassembleBlackboard")] 
		public CWeakHandle<gameIBlackboard> DisassembleBlackboard
		{
			get => GetProperty(ref _disassembleBlackboard);
			set => SetProperty(ref _disassembleBlackboard, value);
		}

		[Ordinal(16)] 
		[RED("DisassembleBBID")] 
		public CHandle<redCallbackObject> DisassembleBBID
		{
			get => GetProperty(ref _disassembleBBID);
			set => SetProperty(ref _disassembleBBID, value);
		}

		[Ordinal(17)] 
		[RED("CraftingBBID")] 
		public CHandle<redCallbackObject> CraftingBBID
		{
			get => GetProperty(ref _craftingBBID);
			set => SetProperty(ref _craftingBBID, value);
		}

		public DisassembleManager()
		{
			_initialPopupDelay = 1.000000F;
		}
	}
}

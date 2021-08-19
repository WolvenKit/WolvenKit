using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardsMenuGameController : gameuiMenuGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkCompoundWidgetReference _entryViewRef;
		private inkWidgetReference _virtualList;
		private inkWidgetReference _emptyPlaceholderRef;
		private inkWidgetReference _leftBlockControllerRef;
		private inkWidgetReference _crackHint;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<CodexEntryViewController> _entryViewController;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<ShardsVirtualNestedListController> _listController;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<CodexListSyncData> _activeData;
		private CBool _hasNewCryptedEntries;
		private CBool _isEncryptedEntrySelected;
		private CHandle<ShardEntryData> _selectedData;
		private wCHandle<gameIBlackboard> _mingameBB;
		private CInt32 _userDataEntry;
		private CBool _doubleInputPreventionFlag;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(3)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("entryViewRef")] 
		public inkCompoundWidgetReference EntryViewRef
		{
			get => GetProperty(ref _entryViewRef);
			set => SetProperty(ref _entryViewRef, value);
		}

		[Ordinal(5)] 
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get => GetProperty(ref _virtualList);
			set => SetProperty(ref _virtualList, value);
		}

		[Ordinal(6)] 
		[RED("emptyPlaceholderRef")] 
		public inkWidgetReference EmptyPlaceholderRef
		{
			get => GetProperty(ref _emptyPlaceholderRef);
			set => SetProperty(ref _emptyPlaceholderRef, value);
		}

		[Ordinal(7)] 
		[RED("leftBlockControllerRef")] 
		public inkWidgetReference LeftBlockControllerRef
		{
			get => GetProperty(ref _leftBlockControllerRef);
			set => SetProperty(ref _leftBlockControllerRef, value);
		}

		[Ordinal(8)] 
		[RED("crackHint")] 
		public inkWidgetReference CrackHint
		{
			get => GetProperty(ref _crackHint);
			set => SetProperty(ref _crackHint, value);
		}

		[Ordinal(9)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(10)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(11)] 
		[RED("entryViewController")] 
		public wCHandle<CodexEntryViewController> EntryViewController
		{
			get => GetProperty(ref _entryViewController);
			set => SetProperty(ref _entryViewController, value);
		}

		[Ordinal(12)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(13)] 
		[RED("listController")] 
		public wCHandle<ShardsVirtualNestedListController> ListController
		{
			get => GetProperty(ref _listController);
			set => SetProperty(ref _listController, value);
		}

		[Ordinal(14)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(16)] 
		[RED("activeData")] 
		public CHandle<CodexListSyncData> ActiveData
		{
			get => GetProperty(ref _activeData);
			set => SetProperty(ref _activeData, value);
		}

		[Ordinal(17)] 
		[RED("hasNewCryptedEntries")] 
		public CBool HasNewCryptedEntries
		{
			get => GetProperty(ref _hasNewCryptedEntries);
			set => SetProperty(ref _hasNewCryptedEntries, value);
		}

		[Ordinal(18)] 
		[RED("isEncryptedEntrySelected")] 
		public CBool IsEncryptedEntrySelected
		{
			get => GetProperty(ref _isEncryptedEntrySelected);
			set => SetProperty(ref _isEncryptedEntrySelected, value);
		}

		[Ordinal(19)] 
		[RED("selectedData")] 
		public CHandle<ShardEntryData> SelectedData
		{
			get => GetProperty(ref _selectedData);
			set => SetProperty(ref _selectedData, value);
		}

		[Ordinal(20)] 
		[RED("mingameBB")] 
		public wCHandle<gameIBlackboard> MingameBB
		{
			get => GetProperty(ref _mingameBB);
			set => SetProperty(ref _mingameBB, value);
		}

		[Ordinal(21)] 
		[RED("userDataEntry")] 
		public CInt32 UserDataEntry
		{
			get => GetProperty(ref _userDataEntry);
			set => SetProperty(ref _userDataEntry, value);
		}

		[Ordinal(22)] 
		[RED("doubleInputPreventionFlag")] 
		public CBool DoubleInputPreventionFlag
		{
			get => GetProperty(ref _doubleInputPreventionFlag);
			set => SetProperty(ref _doubleInputPreventionFlag, value);
		}

		[Ordinal(23)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		public ShardsMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

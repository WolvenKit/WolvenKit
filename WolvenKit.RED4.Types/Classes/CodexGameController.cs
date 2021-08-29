using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexGameController : gameuiMenuGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkCompoundWidgetReference _entryViewRef;
		private inkCompoundWidgetReference _characterEntryViewRef;
		private inkWidgetReference _noEntrySelectedWidget;
		private inkWidgetReference _virtualList;
		private inkWidgetReference _emptyPlaceholderRef;
		private inkWidgetReference _leftBlockControllerRef;
		private inkCompoundWidgetReference _filtersContainer;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CWeakHandle<ButtonHints> _buttonHintsController;
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CWeakHandle<CodexListVirtualNestedListController> _listController;
		private CWeakHandle<CodexEntryViewController> _entryViewController;
		private CWeakHandle<CodexEntryViewController> _characterEntryViewController;
		private CWeakHandle<PlayerPuppet> _player;
		private CHandle<CodexListSyncData> _activeData;
		private CHandle<CodexEntryData> _selectedData;
		private CInt32 _userDataEntry;
		private CBool _doubleInputPreventionFlag;
		private CArray<CWeakHandle<CodexFilterButtonController>> _filtersControllers;

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
		[RED("characterEntryViewRef")] 
		public inkCompoundWidgetReference CharacterEntryViewRef
		{
			get => GetProperty(ref _characterEntryViewRef);
			set => SetProperty(ref _characterEntryViewRef, value);
		}

		[Ordinal(6)] 
		[RED("noEntrySelectedWidget")] 
		public inkWidgetReference NoEntrySelectedWidget
		{
			get => GetProperty(ref _noEntrySelectedWidget);
			set => SetProperty(ref _noEntrySelectedWidget, value);
		}

		[Ordinal(7)] 
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get => GetProperty(ref _virtualList);
			set => SetProperty(ref _virtualList, value);
		}

		[Ordinal(8)] 
		[RED("emptyPlaceholderRef")] 
		public inkWidgetReference EmptyPlaceholderRef
		{
			get => GetProperty(ref _emptyPlaceholderRef);
			set => SetProperty(ref _emptyPlaceholderRef, value);
		}

		[Ordinal(9)] 
		[RED("leftBlockControllerRef")] 
		public inkWidgetReference LeftBlockControllerRef
		{
			get => GetProperty(ref _leftBlockControllerRef);
			set => SetProperty(ref _leftBlockControllerRef, value);
		}

		[Ordinal(10)] 
		[RED("filtersContainer")] 
		public inkCompoundWidgetReference FiltersContainer
		{
			get => GetProperty(ref _filtersContainer);
			set => SetProperty(ref _filtersContainer, value);
		}

		[Ordinal(11)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(13)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(14)] 
		[RED("listController")] 
		public CWeakHandle<CodexListVirtualNestedListController> ListController
		{
			get => GetProperty(ref _listController);
			set => SetProperty(ref _listController, value);
		}

		[Ordinal(15)] 
		[RED("entryViewController")] 
		public CWeakHandle<CodexEntryViewController> EntryViewController
		{
			get => GetProperty(ref _entryViewController);
			set => SetProperty(ref _entryViewController, value);
		}

		[Ordinal(16)] 
		[RED("characterEntryViewController")] 
		public CWeakHandle<CodexEntryViewController> CharacterEntryViewController
		{
			get => GetProperty(ref _characterEntryViewController);
			set => SetProperty(ref _characterEntryViewController, value);
		}

		[Ordinal(17)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(18)] 
		[RED("activeData")] 
		public CHandle<CodexListSyncData> ActiveData
		{
			get => GetProperty(ref _activeData);
			set => SetProperty(ref _activeData, value);
		}

		[Ordinal(19)] 
		[RED("selectedData")] 
		public CHandle<CodexEntryData> SelectedData
		{
			get => GetProperty(ref _selectedData);
			set => SetProperty(ref _selectedData, value);
		}

		[Ordinal(20)] 
		[RED("userDataEntry")] 
		public CInt32 UserDataEntry
		{
			get => GetProperty(ref _userDataEntry);
			set => SetProperty(ref _userDataEntry, value);
		}

		[Ordinal(21)] 
		[RED("doubleInputPreventionFlag")] 
		public CBool DoubleInputPreventionFlag
		{
			get => GetProperty(ref _doubleInputPreventionFlag);
			set => SetProperty(ref _doubleInputPreventionFlag, value);
		}

		[Ordinal(22)] 
		[RED("filtersControllers")] 
		public CArray<CWeakHandle<CodexFilterButtonController>> FiltersControllers
		{
			get => GetProperty(ref _filtersControllers);
			set => SetProperty(ref _filtersControllers, value);
		}
	}
}

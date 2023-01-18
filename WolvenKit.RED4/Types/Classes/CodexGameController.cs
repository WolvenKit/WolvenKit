using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("entryViewRef")] 
		public inkCompoundWidgetReference EntryViewRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("characterEntryViewRef")] 
		public inkCompoundWidgetReference CharacterEntryViewRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("noEntrySelectedWidget")] 
		public inkWidgetReference NoEntrySelectedWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("emptyPlaceholderRef")] 
		public inkWidgetReference EmptyPlaceholderRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("leftBlockControllerRef")] 
		public inkWidgetReference LeftBlockControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("filtersContainer")] 
		public inkCompoundWidgetReference FiltersContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(13)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(14)] 
		[RED("listController")] 
		public CWeakHandle<CodexListVirtualNestedListController> ListController
		{
			get => GetPropertyValue<CWeakHandle<CodexListVirtualNestedListController>>();
			set => SetPropertyValue<CWeakHandle<CodexListVirtualNestedListController>>(value);
		}

		[Ordinal(15)] 
		[RED("entryViewController")] 
		public CWeakHandle<CodexEntryViewController> EntryViewController
		{
			get => GetPropertyValue<CWeakHandle<CodexEntryViewController>>();
			set => SetPropertyValue<CWeakHandle<CodexEntryViewController>>(value);
		}

		[Ordinal(16)] 
		[RED("characterEntryViewController")] 
		public CWeakHandle<CodexEntryViewController> CharacterEntryViewController
		{
			get => GetPropertyValue<CWeakHandle<CodexEntryViewController>>();
			set => SetPropertyValue<CWeakHandle<CodexEntryViewController>>(value);
		}

		[Ordinal(17)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(18)] 
		[RED("activeData")] 
		public CHandle<CodexListSyncData> ActiveData
		{
			get => GetPropertyValue<CHandle<CodexListSyncData>>();
			set => SetPropertyValue<CHandle<CodexListSyncData>>(value);
		}

		[Ordinal(19)] 
		[RED("selectedData")] 
		public CHandle<CodexEntryData> SelectedData
		{
			get => GetPropertyValue<CHandle<CodexEntryData>>();
			set => SetPropertyValue<CHandle<CodexEntryData>>(value);
		}

		[Ordinal(20)] 
		[RED("userDataEntry")] 
		public CInt32 UserDataEntry
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("doubleInputPreventionFlag")] 
		public CBool DoubleInputPreventionFlag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("filtersControllers")] 
		public CArray<CWeakHandle<CodexFilterButtonController>> FiltersControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<CodexFilterButtonController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<CodexFilterButtonController>>>(value);
		}

		public CodexGameController()
		{
			ButtonHintsManagerRef = new();
			EntryViewRef = new();
			CharacterEntryViewRef = new();
			NoEntrySelectedWidget = new();
			VirtualList = new();
			EmptyPlaceholderRef = new();
			LeftBlockControllerRef = new();
			FiltersContainer = new();
			FiltersControllers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

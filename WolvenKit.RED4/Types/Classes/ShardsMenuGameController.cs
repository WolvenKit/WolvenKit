using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardsMenuGameController : gameuiMenuGameController
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
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("emptyPlaceholderRef")] 
		public inkWidgetReference EmptyPlaceholderRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("rightViewPlaceholderRef")] 
		public inkWidgetReference RightViewPlaceholderRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("leftBlockControllerRef")] 
		public inkWidgetReference LeftBlockControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("crackHint")] 
		public inkWidgetReference CrackHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(11)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(12)] 
		[RED("entryViewController")] 
		public CWeakHandle<CodexEntryViewController> EntryViewController
		{
			get => GetPropertyValue<CWeakHandle<CodexEntryViewController>>();
			set => SetPropertyValue<CWeakHandle<CodexEntryViewController>>(value);
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
		public CWeakHandle<ShardsVirtualNestedListController> ListController
		{
			get => GetPropertyValue<CWeakHandle<ShardsVirtualNestedListController>>();
			set => SetPropertyValue<CWeakHandle<ShardsVirtualNestedListController>>(value);
		}

		[Ordinal(15)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(16)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(17)] 
		[RED("activeData")] 
		public CHandle<CodexListSyncData> ActiveData
		{
			get => GetPropertyValue<CHandle<CodexListSyncData>>();
			set => SetPropertyValue<CHandle<CodexListSyncData>>(value);
		}

		[Ordinal(18)] 
		[RED("hasNewCryptedEntries")] 
		public CBool HasNewCryptedEntries
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("isEncryptedEntrySelected")] 
		public CBool IsEncryptedEntrySelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("selectedData")] 
		public CHandle<ShardEntryData> SelectedData
		{
			get => GetPropertyValue<CHandle<ShardEntryData>>();
			set => SetPropertyValue<CHandle<ShardEntryData>>(value);
		}

		[Ordinal(21)] 
		[RED("mingameBB")] 
		public CWeakHandle<gameIBlackboard> MingameBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(22)] 
		[RED("userDataEntry")] 
		public CInt32 UserDataEntry
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("doubleInputPreventionFlag")] 
		public CBool DoubleInputPreventionFlag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public ShardsMenuGameController()
		{
			ButtonHintsManagerRef = new inkWidgetReference();
			EntryViewRef = new inkCompoundWidgetReference();
			VirtualList = new inkWidgetReference();
			EmptyPlaceholderRef = new inkWidgetReference();
			RightViewPlaceholderRef = new inkWidgetReference();
			LeftBlockControllerRef = new inkWidgetReference();
			CrackHint = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractionUIBase : gameuiHUDGameController
	{
		private CWeakHandle<gameIBlackboard> _interactionsBlackboard;
		private CHandle<UIInteractionsDef> _interactionsBBDefinition;
		private CHandle<redCallbackObject> _dialogsDataListenerId;
		private CHandle<redCallbackObject> _dialogsActiveHubListenerId;
		private CHandle<redCallbackObject> _dialogsSelectedChoiceListenerId;
		private CHandle<redCallbackObject> _interactionsDataListenerId;
		private CHandle<redCallbackObject> _lootingDataListenerId;
		private CBool _areDialogsOpen;
		private CBool _areContactsOpen;
		private CBool _isLootingOpen;
		private CBool _areInteractionsOpen;
		private CBool _interactionIsScrollable;
		private CBool _dialogIsScrollable;
		private CBool _lootingIsScrollable;

		[Ordinal(9)] 
		[RED("InteractionsBlackboard")] 
		public CWeakHandle<gameIBlackboard> InteractionsBlackboard
		{
			get => GetProperty(ref _interactionsBlackboard);
			set => SetProperty(ref _interactionsBlackboard, value);
		}

		[Ordinal(10)] 
		[RED("InteractionsBBDefinition")] 
		public CHandle<UIInteractionsDef> InteractionsBBDefinition
		{
			get => GetProperty(ref _interactionsBBDefinition);
			set => SetProperty(ref _interactionsBBDefinition, value);
		}

		[Ordinal(11)] 
		[RED("DialogsDataListenerId")] 
		public CHandle<redCallbackObject> DialogsDataListenerId
		{
			get => GetProperty(ref _dialogsDataListenerId);
			set => SetProperty(ref _dialogsDataListenerId, value);
		}

		[Ordinal(12)] 
		[RED("DialogsActiveHubListenerId")] 
		public CHandle<redCallbackObject> DialogsActiveHubListenerId
		{
			get => GetProperty(ref _dialogsActiveHubListenerId);
			set => SetProperty(ref _dialogsActiveHubListenerId, value);
		}

		[Ordinal(13)] 
		[RED("DialogsSelectedChoiceListenerId")] 
		public CHandle<redCallbackObject> DialogsSelectedChoiceListenerId
		{
			get => GetProperty(ref _dialogsSelectedChoiceListenerId);
			set => SetProperty(ref _dialogsSelectedChoiceListenerId, value);
		}

		[Ordinal(14)] 
		[RED("InteractionsDataListenerId")] 
		public CHandle<redCallbackObject> InteractionsDataListenerId
		{
			get => GetProperty(ref _interactionsDataListenerId);
			set => SetProperty(ref _interactionsDataListenerId, value);
		}

		[Ordinal(15)] 
		[RED("lootingDataListenerId")] 
		public CHandle<redCallbackObject> LootingDataListenerId
		{
			get => GetProperty(ref _lootingDataListenerId);
			set => SetProperty(ref _lootingDataListenerId, value);
		}

		[Ordinal(16)] 
		[RED("AreDialogsOpen")] 
		public CBool AreDialogsOpen
		{
			get => GetProperty(ref _areDialogsOpen);
			set => SetProperty(ref _areDialogsOpen, value);
		}

		[Ordinal(17)] 
		[RED("AreContactsOpen")] 
		public CBool AreContactsOpen
		{
			get => GetProperty(ref _areContactsOpen);
			set => SetProperty(ref _areContactsOpen, value);
		}

		[Ordinal(18)] 
		[RED("IsLootingOpen")] 
		public CBool IsLootingOpen
		{
			get => GetProperty(ref _isLootingOpen);
			set => SetProperty(ref _isLootingOpen, value);
		}

		[Ordinal(19)] 
		[RED("AreInteractionsOpen")] 
		public CBool AreInteractionsOpen
		{
			get => GetProperty(ref _areInteractionsOpen);
			set => SetProperty(ref _areInteractionsOpen, value);
		}

		[Ordinal(20)] 
		[RED("interactionIsScrollable")] 
		public CBool InteractionIsScrollable
		{
			get => GetProperty(ref _interactionIsScrollable);
			set => SetProperty(ref _interactionIsScrollable, value);
		}

		[Ordinal(21)] 
		[RED("dialogIsScrollable")] 
		public CBool DialogIsScrollable
		{
			get => GetProperty(ref _dialogIsScrollable);
			set => SetProperty(ref _dialogIsScrollable, value);
		}

		[Ordinal(22)] 
		[RED("lootingIsScrollable")] 
		public CBool LootingIsScrollable
		{
			get => GetProperty(ref _lootingIsScrollable);
			set => SetProperty(ref _lootingIsScrollable, value);
		}
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractionUIBase : gameuiHUDGameController
	{
		private CHandle<gameIBlackboard> _interactionsBlackboard;
		private CHandle<UIInteractionsDef> _interactionsBBDefinition;
		private CUInt32 _dialogsDataListenerId;
		private CUInt32 _dialogsActiveHubListenerId;
		private CUInt32 _dialogsSelectedChoiceListenerId;
		private CUInt32 _interactionsDataListenerId;
		private CUInt32 _lootingDataListenerId;
		private CBool _areDialogsOpen;
		private CBool _areContactsOpen;
		private CBool _isLootingOpen;
		private CBool _areInteractionsOpen;
		private CBool _interactionIsScrollable;
		private CBool _dialogIsScrollable;
		private CBool _lootingIsScrollable;

		[Ordinal(9)] 
		[RED("InteractionsBlackboard")] 
		public CHandle<gameIBlackboard> InteractionsBlackboard
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
		public CUInt32 DialogsDataListenerId
		{
			get => GetProperty(ref _dialogsDataListenerId);
			set => SetProperty(ref _dialogsDataListenerId, value);
		}

		[Ordinal(12)] 
		[RED("DialogsActiveHubListenerId")] 
		public CUInt32 DialogsActiveHubListenerId
		{
			get => GetProperty(ref _dialogsActiveHubListenerId);
			set => SetProperty(ref _dialogsActiveHubListenerId, value);
		}

		[Ordinal(13)] 
		[RED("DialogsSelectedChoiceListenerId")] 
		public CUInt32 DialogsSelectedChoiceListenerId
		{
			get => GetProperty(ref _dialogsSelectedChoiceListenerId);
			set => SetProperty(ref _dialogsSelectedChoiceListenerId, value);
		}

		[Ordinal(14)] 
		[RED("InteractionsDataListenerId")] 
		public CUInt32 InteractionsDataListenerId
		{
			get => GetProperty(ref _interactionsDataListenerId);
			set => SetProperty(ref _interactionsDataListenerId, value);
		}

		[Ordinal(15)] 
		[RED("lootingDataListenerId")] 
		public CUInt32 LootingDataListenerId
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

		public InteractionUIBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

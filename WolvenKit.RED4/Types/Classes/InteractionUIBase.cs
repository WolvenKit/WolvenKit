using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class InteractionUIBase : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("InteractionsBlackboard")] 
		public CWeakHandle<gameIBlackboard> InteractionsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(10)] 
		[RED("InteractionsBBDefinition")] 
		public CHandle<UIInteractionsDef> InteractionsBBDefinition
		{
			get => GetPropertyValue<CHandle<UIInteractionsDef>>();
			set => SetPropertyValue<CHandle<UIInteractionsDef>>(value);
		}

		[Ordinal(11)] 
		[RED("DialogsDataListenerId")] 
		public CHandle<redCallbackObject> DialogsDataListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("DialogsActiveHubListenerId")] 
		public CHandle<redCallbackObject> DialogsActiveHubListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("DialogsSelectedChoiceListenerId")] 
		public CHandle<redCallbackObject> DialogsSelectedChoiceListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("InteractionsDataListenerId")] 
		public CHandle<redCallbackObject> InteractionsDataListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("lootingDataListenerId")] 
		public CHandle<redCallbackObject> LootingDataListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("AreDialogsOpen")] 
		public CBool AreDialogsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("AreContactsOpen")] 
		public CBool AreContactsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("IsLootingOpen")] 
		public CBool IsLootingOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("AreInteractionsOpen")] 
		public CBool AreInteractionsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("interactionIsScrollable")] 
		public CBool InteractionIsScrollable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("dialogIsScrollable")] 
		public CBool DialogIsScrollable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("lootingIsScrollable")] 
		public CBool LootingIsScrollable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InteractionUIBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

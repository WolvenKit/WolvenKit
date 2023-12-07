using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemsNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(4)] 
		[RED("showDuration")] 
		public CFloat ShowDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(6)] 
		[RED("currencyNotification")] 
		public CName CurrencyNotification
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("itemNotification")] 
		public CName ItemNotification
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("xpNotification")] 
		public CName XpNotification
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(10)] 
		[RED("inventoryListener")] 
		public CWeakHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetPropertyValue<CWeakHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CWeakHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(11)] 
		[RED("currencyInventoryListener")] 
		public CWeakHandle<gameInventoryScriptListener> CurrencyInventoryListener
		{
			get => GetPropertyValue<CWeakHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CWeakHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(12)] 
		[RED("playerDevelopmentSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentSystem>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentSystem>>(value);
		}

		[Ordinal(13)] 
		[RED("combatModeListener")] 
		public CHandle<redCallbackObject> CombatModeListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(15)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetPropertyValue<CHandle<ItemPreferredComparisonResolver>>();
			set => SetPropertyValue<CHandle<ItemPreferredComparisonResolver>>(value);
		}

		[Ordinal(16)] 
		[RED("combatModePSM")] 
		public CEnum<gamePSMCombat> CombatModePSM
		{
			get => GetPropertyValue<CEnum<gamePSMCombat>>();
			set => SetPropertyValue<CEnum<gamePSMCombat>>(value);
		}

		[Ordinal(17)] 
		[RED("delaySystem")] 
		public CHandle<gameDelaySystem> DelaySystem
		{
			get => GetPropertyValue<CHandle<gameDelaySystem>>();
			set => SetPropertyValue<CHandle<gameDelaySystem>>(value);
		}

		public ItemsNotificationQueue()
		{
			ShowDuration = 6.000000F;
			CurrencyNotification = "notification_currency";
			ItemNotification = "Item_Received_SMALL";
			XpNotification = "progression";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

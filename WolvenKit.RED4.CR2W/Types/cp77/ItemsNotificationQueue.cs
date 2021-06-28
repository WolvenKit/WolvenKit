using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemsNotificationQueue : gameuiGenericNotificationGameController
	{
		private CFloat _showDuration;
		private wCHandle<gameTransactionSystem> _transactionSystem;
		private CName _currencyNotification;
		private CName _itemNotification;
		private CName _xpNotification;
		private wCHandle<gameObject> _playerPuppet;
		private wCHandle<gameInventoryScriptListener> _inventoryListener;
		private wCHandle<gameInventoryScriptListener> _currencyInventoryListener;
		private CHandle<gameIBlackboard> _playerStatsBlackboard;
		private CHandle<PlayerDevelopmentSystem> _playerDevelopmentSystem;
		private CUInt32 _combatModeListener;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private CHandle<ItemPreferredComparisonResolver> _comparisonResolver;
		private CEnum<gamePSMCombat> _combatModePSM;

		[Ordinal(2)] 
		[RED("showDuration")] 
		public CFloat ShowDuration
		{
			get => GetProperty(ref _showDuration);
			set => SetProperty(ref _showDuration, value);
		}

		[Ordinal(3)] 
		[RED("transactionSystem")] 
		public wCHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(4)] 
		[RED("currencyNotification")] 
		public CName CurrencyNotification
		{
			get => GetProperty(ref _currencyNotification);
			set => SetProperty(ref _currencyNotification, value);
		}

		[Ordinal(5)] 
		[RED("itemNotification")] 
		public CName ItemNotification
		{
			get => GetProperty(ref _itemNotification);
			set => SetProperty(ref _itemNotification, value);
		}

		[Ordinal(6)] 
		[RED("xpNotification")] 
		public CName XpNotification
		{
			get => GetProperty(ref _xpNotification);
			set => SetProperty(ref _xpNotification, value);
		}

		[Ordinal(7)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(8)] 
		[RED("inventoryListener")] 
		public wCHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}

		[Ordinal(9)] 
		[RED("currencyInventoryListener")] 
		public wCHandle<gameInventoryScriptListener> CurrencyInventoryListener
		{
			get => GetProperty(ref _currencyInventoryListener);
			set => SetProperty(ref _currencyInventoryListener, value);
		}

		[Ordinal(10)] 
		[RED("playerStatsBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("playerDevelopmentSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem
		{
			get => GetProperty(ref _playerDevelopmentSystem);
			set => SetProperty(ref _playerDevelopmentSystem, value);
		}

		[Ordinal(12)] 
		[RED("combatModeListener")] 
		public CUInt32 CombatModeListener
		{
			get => GetProperty(ref _combatModeListener);
			set => SetProperty(ref _combatModeListener, value);
		}

		[Ordinal(13)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(14)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetProperty(ref _comparisonResolver);
			set => SetProperty(ref _comparisonResolver, value);
		}

		[Ordinal(15)] 
		[RED("combatModePSM")] 
		public CEnum<gamePSMCombat> CombatModePSM
		{
			get => GetProperty(ref _combatModePSM);
			set => SetProperty(ref _combatModePSM, value);
		}

		public ItemsNotificationQueue(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

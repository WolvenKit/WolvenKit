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
			get
			{
				if (_showDuration == null)
				{
					_showDuration = (CFloat) CR2WTypeManager.Create("Float", "showDuration", cr2w, this);
				}
				return _showDuration;
			}
			set
			{
				if (_showDuration == value)
				{
					return;
				}
				_showDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transactionSystem")] 
		public wCHandle<gameTransactionSystem> TransactionSystem
		{
			get
			{
				if (_transactionSystem == null)
				{
					_transactionSystem = (wCHandle<gameTransactionSystem>) CR2WTypeManager.Create("whandle:gameTransactionSystem", "transactionSystem", cr2w, this);
				}
				return _transactionSystem;
			}
			set
			{
				if (_transactionSystem == value)
				{
					return;
				}
				_transactionSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currencyNotification")] 
		public CName CurrencyNotification
		{
			get
			{
				if (_currencyNotification == null)
				{
					_currencyNotification = (CName) CR2WTypeManager.Create("CName", "currencyNotification", cr2w, this);
				}
				return _currencyNotification;
			}
			set
			{
				if (_currencyNotification == value)
				{
					return;
				}
				_currencyNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemNotification")] 
		public CName ItemNotification
		{
			get
			{
				if (_itemNotification == null)
				{
					_itemNotification = (CName) CR2WTypeManager.Create("CName", "itemNotification", cr2w, this);
				}
				return _itemNotification;
			}
			set
			{
				if (_itemNotification == value)
				{
					return;
				}
				_itemNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("xpNotification")] 
		public CName XpNotification
		{
			get
			{
				if (_xpNotification == null)
				{
					_xpNotification = (CName) CR2WTypeManager.Create("CName", "xpNotification", cr2w, this);
				}
				return _xpNotification;
			}
			set
			{
				if (_xpNotification == value)
				{
					return;
				}
				_xpNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("inventoryListener")] 
		public wCHandle<gameInventoryScriptListener> InventoryListener
		{
			get
			{
				if (_inventoryListener == null)
				{
					_inventoryListener = (wCHandle<gameInventoryScriptListener>) CR2WTypeManager.Create("whandle:gameInventoryScriptListener", "inventoryListener", cr2w, this);
				}
				return _inventoryListener;
			}
			set
			{
				if (_inventoryListener == value)
				{
					return;
				}
				_inventoryListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("currencyInventoryListener")] 
		public wCHandle<gameInventoryScriptListener> CurrencyInventoryListener
		{
			get
			{
				if (_currencyInventoryListener == null)
				{
					_currencyInventoryListener = (wCHandle<gameInventoryScriptListener>) CR2WTypeManager.Create("whandle:gameInventoryScriptListener", "currencyInventoryListener", cr2w, this);
				}
				return _currencyInventoryListener;
			}
			set
			{
				if (_currencyInventoryListener == value)
				{
					return;
				}
				_currencyInventoryListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("playerStatsBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get
			{
				if (_playerStatsBlackboard == null)
				{
					_playerStatsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "playerStatsBlackboard", cr2w, this);
				}
				return _playerStatsBlackboard;
			}
			set
			{
				if (_playerStatsBlackboard == value)
				{
					return;
				}
				_playerStatsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("playerDevelopmentSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem
		{
			get
			{
				if (_playerDevelopmentSystem == null)
				{
					_playerDevelopmentSystem = (CHandle<PlayerDevelopmentSystem>) CR2WTypeManager.Create("handle:PlayerDevelopmentSystem", "playerDevelopmentSystem", cr2w, this);
				}
				return _playerDevelopmentSystem;
			}
			set
			{
				if (_playerDevelopmentSystem == value)
				{
					return;
				}
				_playerDevelopmentSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("combatModeListener")] 
		public CUInt32 CombatModeListener
		{
			get
			{
				if (_combatModeListener == null)
				{
					_combatModeListener = (CUInt32) CR2WTypeManager.Create("Uint32", "combatModeListener", cr2w, this);
				}
				return _combatModeListener;
			}
			set
			{
				if (_combatModeListener == value)
				{
					return;
				}
				_combatModeListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get
			{
				if (_comparisonResolver == null)
				{
					_comparisonResolver = (CHandle<ItemPreferredComparisonResolver>) CR2WTypeManager.Create("handle:ItemPreferredComparisonResolver", "comparisonResolver", cr2w, this);
				}
				return _comparisonResolver;
			}
			set
			{
				if (_comparisonResolver == value)
				{
					return;
				}
				_comparisonResolver = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("combatModePSM")] 
		public CEnum<gamePSMCombat> CombatModePSM
		{
			get
			{
				if (_combatModePSM == null)
				{
					_combatModePSM = (CEnum<gamePSMCombat>) CR2WTypeManager.Create("gamePSMCombat", "combatModePSM", cr2w, this);
				}
				return _combatModePSM;
			}
			set
			{
				if (_combatModePSM == value)
				{
					return;
				}
				_combatModePSM = value;
				PropertySet(this);
			}
		}

		public ItemsNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

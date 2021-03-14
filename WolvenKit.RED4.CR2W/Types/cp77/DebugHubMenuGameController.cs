using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugHubMenuGameController : gameuiMenuGameController
	{
		private wCHandle<DebugHubMenuLogicController> _menuCtrl;
		private wCHandle<hubSelectorController> _selectorCtrl;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<PlayerDevelopmentSystem> _pDS;
		private CHandle<gameIBlackboard> _playerStatsBlackboard;
		private CUInt32 _currencyListener;
		private CUInt32 _characterCredListener;
		private CUInt32 _characterLevelListener;
		private CUInt32 _characterCurrentXPListener;
		private CUInt32 _characterCredPointsListener;
		private CHandle<gameTransactionSystem> _transaction;

		[Ordinal(3)] 
		[RED("menuCtrl")] 
		public wCHandle<DebugHubMenuLogicController> MenuCtrl
		{
			get
			{
				if (_menuCtrl == null)
				{
					_menuCtrl = (wCHandle<DebugHubMenuLogicController>) CR2WTypeManager.Create("whandle:DebugHubMenuLogicController", "menuCtrl", cr2w, this);
				}
				return _menuCtrl;
			}
			set
			{
				if (_menuCtrl == value)
				{
					return;
				}
				_menuCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("selectorCtrl")] 
		public wCHandle<hubSelectorController> SelectorCtrl
		{
			get
			{
				if (_selectorCtrl == null)
				{
					_selectorCtrl = (wCHandle<hubSelectorController>) CR2WTypeManager.Create("whandle:hubSelectorController", "selectorCtrl", cr2w, this);
				}
				return _selectorCtrl;
			}
			set
			{
				if (_selectorCtrl == value)
				{
					return;
				}
				_selectorCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("PDS")] 
		public CHandle<PlayerDevelopmentSystem> PDS
		{
			get
			{
				if (_pDS == null)
				{
					_pDS = (CHandle<PlayerDevelopmentSystem>) CR2WTypeManager.Create("handle:PlayerDevelopmentSystem", "PDS", cr2w, this);
				}
				return _pDS;
			}
			set
			{
				if (_pDS == value)
				{
					return;
				}
				_pDS = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("currencyListener")] 
		public CUInt32 CurrencyListener
		{
			get
			{
				if (_currencyListener == null)
				{
					_currencyListener = (CUInt32) CR2WTypeManager.Create("Uint32", "currencyListener", cr2w, this);
				}
				return _currencyListener;
			}
			set
			{
				if (_currencyListener == value)
				{
					return;
				}
				_currencyListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("characterCredListener")] 
		public CUInt32 CharacterCredListener
		{
			get
			{
				if (_characterCredListener == null)
				{
					_characterCredListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterCredListener", cr2w, this);
				}
				return _characterCredListener;
			}
			set
			{
				if (_characterCredListener == value)
				{
					return;
				}
				_characterCredListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("characterLevelListener")] 
		public CUInt32 CharacterLevelListener
		{
			get
			{
				if (_characterLevelListener == null)
				{
					_characterLevelListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterLevelListener", cr2w, this);
				}
				return _characterLevelListener;
			}
			set
			{
				if (_characterLevelListener == value)
				{
					return;
				}
				_characterLevelListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("characterCurrentXPListener")] 
		public CUInt32 CharacterCurrentXPListener
		{
			get
			{
				if (_characterCurrentXPListener == null)
				{
					_characterCurrentXPListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterCurrentXPListener", cr2w, this);
				}
				return _characterCurrentXPListener;
			}
			set
			{
				if (_characterCurrentXPListener == value)
				{
					return;
				}
				_characterCurrentXPListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("characterCredPointsListener")] 
		public CUInt32 CharacterCredPointsListener
		{
			get
			{
				if (_characterCredPointsListener == null)
				{
					_characterCredPointsListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterCredPointsListener", cr2w, this);
				}
				return _characterCredPointsListener;
			}
			set
			{
				if (_characterCredPointsListener == value)
				{
					return;
				}
				_characterCredPointsListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("Transaction")] 
		public CHandle<gameTransactionSystem> Transaction
		{
			get
			{
				if (_transaction == null)
				{
					_transaction = (CHandle<gameTransactionSystem>) CR2WTypeManager.Create("handle:gameTransactionSystem", "Transaction", cr2w, this);
				}
				return _transaction;
			}
			set
			{
				if (_transaction == value)
				{
					return;
				}
				_transaction = value;
				PropertySet(this);
			}
		}

		public DebugHubMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

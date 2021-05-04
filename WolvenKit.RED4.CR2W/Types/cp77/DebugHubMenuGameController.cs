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
			get => GetProperty(ref _menuCtrl);
			set => SetProperty(ref _menuCtrl, value);
		}

		[Ordinal(4)] 
		[RED("selectorCtrl")] 
		public wCHandle<hubSelectorController> SelectorCtrl
		{
			get => GetProperty(ref _selectorCtrl);
			set => SetProperty(ref _selectorCtrl, value);
		}

		[Ordinal(5)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(6)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(7)] 
		[RED("PDS")] 
		public CHandle<PlayerDevelopmentSystem> PDS
		{
			get => GetProperty(ref _pDS);
			set => SetProperty(ref _pDS, value);
		}

		[Ordinal(8)] 
		[RED("playerStatsBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(9)] 
		[RED("currencyListener")] 
		public CUInt32 CurrencyListener
		{
			get => GetProperty(ref _currencyListener);
			set => SetProperty(ref _currencyListener, value);
		}

		[Ordinal(10)] 
		[RED("characterCredListener")] 
		public CUInt32 CharacterCredListener
		{
			get => GetProperty(ref _characterCredListener);
			set => SetProperty(ref _characterCredListener, value);
		}

		[Ordinal(11)] 
		[RED("characterLevelListener")] 
		public CUInt32 CharacterLevelListener
		{
			get => GetProperty(ref _characterLevelListener);
			set => SetProperty(ref _characterLevelListener, value);
		}

		[Ordinal(12)] 
		[RED("characterCurrentXPListener")] 
		public CUInt32 CharacterCurrentXPListener
		{
			get => GetProperty(ref _characterCurrentXPListener);
			set => SetProperty(ref _characterCurrentXPListener, value);
		}

		[Ordinal(13)] 
		[RED("characterCredPointsListener")] 
		public CUInt32 CharacterCredPointsListener
		{
			get => GetProperty(ref _characterCredPointsListener);
			set => SetProperty(ref _characterCredPointsListener, value);
		}

		[Ordinal(14)] 
		[RED("Transaction")] 
		public CHandle<gameTransactionSystem> Transaction
		{
			get => GetProperty(ref _transaction);
			set => SetProperty(ref _transaction, value);
		}

		public DebugHubMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

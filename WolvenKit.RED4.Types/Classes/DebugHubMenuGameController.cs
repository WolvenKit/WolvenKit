using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DebugHubMenuGameController : gameuiMenuGameController
	{
		private CWeakHandle<DebugHubMenuLogicController> _menuCtrl;
		private CWeakHandle<hubSelectorController> _selectorCtrl;
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CWeakHandle<PlayerPuppet> _player;
		private CHandle<PlayerDevelopmentSystem> _pDS;
		private CUInt32 _currencyListener;
		private CUInt32 _characterCredListener;
		private CUInt32 _characterLevelListener;
		private CUInt32 _characterCurrentXPListener;
		private CUInt32 _characterCredPointsListener;
		private CHandle<gameTransactionSystem> _transaction;

		[Ordinal(3)] 
		[RED("menuCtrl")] 
		public CWeakHandle<DebugHubMenuLogicController> MenuCtrl
		{
			get => GetProperty(ref _menuCtrl);
			set => SetProperty(ref _menuCtrl, value);
		}

		[Ordinal(4)] 
		[RED("selectorCtrl")] 
		public CWeakHandle<hubSelectorController> SelectorCtrl
		{
			get => GetProperty(ref _selectorCtrl);
			set => SetProperty(ref _selectorCtrl, value);
		}

		[Ordinal(5)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(6)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
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
		[RED("currencyListener")] 
		public CUInt32 CurrencyListener
		{
			get => GetProperty(ref _currencyListener);
			set => SetProperty(ref _currencyListener, value);
		}

		[Ordinal(9)] 
		[RED("characterCredListener")] 
		public CUInt32 CharacterCredListener
		{
			get => GetProperty(ref _characterCredListener);
			set => SetProperty(ref _characterCredListener, value);
		}

		[Ordinal(10)] 
		[RED("characterLevelListener")] 
		public CUInt32 CharacterLevelListener
		{
			get => GetProperty(ref _characterLevelListener);
			set => SetProperty(ref _characterLevelListener, value);
		}

		[Ordinal(11)] 
		[RED("characterCurrentXPListener")] 
		public CUInt32 CharacterCurrentXPListener
		{
			get => GetProperty(ref _characterCurrentXPListener);
			set => SetProperty(ref _characterCurrentXPListener, value);
		}

		[Ordinal(12)] 
		[RED("characterCredPointsListener")] 
		public CUInt32 CharacterCredPointsListener
		{
			get => GetProperty(ref _characterCredPointsListener);
			set => SetProperty(ref _characterCredPointsListener, value);
		}

		[Ordinal(13)] 
		[RED("Transaction")] 
		public CHandle<gameTransactionSystem> Transaction
		{
			get => GetProperty(ref _transaction);
			set => SetProperty(ref _transaction, value);
		}
	}
}

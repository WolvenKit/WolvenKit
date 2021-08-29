using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CurrencyUpdateCallback : gameInventoryScriptCallback
	{
		private CWeakHandle<PlayerStatsUIHolder> _playerStatsUIHolder;
		private CWeakHandle<gameTransactionSystem> _transactionSystem;
		private CWeakHandle<PlayerPuppet> _player;

		[Ordinal(1)] 
		[RED("playerStatsUIHolder")] 
		public CWeakHandle<PlayerStatsUIHolder> PlayerStatsUIHolder
		{
			get => GetProperty(ref _playerStatsUIHolder);
			set => SetProperty(ref _playerStatsUIHolder, value);
		}

		[Ordinal(2)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}
	}
}

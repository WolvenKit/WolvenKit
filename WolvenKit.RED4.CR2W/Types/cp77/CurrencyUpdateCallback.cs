using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurrencyUpdateCallback : gameInventoryScriptCallback
	{
		private wCHandle<PlayerStatsUIHolder> _playerStatsUIHolder;
		private wCHandle<gameTransactionSystem> _transactionSystem;
		private wCHandle<PlayerPuppet> _player;

		[Ordinal(1)] 
		[RED("playerStatsUIHolder")] 
		public wCHandle<PlayerStatsUIHolder> PlayerStatsUIHolder
		{
			get => GetProperty(ref _playerStatsUIHolder);
			set => SetProperty(ref _playerStatsUIHolder, value);
		}

		[Ordinal(2)] 
		[RED("transactionSystem")] 
		public wCHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		public CurrencyUpdateCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

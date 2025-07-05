using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CurrencyUpdateCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("playerStatsUIHolder")] 
		public CWeakHandle<PlayerStatsUIHolder> PlayerStatsUIHolder
		{
			get => GetPropertyValue<CWeakHandle<PlayerStatsUIHolder>>();
			set => SetPropertyValue<CWeakHandle<PlayerStatsUIHolder>>(value);
		}

		[Ordinal(2)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public CurrencyUpdateCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

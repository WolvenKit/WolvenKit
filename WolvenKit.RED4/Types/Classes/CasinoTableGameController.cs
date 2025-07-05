using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CasinoTableGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("casinoChipTDBID")] 
		public TweakDBID CasinoChipTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("multiplier")] 
		public CUInt32 Multiplier
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("slots", 5)] 
		public CArrayFixedSize<CasinoTableSlotData> Slots
		{
			get => GetPropertyValue<CArrayFixedSize<CasinoTableSlotData>>();
			set => SetPropertyValue<CArrayFixedSize<CasinoTableSlotData>>(value);
		}

		[Ordinal(5)] 
		[RED("casinoChipID")] 
		public gameItemID CasinoChipID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(6)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(7)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		public CasinoTableGameController()
		{
			CasinoChipTDBID = "Items.q303_casino_chip";
			Multiplier = 1000;
			Slots = new(5);
			CasinoChipID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

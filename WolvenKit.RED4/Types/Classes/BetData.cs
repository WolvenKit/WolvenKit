using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BetData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("chipsAmount")] 
		public CUInt32 ChipsAmount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("betAmount")] 
		public CUInt32 BetAmount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("betOn")] 
		public CEnum<CasinoTableBet> BetOn
		{
			get => GetPropertyValue<CEnum<CasinoTableBet>>();
			set => SetPropertyValue<CEnum<CasinoTableBet>>(value);
		}

		public BetData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

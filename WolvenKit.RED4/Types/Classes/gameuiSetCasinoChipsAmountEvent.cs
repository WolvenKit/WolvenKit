using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSetCasinoChipsAmountEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CUInt32 Value
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiSetCasinoChipsAmountEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

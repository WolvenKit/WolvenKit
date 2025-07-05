using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cpBumpEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("amount")] 
		public CUInt32 Amount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public cpBumpEvent()
		{
			Amount = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

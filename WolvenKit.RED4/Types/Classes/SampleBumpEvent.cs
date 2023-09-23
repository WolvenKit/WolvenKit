using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SampleBumpEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SampleBumpEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BountyCompletionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("streetCredAwarded")] 
		public CInt32 StreetCredAwarded
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("moneyAwarded")] 
		public CInt32 MoneyAwarded
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public BountyCompletionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

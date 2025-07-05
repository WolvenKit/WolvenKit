using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PaymentBluelinePart : gameinteractionsvisBluelinePart
	{
		[Ordinal(2)] 
		[RED("playerMoney")] 
		public CInt32 PlayerMoney
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("paymentMoney")] 
		public CInt32 PaymentMoney
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PaymentBluelinePart()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PaymentBluelinePart : gameinteractionsvisBluelinePart
	{
		private CInt32 _playerMoney;
		private CInt32 _paymentMoney;

		[Ordinal(2)] 
		[RED("playerMoney")] 
		public CInt32 PlayerMoney
		{
			get => GetProperty(ref _playerMoney);
			set => SetProperty(ref _playerMoney, value);
		}

		[Ordinal(3)] 
		[RED("paymentMoney")] 
		public CInt32 PaymentMoney
		{
			get => GetProperty(ref _paymentMoney);
			set => SetProperty(ref _paymentMoney, value);
		}
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaymentBluelinePart : gameinteractionsvisBluelinePart
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

		public PaymentBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

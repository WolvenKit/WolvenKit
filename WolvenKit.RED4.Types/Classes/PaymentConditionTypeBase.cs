using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PaymentConditionTypeBase : BluelineConditionTypeBase
	{
		private CBool _inverted;
		private CBool _payWhenSucceded;

		[Ordinal(0)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		[Ordinal(1)] 
		[RED("payWhenSucceded")] 
		public CBool PayWhenSucceded
		{
			get => GetProperty(ref _payWhenSucceded);
			set => SetProperty(ref _payWhenSucceded, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PaymentFixedAmount_ScriptConditionType : PaymentConditionTypeBase
	{
		private CUInt32 _payAmount;

		[Ordinal(2)] 
		[RED("payAmount")] 
		public CUInt32 PayAmount
		{
			get => GetProperty(ref _payAmount);
			set => SetProperty(ref _payAmount, value);
		}
	}
}

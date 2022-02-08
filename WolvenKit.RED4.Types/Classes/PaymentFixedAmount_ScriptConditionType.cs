using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PaymentFixedAmount_ScriptConditionType : PaymentConditionTypeBase
	{
		[Ordinal(2)] 
		[RED("payAmount")] 
		public CUInt32 PayAmount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}

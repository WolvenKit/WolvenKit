using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaymentFixedAmount_ScriptConditionType : PaymentConditionTypeBase
	{
		private CUInt32 _payAmount;

		[Ordinal(2)] 
		[RED("payAmount")] 
		public CUInt32 PayAmount
		{
			get => GetProperty(ref _payAmount);
			set => SetProperty(ref _payAmount, value);
		}

		public PaymentFixedAmount_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

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
			get
			{
				if (_payAmount == null)
				{
					_payAmount = (CUInt32) CR2WTypeManager.Create("Uint32", "payAmount", cr2w, this);
				}
				return _payAmount;
			}
			set
			{
				if (_payAmount == value)
				{
					return;
				}
				_payAmount = value;
				PropertySet(this);
			}
		}

		public PaymentFixedAmount_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

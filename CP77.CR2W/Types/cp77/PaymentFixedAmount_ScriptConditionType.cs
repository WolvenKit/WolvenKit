using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PaymentFixedAmount_ScriptConditionType : PaymentConditionTypeBase
	{
		[Ordinal(2)] [RED("payAmount")] public CUInt32 PayAmount { get; set; }

		public PaymentFixedAmount_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

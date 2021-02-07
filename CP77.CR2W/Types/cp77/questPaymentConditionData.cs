using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPaymentConditionData : CVariable
	{
		[Ordinal(0)]  [RED("isInverted")] public CBool IsInverted { get; set; }
		[Ordinal(1)]  [RED("paymentItemId")] public gameItemID PaymentItemId { get; set; }
		[Ordinal(2)]  [RED("paymentAmount")] public CUInt32 PaymentAmount { get; set; }

		public questPaymentConditionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

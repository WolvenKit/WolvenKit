using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PaymentBluelinePart : gameinteractionsvisBluelinePart
	{
		[Ordinal(0)]  [RED("playerMoney")] public CInt32 PlayerMoney { get; set; }
		[Ordinal(1)]  [RED("paymentMoney")] public CInt32 PaymentMoney { get; set; }

		public PaymentBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

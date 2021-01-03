using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PaymentBluelinePart : gameinteractionsvisBluelinePart
	{
		[Ordinal(0)]  [RED("paymentMoney")] public CInt32 PaymentMoney { get; set; }
		[Ordinal(1)]  [RED("playerMoney")] public CInt32 PlayerMoney { get; set; }

		public PaymentBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

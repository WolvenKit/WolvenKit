using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PayActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(18)]  [RED("priceContainer")] public inkWidgetReference PriceContainer { get; set; }
		[Ordinal(19)]  [RED("moneyStatusContainer")] public inkWidgetReference MoneyStatusContainer { get; set; }
		[Ordinal(20)]  [RED("processingStatusContainer")] public inkWidgetReference ProcessingStatusContainer { get; set; }
		[Ordinal(21)]  [RED("moneyStatusAnimName")] public CName MoneyStatusAnimName { get; set; }
		[Ordinal(22)]  [RED("processingAnimName")] public CName ProcessingAnimName { get; set; }
		[Ordinal(23)]  [RED("isProcessingPayment")] public CBool IsProcessingPayment { get; set; }

		public PayActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

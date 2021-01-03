using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PayActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(0)]  [RED("isProcessingPayment")] public CBool IsProcessingPayment { get; set; }
		[Ordinal(1)]  [RED("moneyStatusAnimName")] public CName MoneyStatusAnimName { get; set; }
		[Ordinal(2)]  [RED("moneyStatusContainer")] public inkWidgetReference MoneyStatusContainer { get; set; }
		[Ordinal(3)]  [RED("priceContainer")] public inkWidgetReference PriceContainer { get; set; }
		[Ordinal(4)]  [RED("processingAnimName")] public CName ProcessingAnimName { get; set; }
		[Ordinal(5)]  [RED("processingStatusContainer")] public inkWidgetReference ProcessingStatusContainer { get; set; }

		public PayActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

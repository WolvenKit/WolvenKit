using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PayActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(28)] [RED("priceContainer")] public inkWidgetReference PriceContainer { get; set; }
		[Ordinal(29)] [RED("moneyStatusContainer")] public inkWidgetReference MoneyStatusContainer { get; set; }
		[Ordinal(30)] [RED("processingStatusContainer")] public inkWidgetReference ProcessingStatusContainer { get; set; }
		[Ordinal(31)] [RED("moneyStatusAnimName")] public CName MoneyStatusAnimName { get; set; }
		[Ordinal(32)] [RED("processingAnimName")] public CName ProcessingAnimName { get; set; }
		[Ordinal(33)] [RED("isProcessingPayment")] public CBool IsProcessingPayment { get; set; }

		public PayActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

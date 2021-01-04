using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorItemActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(0)]  [RED("moneyStatusContainer")] public inkWidgetReference MoneyStatusContainer { get; set; }
		[Ordinal(1)]  [RED("priceContainer")] public inkWidgetReference PriceContainer { get; set; }
		[Ordinal(2)]  [RED("priceWidget")] public inkTextWidgetReference PriceWidget { get; set; }
		[Ordinal(3)]  [RED("processingStatusContainer")] public inkWidgetReference ProcessingStatusContainer { get; set; }

		public VendorItemActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

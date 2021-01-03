using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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

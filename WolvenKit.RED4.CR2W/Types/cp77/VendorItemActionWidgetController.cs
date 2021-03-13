using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorItemActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(28)] [RED("priceWidget")] public inkTextWidgetReference PriceWidget { get; set; }
		[Ordinal(29)] [RED("priceContainer")] public inkWidgetReference PriceContainer { get; set; }
		[Ordinal(30)] [RED("moneyStatusContainer")] public inkWidgetReference MoneyStatusContainer { get; set; }
		[Ordinal(31)] [RED("processingStatusContainer")] public inkWidgetReference ProcessingStatusContainer { get; set; }

		public VendorItemActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

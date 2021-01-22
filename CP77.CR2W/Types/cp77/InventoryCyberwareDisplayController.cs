using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryCyberwareDisplayController : InventoryItemDisplayController
	{
		[Ordinal(0)]  [RED("amount")] public inkTextWidgetReference Amount { get; set; }
		[Ordinal(1)]  [RED("amountPanel")] public inkWidgetReference AmountPanel { get; set; }
		[Ordinal(2)]  [RED("ownedFrame")] public inkWidgetReference OwnedFrame { get; set; }
		[Ordinal(3)]  [RED("selectedFrame")] public inkWidgetReference SelectedFrame { get; set; }

		public InventoryCyberwareDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

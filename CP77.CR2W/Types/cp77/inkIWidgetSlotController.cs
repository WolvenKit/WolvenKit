using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkIWidgetSlotController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("slotID")] public CName SlotID { get; set; }
		[Ordinal(2)] [RED("layout")] public inkWidgetLayout Layout { get; set; }

		public inkIWidgetSlotController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

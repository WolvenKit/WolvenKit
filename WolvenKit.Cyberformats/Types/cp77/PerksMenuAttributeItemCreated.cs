using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemCreated : redEvent
	{
		[Ordinal(0)] [RED("perksMenuAttributeItem")] public CHandle<PerksMenuAttributeItemController> PerksMenuAttributeItem { get; set; }

		public PerksMenuAttributeItemCreated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

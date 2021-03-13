using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemChooserItemHoverOut : redEvent
	{
		[Ordinal(0)] [RED("sourceEvent")] public CHandle<inkPointerEvent> SourceEvent { get; set; }

		public ItemChooserItemHoverOut(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

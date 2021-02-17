using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetDefaultHighlightEvent : redEvent
	{
		[Ordinal(0)] [RED("highlightData")] public CHandle<HighlightEditableData> HighlightData { get; set; }

		public SetDefaultHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

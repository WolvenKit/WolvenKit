using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetPersistentForcedHighlightEvent : redEvent
	{
		[Ordinal(0)]  [RED("sourceName")] public CName SourceName { get; set; }
		[Ordinal(1)]  [RED("highlightData")] public CHandle<HighlightEditableData> HighlightData { get; set; }
		[Ordinal(2)]  [RED("operation")] public CEnum<EToggleOperationType> Operation { get; set; }

		public SetPersistentForcedHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

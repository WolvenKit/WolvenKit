using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexForceSelectionEvent : redEvent
	{
		[Ordinal(0)]  [RED("hash")] public CInt32 Hash { get; set; }
		[Ordinal(1)]  [RED("selectionIndex")] public CInt32 SelectionIndex { get; set; }

		public CodexForceSelectionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

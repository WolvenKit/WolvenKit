using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UIObjectiveEntryData : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CString Name { get; set; }
		[Ordinal(1)]  [RED("counter")] public CString Counter { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<UIObjectiveEntryType> Type { get; set; }
		[Ordinal(3)]  [RED("state")] public CEnum<gameJournalEntryState> State { get; set; }
		[Ordinal(4)]  [RED("isTracked")] public CBool IsTracked { get; set; }
		[Ordinal(5)]  [RED("isOptional")] public CBool IsOptional { get; set; }

		public UIObjectiveEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

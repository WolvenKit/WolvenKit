using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SPresetTimetableEntry : CVariable
	{
		[Ordinal(0)]  [RED("time")] public SSimpleGameTime Time { get; set; }
		[Ordinal(1)]  [RED("useTime")] public CBool UseTime { get; set; }
		[Ordinal(2)]  [RED("arrayPosition")] public CInt32 ArrayPosition { get; set; }
		[Ordinal(3)]  [RED("entryID")] public CUInt32 EntryID { get; set; }

		public SPresetTimetableEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

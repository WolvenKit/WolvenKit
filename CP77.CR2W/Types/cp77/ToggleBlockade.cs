using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleBlockade : ActionBool
	{
		[Ordinal(22)]  [RED("TrueRecordName")] public CString TrueRecordName { get; set; }
		[Ordinal(23)]  [RED("FalseRecordName")] public CString FalseRecordName { get; set; }

		public ToggleBlockade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animCorrectivePoseEntry : CVariable
	{
		[Ordinal(0)]  [RED("comparePose")] public CName ComparePose { get; set; }
		[Ordinal(1)]  [RED("correctivePose")] public CName CorrectivePose { get; set; }
		[Ordinal(2)]  [RED("jointsToCompare")] public CArray<CName> JointsToCompare { get; set; }
		[Ordinal(3)]  [RED("enabled")] public CBool Enabled { get; set; }

		public animCorrectivePoseEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

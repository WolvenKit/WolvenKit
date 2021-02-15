using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProgramProgressData : CVariable
	{
		[Ordinal(0)] [RED("id")] public CString Id { get; set; }
		[Ordinal(1)] [RED("completionProgress")] public CArray<CInt32> CompletionProgress { get; set; }
		[Ordinal(2)] [RED("isComplete")] public CBool IsComplete { get; set; }
		[Ordinal(3)] [RED("revealLocalizedName")] public CBool RevealLocalizedName { get; set; }

		public ProgramProgressData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

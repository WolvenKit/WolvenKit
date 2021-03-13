using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioLanguage : CVariable
	{
		[Ordinal(0)] [RED("longName")] public CString LongName { get; set; }
		[Ordinal(1)] [RED("codeName")] public CString CodeName { get; set; }
		[Ordinal(2)] [RED("hasVO")] public CBool HasVO { get; set; }

		public audioLanguage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

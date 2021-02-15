using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalRequestContext : CVariable
	{
		[Ordinal(0)] [RED("stateFilter")] public gameJournalRequestStateFilter StateFilter { get; set; }
		[Ordinal(1)] [RED("classFilter")] public gameJournalRequestClassFilter ClassFilter { get; set; }

		public gameJournalRequestContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

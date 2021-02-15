using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BlacklistEntry : IScriptable
	{
		[Ordinal(0)] [RED("entryID")] public entEntityID EntryID { get; set; }
		[Ordinal(1)] [RED("entryReason")] public CEnum<BlacklistReason> EntryReason { get; set; }
		[Ordinal(2)] [RED("warningsCount")] public CInt32 WarningsCount { get; set; }
		[Ordinal(3)] [RED("reprimandID")] public CInt32 ReprimandID { get; set; }

		public BlacklistEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

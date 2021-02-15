using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AJournalEntryWrapper : ABaseWrapper
	{
		[Ordinal(0)] [RED("UniqueId")] public CInt32 UniqueId { get; set; }

		public AJournalEntryWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

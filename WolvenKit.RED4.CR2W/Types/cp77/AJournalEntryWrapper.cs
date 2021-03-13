using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AJournalEntryWrapper : ABaseWrapper
	{
		[Ordinal(0)] [RED("UniqueId")] public CInt32 UniqueId { get; set; }

		public AJournalEntryWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

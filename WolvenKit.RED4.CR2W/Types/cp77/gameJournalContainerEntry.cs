using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalContainerEntry : gameJournalEntry
	{
		[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }

		public gameJournalContainerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

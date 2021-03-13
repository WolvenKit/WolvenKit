using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestMapPinLink : gameJournalEntry
	{
		[Ordinal(1)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }

		public gameJournalQuestMapPinLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

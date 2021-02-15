using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestMappinLinkController : BaseCodexLinkController
	{
		[Ordinal(4)] [RED("mappinEntry")] public CHandle<gameJournalQuestMapPinBase> MappinEntry { get; set; }
		[Ordinal(5)] [RED("jumpTo")] public Vector3 JumpTo { get; set; }

		public QuestMappinLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

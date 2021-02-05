using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestMappinLinkController : BaseCodexLinkController
	{
		[Ordinal(0)]  [RED("linkImage")] public inkImageWidgetReference LinkImage { get; set; }
		[Ordinal(1)]  [RED("linkLabel")] public inkTextWidgetReference LinkLabel { get; set; }
		[Ordinal(2)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(3)]  [RED("mappinEntry")] public CHandle<gameJournalQuestMapPinBase> MappinEntry { get; set; }
		[Ordinal(4)]  [RED("jumpTo")] public Vector3 JumpTo { get; set; }

		public QuestMappinLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

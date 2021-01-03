using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestMappinLinkController : BaseCodexLinkController
	{
		[Ordinal(0)]  [RED("jumpTo")] public Vector3 JumpTo { get; set; }
		[Ordinal(1)]  [RED("mappinEntry")] public CHandle<gameJournalQuestMapPinBase> MappinEntry { get; set; }

		public QuestMappinLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

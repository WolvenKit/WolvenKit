using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalMetaQuestObjective : gameJournalEntry
	{
		[Ordinal(0)]  [RED("description")] public LocalizationString Description { get; set; }
		[Ordinal(1)]  [RED("iconID")] public TweakDBID IconID { get; set; }
		[Ordinal(2)]  [RED("progressPercent")] public CUInt32 ProgressPercent { get; set; }

		public gameJournalMetaQuestObjective(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

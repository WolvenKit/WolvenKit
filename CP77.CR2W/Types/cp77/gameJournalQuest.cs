using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuest : gameJournalFileEntry
	{
		[Ordinal(0)]  [RED("title")] public LocalizationString Title { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<gameJournalQuestType> Type { get; set; }
		[Ordinal(2)]  [RED("recommendedLevelID")] public TweakDBID RecommendedLevelID { get; set; }
		[Ordinal(3)]  [RED("districtID")] public CString DistrictID { get; set; }

		public gameJournalQuest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

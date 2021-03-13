using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuest : gameJournalFileEntry
	{
		[Ordinal(2)] [RED("title")] public LocalizationString Title { get; set; }
		[Ordinal(3)] [RED("type")] public CEnum<gameJournalQuestType> Type { get; set; }
		[Ordinal(4)] [RED("recommendedLevelID")] public TweakDBID RecommendedLevelID { get; set; }
		[Ordinal(5)] [RED("districtID")] public CString DistrictID { get; set; }

		public gameJournalQuest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

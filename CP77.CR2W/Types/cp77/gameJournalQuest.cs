using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuest : gameJournalFileEntry
	{
		[Ordinal(0)]  [RED("districtID")] public CString DistrictID { get; set; }
		[Ordinal(1)]  [RED("recommendedLevelID")] public TweakDBID RecommendedLevelID { get; set; }
		[Ordinal(2)]  [RED("title")] public LocalizationString Title { get; set; }
		[Ordinal(3)]  [RED("type")] public CEnum<gameJournalQuestType> Type { get; set; }

		public gameJournalQuest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

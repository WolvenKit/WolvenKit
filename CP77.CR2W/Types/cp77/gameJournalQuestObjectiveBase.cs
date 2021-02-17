using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestObjectiveBase : gameJournalContainerEntry
	{
		[Ordinal(2)] [RED("description")] public LocalizationString Description { get; set; }
		[Ordinal(3)] [RED("counter")] public CUInt32 Counter { get; set; }
		[Ordinal(4)] [RED("optional")] public CBool Optional { get; set; }
		[Ordinal(5)] [RED("locationPrefabRef")] public NodeRef LocationPrefabRef { get; set; }
		[Ordinal(6)] [RED("itemID")] public TweakDBID ItemID { get; set; }
		[Ordinal(7)] [RED("districtID")] public CString DistrictID { get; set; }

		public gameJournalQuestObjectiveBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

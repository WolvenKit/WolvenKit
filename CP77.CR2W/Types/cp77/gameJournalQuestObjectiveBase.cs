using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestObjectiveBase : gameJournalContainerEntry
	{
		[Ordinal(0)]  [RED("counter")] public CUInt32 Counter { get; set; }
		[Ordinal(1)]  [RED("description")] public LocalizationString Description { get; set; }
		[Ordinal(2)]  [RED("districtID")] public CString DistrictID { get; set; }
		[Ordinal(3)]  [RED("itemID")] public TweakDBID ItemID { get; set; }
		[Ordinal(4)]  [RED("locationPrefabRef")] public NodeRef LocationPrefabRef { get; set; }
		[Ordinal(5)]  [RED("optional")] public CBool Optional { get; set; }

		public gameJournalQuestObjectiveBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

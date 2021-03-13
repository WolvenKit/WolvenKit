using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestObjectiveWrapper : ABaseQuestObjectiveWrapper
	{
		[Ordinal(6)] [RED("questSubObjectives")] public CArray<CHandle<QuestSubObjectiveWrapper>> QuestSubObjectives { get; set; }

		public QuestObjectiveWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

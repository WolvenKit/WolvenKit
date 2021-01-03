using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestObjectiveWrapper : ABaseQuestObjectiveWrapper
	{
		[Ordinal(0)]  [RED("questSubObjectives")] public CArray<CHandle<QuestSubObjectiveWrapper>> QuestSubObjectives { get; set; }

		public QuestObjectiveWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

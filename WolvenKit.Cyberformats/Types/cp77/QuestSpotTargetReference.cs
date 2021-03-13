using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestSpotTargetReference : ActionEntityReference
	{
		[Ordinal(25)] [RED("ForcedTarget")] public entEntityID ForcedTarget { get; set; }

		public QuestSpotTargetReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

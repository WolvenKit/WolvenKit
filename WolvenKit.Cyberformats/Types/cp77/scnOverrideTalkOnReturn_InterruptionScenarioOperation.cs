using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnOverrideTalkOnReturn_InterruptionScenarioOperation : scnIInterruptionScenarioOperation
	{
		[Ordinal(0)] [RED("talkOnReturn")] public CBool TalkOnReturn { get; set; }

		public scnOverrideTalkOnReturn_InterruptionScenarioOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

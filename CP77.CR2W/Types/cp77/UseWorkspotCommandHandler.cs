using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UseWorkspotCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] [RED("outMoveToWorkspot")] public CHandle<AIArgumentMapping> OutMoveToWorkspot { get; set; }
		[Ordinal(2)] [RED("outForceEntryAnimName")] public CHandle<AIArgumentMapping> OutForceEntryAnimName { get; set; }
		[Ordinal(3)] [RED("outContinueInCombat")] public CHandle<AIArgumentMapping> OutContinueInCombat { get; set; }

		public UseWorkspotCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

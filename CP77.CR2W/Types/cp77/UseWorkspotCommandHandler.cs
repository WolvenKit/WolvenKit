using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UseWorkspotCommandHandler : AICommandHandlerBase
	{
		[Ordinal(0)]  [RED("outContinueInCombat")] public CHandle<AIArgumentMapping> OutContinueInCombat { get; set; }
		[Ordinal(1)]  [RED("outForceEntryAnimName")] public CHandle<AIArgumentMapping> OutForceEntryAnimName { get; set; }
		[Ordinal(2)]  [RED("outMoveToWorkspot")] public CHandle<AIArgumentMapping> OutMoveToWorkspot { get; set; }

		public UseWorkspotCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

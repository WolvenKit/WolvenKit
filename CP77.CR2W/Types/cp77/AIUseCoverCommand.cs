using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIUseCoverCommand : AICombatRelatedCommand
	{
		[Ordinal(0)]  [RED("coverNodeRef")] public NodeRef CoverNodeRef { get; set; }
		[Ordinal(1)]  [RED("oneTimeSelection")] public CBool OneTimeSelection { get; set; }
		[Ordinal(2)]  [RED("forcedEntryAnimation")] public CName ForcedEntryAnimation { get; set; }
		[Ordinal(3)]  [RED("exposureMethods")] public CArray<CEnum<AICoverExposureMethod>> ExposureMethods { get; set; }

		public AIUseCoverCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

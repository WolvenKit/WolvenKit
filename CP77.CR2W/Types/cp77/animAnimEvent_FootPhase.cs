using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FootPhase : animAnimEvent
	{
		[Ordinal(3)] [RED("phase")] public CEnum<animEFootPhase> Phase { get; set; }

		public animAnimEvent_FootPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

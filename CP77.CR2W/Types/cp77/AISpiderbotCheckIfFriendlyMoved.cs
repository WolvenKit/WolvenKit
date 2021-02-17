using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AISpiderbotCheckIfFriendlyMoved : AIAutonomousConditions
	{
		[Ordinal(0)] [RED("maxAllowedDelta")] public CHandle<AIArgumentMapping> MaxAllowedDelta { get; set; }

		public AISpiderbotCheckIfFriendlyMoved(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

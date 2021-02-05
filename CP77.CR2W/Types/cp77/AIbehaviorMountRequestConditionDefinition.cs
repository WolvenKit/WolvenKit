using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMountRequestConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("testMountRequest")] public CBool TestMountRequest { get; set; }
		[Ordinal(1)]  [RED("testUnmountRequest")] public CBool TestUnmountRequest { get; set; }
		[Ordinal(2)]  [RED("acceptInstant")] public CBool AcceptInstant { get; set; }
		[Ordinal(3)]  [RED("acceptNotInstant")] public CBool AcceptNotInstant { get; set; }

		public AIbehaviorMountRequestConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

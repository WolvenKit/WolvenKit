using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFollowerTakedownCommand : AIFollowerCommand
	{
		[Ordinal(5)] [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
		[Ordinal(6)] [RED("approachBeforeTakedown")] public CBool ApproachBeforeTakedown { get; set; }
		[Ordinal(7)] [RED("doNotTeleportIfTargetIsVisible")] public CBool DoNotTeleportIfTargetIsVisible { get; set; }
		[Ordinal(8)] [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public AIFollowerTakedownCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

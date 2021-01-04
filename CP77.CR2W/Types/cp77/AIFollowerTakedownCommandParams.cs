using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFollowerTakedownCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)]  [RED("approachBeforeTakedown")] public CBool ApproachBeforeTakedown { get; set; }
		[Ordinal(1)]  [RED("doNotTeleportIfTargetIsVisible")] public CBool DoNotTeleportIfTargetIsVisible { get; set; }
		[Ordinal(2)]  [RED("targetRef")] public gameEntityReference TargetRef { get; set; }

		public AIFollowerTakedownCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

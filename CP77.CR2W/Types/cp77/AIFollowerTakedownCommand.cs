using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIFollowerTakedownCommand : AIFollowerCommand
	{
		[Ordinal(0)]  [RED("approachBeforeTakedown")] public CBool ApproachBeforeTakedown { get; set; }
		[Ordinal(1)]  [RED("doNotTeleportIfTargetIsVisible")] public CBool DoNotTeleportIfTargetIsVisible { get; set; }
		[Ordinal(2)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(3)]  [RED("targetRef")] public gameEntityReference TargetRef { get; set; }

		public AIFollowerTakedownCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

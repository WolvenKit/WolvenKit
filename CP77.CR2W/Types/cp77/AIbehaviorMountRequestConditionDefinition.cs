using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMountRequestConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("acceptInstant")] public CBool AcceptInstant { get; set; }
		[Ordinal(1)]  [RED("acceptNotInstant")] public CBool AcceptNotInstant { get; set; }
		[Ordinal(2)]  [RED("testMountRequest")] public CBool TestMountRequest { get; set; }
		[Ordinal(3)]  [RED("testUnmountRequest")] public CBool TestUnmountRequest { get; set; }

		public AIbehaviorMountRequestConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

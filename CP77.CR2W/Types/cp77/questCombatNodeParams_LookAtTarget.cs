using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_LookAtTarget : questCombatNodeParams
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("immediately")] public CBool Immediately { get; set; }
		[Ordinal(2)]  [RED("targetNode")] public NodeRef TargetNode { get; set; }
		[Ordinal(3)]  [RED("targetPuppet")] public gameEntityReference TargetPuppet { get; set; }

		public questCombatNodeParams_LookAtTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

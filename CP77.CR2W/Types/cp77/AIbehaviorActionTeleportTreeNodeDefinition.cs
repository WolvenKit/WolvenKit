using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionTeleportTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("destinationPoint")] public CHandle<AIArgumentMapping> DestinationPoint { get; set; }
		[Ordinal(2)] [RED("doNavTest")] public CHandle<AIArgumentMapping> DoNavTest { get; set; }
		[Ordinal(3)] [RED("rotation")] public CHandle<AIArgumentMapping> Rotation { get; set; }

		public AIbehaviorActionTeleportTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

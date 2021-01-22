using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIArchetype : CResource
	{
		[Ordinal(0)]  [RED("behaviorDefinition")] public CHandle<AIbehaviorParameterizedBehavior> BehaviorDefinition { get; set; }
		[Ordinal(1)]  [RED("movementParameters", 5)] public CStatic<moveMovementParameters> MovementParameters { get; set; }

		public AIArchetype(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

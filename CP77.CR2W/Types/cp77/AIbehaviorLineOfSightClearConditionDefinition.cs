using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorLineOfSightClearConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("collisionFilters")] public CArray<CName> CollisionFilters { get; set; }
		[Ordinal(2)] [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(3)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }

		public AIbehaviorLineOfSightClearConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

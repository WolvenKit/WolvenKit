using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArchetype : CResource
	{
		[Ordinal(1)] [RED("behaviorDefinition")] public CHandle<AIbehaviorParameterizedBehavior> BehaviorDefinition { get; set; }
		[Ordinal(2)] [RED("movementParameters", 5)] public CStatic<moveMovementParameters> MovementParameters { get; set; }

		public AIArchetype(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

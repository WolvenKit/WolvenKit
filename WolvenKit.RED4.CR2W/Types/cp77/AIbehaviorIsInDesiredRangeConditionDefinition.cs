using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIsInDesiredRangeConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		[Ordinal(3)] [RED("desiredDistance")] public CHandle<AIArgumentMapping> DesiredDistance { get; set; }
		[Ordinal(4)] [RED("deadZoneRadius")] public CHandle<AIArgumentMapping> DeadZoneRadius { get; set; }

		public AIbehaviorIsInDesiredRangeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

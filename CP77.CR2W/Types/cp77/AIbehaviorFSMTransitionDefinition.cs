using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFSMTransitionDefinition : AIbehaviorBehaviorComponentDefinition
	{
		[Ordinal(0)]  [RED("inState")] public CUInt16 InState { get; set; }
		[Ordinal(1)]  [RED("outState")] public CUInt16 OutState { get; set; }
		[Ordinal(2)]  [RED("evaluationOrder")] public CInt32 EvaluationOrder { get; set; }
		[Ordinal(3)]  [RED("instantConditions")] public CArray<CHandle<AIbehaviorInstantConditionDefinition>> InstantConditions { get; set; }
		[Ordinal(4)]  [RED("monitorConditions")] public CArray<CHandle<AIbehaviorMonitorConditionDefinition>> MonitorConditions { get; set; }
		[Ordinal(5)]  [RED("eventConditions")] public CArray<CHandle<AIbehaviorEventConditionDefinition>> EventConditions { get; set; }
		[Ordinal(6)]  [RED("passiveConditions")] public CArray<CHandle<AIbehaviorExpressionSocket>> PassiveConditions { get; set; }

		public AIbehaviorFSMTransitionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

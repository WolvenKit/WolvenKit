using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindClosestPointOnTrafficPathTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("enterClosest")] public CHandle<AIArgumentMapping> EnterClosest { get; set; }
		[Ordinal(2)] [RED("avoidedPosition")] public CHandle<AIArgumentMapping> AvoidedPosition { get; set; }
		[Ordinal(3)] [RED("avoidedPositionDistance")] public CHandle<AIArgumentMapping> AvoidedPositionDistance { get; set; }
		[Ordinal(4)] [RED("usePreviousPosition")] public CHandle<AIArgumentMapping> UsePreviousPosition { get; set; }
		[Ordinal(5)] [RED("checkRoadIntersection")] public CHandle<AIArgumentMapping> CheckRoadIntersection { get; set; }
		[Ordinal(6)] [RED("positionOnPath")] public CHandle<AIArgumentMapping> PositionOnPath { get; set; }
		[Ordinal(7)] [RED("pathDirection")] public CHandle<AIArgumentMapping> PathDirection { get; set; }
		[Ordinal(8)] [RED("joinTrafficSettings")] public CHandle<AIArgumentMapping> JoinTrafficSettings { get; set; }

		public AIbehaviorFindClosestPointOnTrafficPathTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

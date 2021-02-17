using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GetTargetLastKnownPosition : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("inTargetObject")] public CHandle<AIArgumentMapping> InTargetObject { get; set; }
		[Ordinal(1)] [RED("outPosition")] public CHandle<AIArgumentMapping> OutPosition { get; set; }
		[Ordinal(2)] [RED("predictionTime")] public CFloat PredictionTime { get; set; }

		public GetTargetLastKnownPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

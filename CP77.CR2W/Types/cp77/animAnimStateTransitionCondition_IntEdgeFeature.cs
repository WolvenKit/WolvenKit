using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntEdgeFeature : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] [RED("featureName")] public CName FeatureName { get; set; }
		[Ordinal(1)] [RED("featurePropertyName")] public CName FeaturePropertyName { get; set; }

		public animAnimStateTransitionCondition_IntEdgeFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

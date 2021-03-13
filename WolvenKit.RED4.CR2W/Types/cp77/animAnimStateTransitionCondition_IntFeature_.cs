using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntFeature_ : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] [RED("compareValue")] public CInt32 CompareValue { get; set; }
		[Ordinal(1)] [RED("featureName")] public CName FeatureName { get; set; }
		[Ordinal(2)] [RED("featurePropertyName")] public CName FeaturePropertyName { get; set; }
		[Ordinal(3)] [RED("compareFunc")] public CEnum<animCompareFunc> CompareFunc { get; set; }

		public animAnimStateTransitionCondition_IntFeature_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntFeature : animIAnimStateTransitionCondition
	{
		[Ordinal(0)]  [RED("compareFunc")] public CEnum<animCompareFunc> CompareFunc { get; set; }
		[Ordinal(1)]  [RED("compareValue")] public CInt32 CompareValue { get; set; }
		[Ordinal(2)]  [RED("featureName")] public CName FeatureName { get; set; }
		[Ordinal(3)]  [RED("featurePropertyName")] public CName FeaturePropertyName { get; set; }

		public animAnimStateTransitionCondition_IntFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

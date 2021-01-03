using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_BoolFeature : animIAnimStateTransitionCondition
	{
		[Ordinal(0)]  [RED("compareValue")] public CBool CompareValue { get; set; }
		[Ordinal(1)]  [RED("featureName")] public CName FeatureName { get; set; }
		[Ordinal(2)]  [RED("featurePropertyName")] public CName FeaturePropertyName { get; set; }

		public animAnimStateTransitionCondition_BoolFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

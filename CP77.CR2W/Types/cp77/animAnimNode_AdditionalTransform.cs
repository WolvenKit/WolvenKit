using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AdditionalTransform : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("additionalTransforms")] public animAdditionalTransformContainer AdditionalTransforms { get; set; }

		public animAnimNode_AdditionalTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

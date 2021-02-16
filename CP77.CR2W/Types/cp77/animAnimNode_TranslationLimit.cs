using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TranslationLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
		[Ordinal(3)] [RED("parentTransform")] public animTransformIndex ParentTransform { get; set; }
		[Ordinal(4)] [RED("limitOnXAxis")] public animFloatClamp LimitOnXAxis { get; set; }
		[Ordinal(5)] [RED("limitOnYAxis")] public animFloatClamp LimitOnYAxis { get; set; }
		[Ordinal(6)] [RED("limitOnZAxis")] public animFloatClamp LimitOnZAxis { get; set; }

		public animAnimNode_TranslationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

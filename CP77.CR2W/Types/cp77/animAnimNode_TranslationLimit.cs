using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TranslationLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
		[Ordinal(1)]  [RED("limitOnXAxis")] public animFloatClamp LimitOnXAxis { get; set; }
		[Ordinal(2)]  [RED("limitOnYAxis")] public animFloatClamp LimitOnYAxis { get; set; }
		[Ordinal(3)]  [RED("limitOnZAxis")] public animFloatClamp LimitOnZAxis { get; set; }
		[Ordinal(4)]  [RED("parentTransform")] public animTransformIndex ParentTransform { get; set; }

		public animAnimNode_TranslationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

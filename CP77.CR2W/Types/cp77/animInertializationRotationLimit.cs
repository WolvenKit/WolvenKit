using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animInertializationRotationLimit : CVariable
	{
		[Ordinal(0)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
		[Ordinal(1)] [RED("limitOnX")] public animInertializationFloatClamp LimitOnX { get; set; }
		[Ordinal(2)] [RED("limitOnY")] public animInertializationFloatClamp LimitOnY { get; set; }
		[Ordinal(3)] [RED("limitOnZ")] public animInertializationFloatClamp LimitOnZ { get; set; }

		public animInertializationRotationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

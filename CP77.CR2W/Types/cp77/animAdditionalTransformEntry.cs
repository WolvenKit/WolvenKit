using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAdditionalTransformEntry : ISerializable
	{
		[Ordinal(0)] [RED("transformInfo")] public animTransformInfo TransformInfo { get; set; }
		[Ordinal(1)] [RED("value")] public QsTransform Value { get; set; }

		public animAdditionalTransformEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animStackTransformsExtender_Entry : CVariable
	{
		[Ordinal(0)]  [RED("transformInfo")] public animTransformInfo TransformInfo { get; set; }
		[Ordinal(1)]  [RED("snapMethod")] public CEnum<animStackTransformsExtender_SnapToBoneMethod> SnapMethod { get; set; }
		[Ordinal(2)]  [RED("snapToReference")] public CBool SnapToReference { get; set; }
		[Ordinal(3)]  [RED("snapTargetBone")] public animTransformIndex SnapTargetBone { get; set; }
		[Ordinal(4)]  [RED("offsetToReference")] public CBool OffsetToReference { get; set; }
		[Ordinal(5)]  [RED("offsetSpaceBone")] public animTransformIndex OffsetSpaceBone { get; set; }
		[Ordinal(6)]  [RED("offset")] public QsTransform Offset { get; set; }

		public animStackTransformsExtender_Entry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

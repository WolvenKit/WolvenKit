using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StackTransformsExtender : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("offsetSpaceBones")] public CArray<animTransformIndex> OffsetSpaceBones { get; set; }
		[Ordinal(1)]  [RED("offsetToReferenceValues")] public CArray<CBool> OffsetToReferenceValues { get; set; }
		[Ordinal(2)]  [RED("offsets")] public CArray<QsTransform> Offsets { get; set; }
		[Ordinal(3)]  [RED("snapMethods")] public CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>> SnapMethods { get; set; }
		[Ordinal(4)]  [RED("snapTargetBones")] public CArray<animTransformIndex> SnapTargetBones { get; set; }
		[Ordinal(5)]  [RED("snapToReferenceValues")] public CArray<CBool> SnapToReferenceValues { get; set; }
		[Ordinal(6)]  [RED("tag")] public CName Tag { get; set; }
		[Ordinal(7)]  [RED("transformInfos")] public CArray<animTransformInfo> TransformInfos { get; set; }

		public animAnimNode_StackTransformsExtender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

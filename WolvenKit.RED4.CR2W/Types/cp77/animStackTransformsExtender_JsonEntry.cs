using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animStackTransformsExtender_JsonEntry : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("parentName")] public CName ParentName { get; set; }
		[Ordinal(2)] [RED("referenceTransformLs")] public QsTransform ReferenceTransformLs { get; set; }
		[Ordinal(3)] [RED("snapMethod")] public CEnum<animStackTransformsExtender_SnapToBoneMethod> SnapMethod { get; set; }
		[Ordinal(4)] [RED("snapToReference")] public CBool SnapToReference { get; set; }
		[Ordinal(5)] [RED("snapTargetBone")] public CName SnapTargetBone { get; set; }
		[Ordinal(6)] [RED("offsetToReference")] public CBool OffsetToReference { get; set; }
		[Ordinal(7)] [RED("offsetSpaceBone")] public CName OffsetSpaceBone { get; set; }
		[Ordinal(8)] [RED("offset")] public QsTransform Offset { get; set; }

		public animStackTransformsExtender_JsonEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

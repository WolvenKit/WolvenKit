using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animStackTransformsExtender_JsonEntry : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("offset")] public QsTransform Offset { get; set; }
		[Ordinal(2)]  [RED("offsetSpaceBone")] public CName OffsetSpaceBone { get; set; }
		[Ordinal(3)]  [RED("offsetToReference")] public CBool OffsetToReference { get; set; }
		[Ordinal(4)]  [RED("parentName")] public CName ParentName { get; set; }
		[Ordinal(5)]  [RED("referenceTransformLs")] public QsTransform ReferenceTransformLs { get; set; }
		[Ordinal(6)]  [RED("snapMethod")] public CEnum<animStackTransformsExtender_SnapToBoneMethod> SnapMethod { get; set; }
		[Ordinal(7)]  [RED("snapTargetBone")] public CName SnapTargetBone { get; set; }
		[Ordinal(8)]  [RED("snapToReference")] public CBool SnapToReference { get; set; }

		public animStackTransformsExtender_JsonEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animRigPart : CVariable
	{
		[Ordinal(0)]  [RED("bonesWithRotationInModelSpace")] public CArray<CName> BonesWithRotationInModelSpace { get; set; }
		[Ordinal(1)]  [RED("mask")] public CArray<animTransformMask> Mask { get; set; }
		[Ordinal(2)]  [RED("maskRotMS")] public CArray<CInt32> MaskRotMS { get; set; }
		[Ordinal(3)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(4)]  [RED("singleBones")] public CArray<animRigPartBone> SingleBones { get; set; }
		[Ordinal(5)]  [RED("treeBones")] public CArray<animRigPartBoneTree> TreeBones { get; set; }

		public animRigPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

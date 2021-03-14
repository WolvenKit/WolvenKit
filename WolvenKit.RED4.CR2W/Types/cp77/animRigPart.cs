using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigPart : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("singleBones")] public CArray<animRigPartBone> SingleBones { get; set; }
		[Ordinal(2)] [RED("treeBones")] public CArray<animRigPartBoneTree> TreeBones { get; set; }
		[Ordinal(3)] [RED("bonesWithRotationInModelSpace")] public CArray<CName> BonesWithRotationInModelSpace { get; set; }
		[Ordinal(4)] [RED("mask")] public CArray<animTransformMask> Mask { get; set; }
		[Ordinal(5)] [RED("maskRotMS")] public CArray<CInt32> MaskRotMS { get; set; }

		public animRigPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigIk2Setup : animIRigIkSetup
	{
		[Ordinal(1)] [RED("firstBone")] public CName FirstBone { get; set; }
		[Ordinal(2)] [RED("secondBone")] public CName SecondBone { get; set; }
		[Ordinal(3)] [RED("endBone")] public CName EndBone { get; set; }
		[Ordinal(4)] [RED("hingeAxis")] public CEnum<animAxis> HingeAxis { get; set; }
		[Ordinal(5)] [RED("firstBoneIdx")] public CInt16 FirstBoneIdx { get; set; }
		[Ordinal(6)] [RED("secondBoneIdx")] public CInt16 SecondBoneIdx { get; set; }
		[Ordinal(7)] [RED("endBoneIdx")] public CInt16 EndBoneIdx { get; set; }

		public animRigIk2Setup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
